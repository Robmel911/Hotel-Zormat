// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Negocio.Exepciones
{
    public class ReservaNoDisponibleException : Exception
    {
        public ReservaNoDisponibleException(string mensaje) : base(mensaje) { }
    }
}
