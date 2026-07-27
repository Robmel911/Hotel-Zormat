// [tu cedula aqui]
// FacturaService.cs
// Capa de Negocio - Modulo Facturacion
// Regla de arquitectura del proyecto: Service nunca toca SqlConnection/SqlTransaction
// directamente, eso es responsabilidad exclusiva del DAL. Aqui solo se llama al DAL,
// se mapea DataTable -> Factura, y se traducen errores de BD a excepciones de negocio.

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HotelZormat.Datos;
using HotelZormat.Negocio.Excepciones;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class FacturaService
    {
        private FacturaDAL facturaDAL = new FacturaDAL();
        private BitacoraService bitacoraService = new BitacoraService();

        // Factores de ITBIS y PropinaLegal, mismos porcentajes que las columnas
        // calculadas en SQL (0.18 / 0.10). Se repiten aqui SOLO para la vista previa
        // en pantalla antes de guardar -- el valor que realmente queda en BD lo calcula
        // SQL Server, no este metodo. Mismo espiritu que CalcularMonto en ReservaService.
        private const decimal FACTOR_ITBIS = 0.18m;
        private const decimal FACTOR_PROPINA_LEGAL = 0.10m;

        /// <summary>
        /// Calcula el desglose de una factura ANTES de guardarla, para mostrarlo en pantalla
        /// (FrmGenerarFactura). No inserta nada -- es solo para la vista previa.
        /// </summary>
        public void CalcularDesglose(decimal subtotal, out decimal itbis, out decimal propinaLegal, out decimal montoTotal)
        {
            itbis = Math.Round(subtotal * FACTOR_ITBIS, 2);
            propinaLegal = Math.Round(subtotal * FACTOR_PROPINA_LEGAL, 2);
            montoTotal = subtotal + itbis + propinaLegal;
        }

        /// <summary>
        /// Genera la factura (SP hace: insertar factura + liberar habitacion + completar
        /// reserva, todo en una sola transaccion). Si el SP revierte por cualquier motivo,
        /// se traduce el error a FacturaNoGeneradaException para que la UI lo muestre claro.
        /// </summary>
        public int GenerarFactura(int idReserva, int idHabitacion, decimal subtotal, FormaPago formaPago)
        {
            int idFactura;
            try
            {
                idFactura = facturaDAL.GenerarFactura(idReserva, idHabitacion, subtotal, formaPago.ToString());
            }
            catch (SqlException ex)
            {
                // el SP ya hizo ROLLBACK internamente (XACT_ABORT ON); nada quedo a medias
                throw new FacturaNoGeneradaException("No se pudo generar la factura: " + ex.Message, ex);
            }

            // Registro en Bitacora FUERA de la transaccion SQL, decision ya tomada:
            // es auditoria, no debe poder tumbar una operacion de negocio ya confirmada.
            bitacoraService.Registrar( "GenerarFactura",
                $"Factura #{idFactura} generada para Reserva #{idReserva}, Habitacion #{idHabitacion} liberada.");

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
