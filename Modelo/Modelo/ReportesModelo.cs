using System;

namespace HotelZormat.Modelo
{
    public class ReservaOcupadaModelo
    {
        public int Numero { get; set; }
        public string NombreHuesped { get; set; } = string.Empty;
        public string ApellidoHuesped { get; set; } = string.Empty;
        public string NumeroDocumento { get; set; } = string.Empty;
        public DateTime FechaCheckIn { get; set; }
        public DateTime FechaCheckOut { get; set; }
        public string EstadoReserva { get; set; } = string.Empty;
        public string EstadoHabitacion { get; set; } = string.Empty;
    }

    public class FacturaModelo
    {
        public decimal MontoTotal { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}