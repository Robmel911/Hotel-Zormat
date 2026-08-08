// Cedula: 402-1035106-6
using HotelZormat.Modelo;
using System;

namespace HotelZormat.Negocio.Excepciones
{
    public class CambioEstadoNoPermitidoException : Exception
    {
        public EstadoHabitacion EstadoActual { get; }
        public EstadoHabitacion EstadoDestino { get; }

        public CambioEstadoNoPermitidoException(EstadoHabitacion estadoActual, EstadoHabitacion estadoDestino)
            : base(ConstruirMensaje(estadoActual, estadoDestino))
        {
            EstadoActual = estadoActual;
            EstadoDestino = estadoDestino;
        }

        private static string ConstruirMensaje(EstadoHabitacion estadoActual, EstadoHabitacion estadoDestino)
        {
            if (estadoActual != EstadoHabitacion.Limpieza)
            {
                return "Solo se puede cambiar el estado manualmente cuando la habitacion esta en Limpieza. Estado actual: " + estadoActual;
            }

            return "Desde Limpieza solo se puede pasar a Disponible. Estado solicitado: " + estadoDestino;
        }
    }
}