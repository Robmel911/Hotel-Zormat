using System;

namespace HotelZormat.Negocio.Exepciones
{
   public class NoConexionBdException : Exception
    {
        public NoConexionBdException(string mensaje) : base(mensaje)
        {
        }
    }
}
