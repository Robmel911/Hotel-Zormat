// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Negocio.Modelo
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdReserva { get; set; }

        // NumeroNCF es columna calculada en SQL (PERSISTED), aqui solo se mapea de lectura,
        // nunca se construye ni se envia en un INSERT desde el codigo.
        public string NumeroNCF { get; set; }

        public DateTime FechaEmision { get; set; }

        // Subtotal = snapshot de Reserva.MontoTotal (noches x tarifa), SIN impuestos.
        // Es el unico monto que se inserta a mano; el resto lo deriva SQL Server.
        public decimal Subtotal { get; set; }

        // ITBIS, PropinaLegal y MontoTotal son columnas calculadas en SQL (PERSISTED).
        // Se mapean aqui solo para mostrarlas en pantalla, nunca se insertan a mano.
        public decimal ITBIS { get; set; }
        public decimal PropinaLegal { get; set; }
        public decimal MontoTotal { get; set; }

        public FormaPago FormaPago { get; set; }
        public EstadoFactura Estado { get; set; }

        // Datos de la vista vw_FacturaDetalle, utiles para mostrar en el grid/detalle
        // sin tener que ir a buscar la Reserva/Habitacion/Huesped por separado.
        public int Numero { get; set; }              // numero de habitacion
        public string NombreHuesped { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaCheckIn { get; set; }
        public DateTime FechaCheckOut { get; set; }
        public int CantidadNoches { get; set; }

        public override string ToString()
        {
            // mismo motivo que en Habitacion/Huesped/Reserva: evita que un ListBox/ComboBox
            // muestre el nombre completo de la clase en vez de datos legibles
            return $"{NumeroNCF} - {NombreHuesped} - RD${MontoTotal:N2}";
        }
    }
}
