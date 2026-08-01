//Cedula 402-1035106-6
using System;

namespace HotelZormat.Modelo
{
    public class EstadiaHistorial
    {
        public int IdEstadia { get; set; }
        public int IdReserva { get; set; }
        public int Numero { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Motivo { get; set; }
        public decimal TotalServicios { get; set; }

        public string Estado
        {
            get { return FechaFin == null ? "Activa" : "Finalizada"; }
        }
    }
}
