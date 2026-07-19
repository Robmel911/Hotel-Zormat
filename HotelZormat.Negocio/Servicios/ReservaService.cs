using HotelZormat.Negocio.Modelo;
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
        /// <summary>
        /// Genera las líneas de detalle de una factura, una por noche.
        /// Devuelve una lista de strings con el formato "Noche N: RD$ tarifa".
        /// Reto 03 · usa for
        /// /// </summary>
        public List<string> GenerarLineasFactura(int noches, decimal tarifaPorNoche)
        {
            var lineas = new List<string>();

            if (noches <= 0)
            {
                return lineas;       // devuelve lista vacía
            }

            for (int i = 1; i <= noches; i++)
            {
                string linea = "Noche " + i + ": RD$ " + tarifaPorNoche;
                lineas.Add(linea);
            }

            return lineas;
        }
        /// <summary>
        /// Encuentra la primera habitación disponible con capacidad mínima.
        /// Devuelve null si no hay ninguna que cumpla.
        /// Reto 04 · usa foreach + if + break
        /// /// </summary>
        public Habitacion BuscarPrimeraDisponible(
            List<Habitacion> habitaciones,
            int capacidadMinima)
        {
            if (habitaciones == null)
            {
                return null;
            }

            Habitacion encontrada = null;

            foreach (var hab in habitaciones)
            {
                if (hab.EstaDisponible() && hab.Capacidad >= capacidadMinima)
                {
                    encontrada = hab;
                    break;             // ya encontramos una, no seguimos buscando
                }
            }

            return encontrada;
        }

        
    }

}
