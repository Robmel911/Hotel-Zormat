// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Negocio.Excepciones
{
    public class CheckInNoRealizadoExeption : Exception
    {
        public CheckInNoRealizadoExeption(string mensaje) : base(mensaje)
        {
        }
    }
}
