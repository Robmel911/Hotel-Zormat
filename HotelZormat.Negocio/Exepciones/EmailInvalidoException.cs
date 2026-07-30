// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Negocio.Excepciones
{
    public class EmailInvalidoException : Exception
    {
        public EmailInvalidoException(string mensaje) : base(mensaje)
        {
        }
    }
}
