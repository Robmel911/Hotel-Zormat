using HotelZormat.Modelo;
using HotelZormat.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Servicios
{
    public class ReportesService
    {
        private readonly ReportesRepositorio _repo = new ReportesRepositorio();

        public async Task<List<ReservaOcupadaModelo>> GetOcupacionDelDiaAsync(DateTime fecha)
        {
            var reservas = await _repo.GetReservasActivasAsync(fecha);

            // Conversión explícita para evitar conflictos de ensamblado
            return reservas
                .Where(r => r.EstadoHabitacion == "Ocupada" && r.EstadoReserva == "Confirmada")
                .Select(r => new ReservaOcupadaModelo
                {
                    Numero = r.Numero,
                    NombreHuesped = r.NombreHuesped,
                    ApellidoHuesped = r.ApellidoHuesped,
                    NumeroDocumento = r.NumeroDocumento,
                    FechaCheckIn = r.FechaCheckIn,
                    FechaCheckOut = r.FechaCheckOut,
                    EstadoReserva = r.EstadoReserva,
                    EstadoHabitacion = r.EstadoHabitacion
                })
                .ToList();
        }

        public async Task<decimal> GetIngresosPorRangoAsync(DateTime desde, DateTime hasta)
        {
            var facturas = await _repo.GetFacturasPorRangoAsync(desde, hasta);

            return facturas
                .Where(f => f.Estado == "Emitida")
                .Sum(f => f.MontoTotal);
        }
        public async Task<List<FacturaModelo>> GetFacturasPorRangoAsync(DateTime desde, DateTime hasta)
        {
            var facturas = await _repo.GetFacturasPorRangoAsync(desde, hasta);

            return facturas
                .Where(f => f.Estado == "Emitida")
                .ToList();
        }
    }
}