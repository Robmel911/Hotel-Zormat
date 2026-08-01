//Cedula 402-1035106-6

using HotelZormat.Datos;
using HotelZormat.Negocio.Excepciones;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Negocio.Servicios
{
    public class FacturaService
    {
        private FacturaRepository facturaDAL = new FacturaRepository();
        private BitacoraService bitacoraService = new BitacoraService();

        // Factores de ITBIS y PropinaLegal, mismos porcentajes que las columnas
        // calculadas en SQL (0.18 / 0.10). Se repiten aqui SOLO para la vista previa
        // en pantalla antes de guardar -- el valor que realmente queda en BD lo calcula
        // el stored procedure, no este metodo.
        private const decimal FACTOR_ITBIS = 0.18m;
        private const decimal FACTOR_PROPINA_LEGAL = 0.10m;

        /// <summary>
        /// Calcula ITBIS/PropinaLegal/MontoTotal a partir de un Subtotal ya conocido.
        /// </summary>
        public void CalcularDesglose(decimal subtotal, out decimal itbis, out decimal propinaLegal, out decimal montoTotal)
        {
            itbis = Math.Round(subtotal * FACTOR_ITBIS, 2);
            propinaLegal = Math.Round(subtotal * FACTOR_PROPINA_LEGAL, 2);
            montoTotal = subtotal + itbis + propinaLegal;
        }

        /// <summary>
        /// Arma el desglose completo ANTES de guardar, para FrmGenerarFactura.
        /// Trae CostoReserva + ConsumoServicios del DAL y les aplica CalcularDesglose.
        /// </summary>
        public DesgloseFactura ObtenerDesglosePrevio(int idReserva)
        {
            DataTable tabla = facturaDAL.ObtenerSubtotalParaFacturar(idReserva);
            if (tabla.Rows.Count == 0)
            {
                throw new FacturaNoGeneradaException("No se encontró información de la reserva para facturar.");
            }

            DataRow fila = tabla.Rows[0];
            decimal subtotal = Convert.ToDecimal(fila["Subtotal"]);

            decimal itbis, propinaLegal, montoTotal;
            CalcularDesglose(subtotal, out itbis, out propinaLegal, out montoTotal);

            return new DesgloseFactura
            {
                CostoReserva = Convert.ToDecimal(fila["CostoReserva"]),
                ConsumoServicios = Convert.ToDecimal(fila["ConsumoServicios"]),
                Subtotal = subtotal,
                ITBIS = itbis,
                PropinaLegal = propinaLegal,
                MontoTotal = montoTotal
            };
        }

        /// <summary>
        /// Genera la factura. El SP hace: calcular Subtotal + insertar factura +
        /// pasar habitacion a Limpieza + completar reserva + cerrar estadia activa,
        /// todo en una sola transaccion atomica.
        /// </summary>
        public int GenerarFactura(int idReserva, int idHabitacion, FormaPago formaPago)
        {
            int idFactura;
            try
            {
                idFactura = facturaDAL.GenerarFactura(idReserva, idHabitacion, formaPago.ToString());
            }
            catch (SqlException ex)
            {
                throw new FacturaNoGeneradaException("No se pudo generar la factura: " + ex.Message, ex);
            }

            bitacoraService.Registrar( "GenerarFactura",
                $"Factura #{idFactura} generada para Reserva #{idReserva}, Habitacion #{idHabitacion} enviada a Limpieza.");

            return idFactura;
        }

        /// <summary>
        /// Lista completa de facturas, mapeada a objetos, para el grid de FrmGestionFacturas.
        /// </summary>
        public List<Factura> ObtenerTodos()
        {
            DataTable tabla = facturaDAL.ObtenerTodos();
            return MapearLista(tabla);
        }

        /// <summary>
        /// Una factura puntual por Id, o null si no existe.
        /// </summary>
        public Factura ObtenerPorId(int idFactura)
        {
            DataTable tabla = facturaDAL.ObtenerPorId(idFactura);
            if (tabla.Rows.Count == 0) return null;
            return MapearFactura(tabla.Rows[0]);
        }

        /// <summary>
        /// La factura asociada a una reserva (0 o 1, por la restriccion 1 a 1), o null.
        /// </summary>
        public Factura ObtenerPorReserva(int idReserva)
        {
            DataTable tabla = facturaDAL.ObtenerPorReserva(idReserva);
            if (tabla.Rows.Count == 0) return null;
            return MapearFactura(tabla.Rows[0]);
        }

        /// <summary>
        /// true/false segun exista factura para esa reserva. Este es el metodo que
        /// reemplaza el placeholder ReservaService.TieneFacturaAsociada() (return false).
        /// </summary>
        public bool TieneFacturaAsociada(int idReserva)
        {
            return facturaDAL.ExisteFacturaPorReserva(idReserva);
        }

        /// <summary>
        /// Borrado logico: pasa la factura a Estado = Anulada.
        /// </summary>
        public void Anular(int idFactura)
        {
            facturaDAL.Anular(idFactura);
        }

        private List<Factura> MapearLista(DataTable tabla)
        {
            var lista = new List<Factura>();
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(MapearFactura(fila));
            }
            return lista;
        }

        private Factura MapearFactura(DataRow fila)
        {
            return new Factura
            {
                IdFactura = Convert.ToInt32(fila["IdFactura"]),
                NumeroNCF = fila["NumeroNCF"].ToString(),
                IdReserva = Convert.ToInt32(fila["IdReserva"]),
                Numero = Convert.ToInt32(fila["Numero"]),
                NombreHuesped = fila["NombreHuesped"].ToString(),
                NumeroDocumento = fila["NumeroDocumento"].ToString(),
                FechaCheckIn = Convert.ToDateTime(fila["FechaCheckIn"]),
                FechaCheckOut = Convert.ToDateTime(fila["FechaCheckOut"]),
                CantidadNoches = Convert.ToInt32(fila["CantidadNoches"]),
                FechaEmision = Convert.ToDateTime(fila["FechaEmision"]),
                Subtotal = Convert.ToDecimal(fila["Subtotal"]),
                ITBIS = Convert.ToDecimal(fila["ITBIS"]),
                PropinaLegal = Convert.ToDecimal(fila["PropinaLegal"]),
                MontoTotal = Convert.ToDecimal(fila["MontoTotal"]),
                FormaPago = (FormaPago)Enum.Parse(typeof(FormaPago), fila["FormaPago"].ToString()),
                Estado = (EstadoFactura)Enum.Parse(typeof(EstadoFactura), fila["Estado"].ToString())
            };
        }
    }
}