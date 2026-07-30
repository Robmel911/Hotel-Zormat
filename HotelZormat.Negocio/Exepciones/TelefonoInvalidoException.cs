// Cedula: [tu cedula aqui]
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