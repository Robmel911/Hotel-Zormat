// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Negocio
{
    public class ReservaFechasInvalidasException : Exception
    {
        public ReservaFechasInvalidasException(string mensaje) : base(mensaje) { }
    }
}
