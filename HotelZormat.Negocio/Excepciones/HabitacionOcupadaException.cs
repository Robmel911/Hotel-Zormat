using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Excepciones
{
    public class HabitacionOcupadaException : Exception
    {
        public int NumeroHabitacion { get; set; }

        public HabitacionOcupadaException(int numeroHabitacion)
            : base($"La habitación {numeroHabitacion} está ocupada.")
        {
            NumeroHabitacion = numeroHabitacion;
        }

        public HabitacionOcupadaException(int numeroHabitacion, string message)
            : base(message)
        {
            NumeroHabitacion = numeroHabitacion;
        }
    }
}