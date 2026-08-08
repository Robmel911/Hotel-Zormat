// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Negocio.Excepciones
{
    public class FacturaNoGeneradaException : Exception
    {
        public FacturaNoGeneradaException(string mensaje) : base(mensaje) { }
        public FacturaNoGeneradaException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
