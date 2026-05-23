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

        /// <summary>
        /// Devuelve el factor a aplicar según la temporada.
        /// Positivo = descuento, negativo = recarga.
        /// Reto 02 · usa switch
        /// /// </summary>
        public decimal ObtenerDescuentoPorTemporada(string temporada)
        {
            decimal factor;

              switch (temporada)
             {
                 case "Baja":
                     factor = 0.20m;
                     break;

                 case "Media":
                     factor = 0.10m;
                     break;

                 case "Alta":
                     factor = 0m;
                     break;

                 case "Pico":
                     factor = -0.15m;   // negativo = recarga
                     break;

                 default:
                     throw new ArgumentException("Temporada desconocida: " + temporada);
             }

             return factor;

        
        }
    }
}
