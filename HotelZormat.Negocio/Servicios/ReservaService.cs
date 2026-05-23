using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Servicios
{
    // TODO:
    public class ReservaService
    {
        /// <summary>
        /// Verifica si el tipo de habitación es uno de los permitidos.
        /// Reto 01 · usa if / else
        /// /// </summary>
        public bool ValidarTipoHabitacion(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo)) return false;
            return tipo == "Sencilla" || tipo == "Doble" || tipo == "Suite";
        }
    }
}
