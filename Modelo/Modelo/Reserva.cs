// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Modelo
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        public int IdHuesped { get; set; }
        public string NombreHuesped { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaCheckIn { get; set; }
        public DateTime FechaCheckOut { get; set; }
        public int CantidadNoches { get; set; }
        public EstadoReserva Estado { get; set; }
        public Temporada Temporada { get; set; }
        public decimal TarifaAplicada { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Reserva() { }

        public Reserva(int idHabitacion, int idHuesped, DateTime fechaCheckIn, DateTime fechaCheckOut,
                        Temporada temporada, decimal tarifaAplicada, decimal montoTotal)
        {
            IdHabitacion = idHabitacion;
            IdHuesped = idHuesped;
            FechaCheckIn = fechaCheckIn;
            FechaCheckOut = fechaCheckOut;
            Temporada = temporada;
            TarifaAplicada = tarifaAplicada;
            MontoTotal = montoTotal;
            Estado = EstadoReserva.Pendiente;
        }

        public override string ToString()
        {
            return "Hab. " + Numero.ToString() + " - " + NombreHuesped + " (" + Estado.ToString() + ")";
        }
    }
}
