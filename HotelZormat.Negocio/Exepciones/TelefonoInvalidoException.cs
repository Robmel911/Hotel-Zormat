//Cedula 402-1035106-6
using System;

namespace HotelZormat.Negocio.Excepciones
{
    public class TelefonoInvalidoException : Exception
    {
        public TelefonoInvalidoException(string mensaje) : base(mensaje)
        {
        }
    }
}