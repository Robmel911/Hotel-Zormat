using System;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicio = new ReservaService();

            // Aquí llamaremos los métodos de cada reto para probarlos
            Console.WriteLine("--- RETO 01: ValidarTipoHabitacion ---");
            Console.WriteLine("Suite     → " + servicio.ValidarTipoHabitacion("Suite"));
            Console.WriteLine("Sencilla  → " + servicio.ValidarTipoHabitacion("Sencilla"));
            Console.WriteLine("Penthouse → " + servicio.ValidarTipoHabitacion("Penthouse"));
            Console.WriteLine("(vacío)   → " + servicio.ValidarTipoHabitacion(""));
            Console.WriteLine("(null)    → " + servicio.ValidarTipoHabitacion(null));

            Console.WriteLine("\n--- RETO 02: ObtenerDescuentoPorTemporada ---");
            Console.WriteLine("Baja  → " + servicio.ObtenerDescuentoPorTemporada("Baja"));
            Console.WriteLine("Media → " + servicio.ObtenerDescuentoPorTemporada("Media"));
            Console.WriteLine("Alta  → " + servicio.ObtenerDescuentoPorTemporada("Alta"));
            Console.WriteLine("Pico  → " + servicio.ObtenerDescuentoPorTemporada("Pico"));

            try
            {
                servicio.ObtenerDescuentoPorTemporada("Otoño");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Otoño → excepción: " + ex.Message);
            }

            Console.WriteLine("\n--- Tests finalizados ---");
            Console.ReadKey();
        }
    }
}