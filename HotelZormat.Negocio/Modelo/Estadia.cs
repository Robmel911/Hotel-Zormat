// Estadia.cs
using System;

namespace HotelZormat.Negocio.Modelo
{
    public class Estadia
    {
        public int IdEstadia { get; set; }
        public int IdReserva { get; set; }
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Motivo { get; set; }

        public bool EstaActiva
        {
            get { return FechaFin == null; }
        }

        public override string ToString()
        {
            string estado = EstaActiva ? "Activa" : "Cerrada";
            return "Hab. " + Numero.ToString() + " (" + estado + ")";
        }
    }
}
