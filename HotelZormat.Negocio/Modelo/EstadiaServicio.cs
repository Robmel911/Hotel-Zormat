// EstadiaServicio.cs
using System;

namespace HotelZormat.Negocio
{
    public class EstadiaServicio
    {
        public int IdEstadiaServicio { get; set; }
        public int IdEstadia { get; set; }
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public DateTime FechaConsumo { get; set; }

        public decimal Subtotal
        {
            get { return Cantidad * PrecioUnitario; }
        }

        public override string ToString()
        {
            return NombreServicio + " x" + Cantidad.ToString() + " - " + Subtotal.ToString("C2");
        }
    }
}
