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
 
            Console.WriteLine("\n--- Tests finalizados ---");
            Console.ReadKey();
        }
    }
}