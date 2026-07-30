// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Negocio.Excepciones
{
    public class NombreInvalidoException : Exception
    {
        public NombreInvalidoException(string mensaje) : base(mensaje)
        {
        }
    }
}