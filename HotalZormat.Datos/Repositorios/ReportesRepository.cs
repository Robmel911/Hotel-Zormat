//Cedula 402-1035106-6
using HotelZormat.Modelo;
using HotelZormat.Datos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace HotelZormat.Repositorios
{
    public class ReportesRepositorio
    {
        private readonly string _connectionString = ConexionBD.ObtenerConnectionString();
        private const int CommandTimeoutSegundos = 30;

        public async Task<List<ReservaOcupadaModelo>> GetReservasActivasAsync(DateTime fecha, CancellationToken ct = default)
        {
            const string sql = @"
                SELECT
                    h.Numero,
                    hu.Nombre AS NombreHuesped,
                    hu.Apellido AS ApellidoHuesped,
                    hu.NumeroDocumento,
                    r.FechaCheckIn,
                    r.FechaCheckOut,
                    r.Estado AS EstadoReserva,
                    h.Estado AS EstadoHabitacion
                FROM Habitaciones.Habitacion h
                INNER JOIN Reservas.Reserva r ON r.IdHabitacion = h.IdHabitacion
                INNER JOIN Huespedes.Huesped hu ON hu.IdHuesped = r.IdHuesped
                WHERE @Fecha >= r.FechaCheckIn AND @Fecha < r.FechaCheckOut;";

            var resultado = new List<ReservaOcupadaModelo>();

            using (SqlConnection conexion = new SqlConnection(_connectionString))
            using (var comando = new SqlCommand(sql, conexion) { CommandTimeout = CommandTimeoutSegundos })
            {
                comando.Parameters.Add("@Fecha", System.Data.SqlDbType.Date).Value = fecha.Date;

                await conexion.OpenAsync(ct);
                using (var reader = await comando.ExecuteReaderAsync(ct))
                {
                    while (await reader.ReadAsync(ct))
                    {
                        resultado.Add(new ReservaOcupadaModelo
                        {
                            Numero = reader.GetInt32(reader.GetOrdinal("Numero")),
                            NombreHuesped = reader.GetString(reader.GetOrdinal("NombreHuesped")),
                            ApellidoHuesped = reader.GetString(reader.GetOrdinal("ApellidoHuesped")),
                            NumeroDocumento = reader.GetString(reader.GetOrdinal("NumeroDocumento")),
                            FechaCheckIn = reader.GetDateTime(reader.GetOrdinal("FechaCheckIn")),
                            FechaCheckOut = reader.GetDateTime(reader.GetOrdinal("FechaCheckOut")),
                            EstadoReserva = reader.GetString(reader.GetOrdinal("EstadoReserva")),
                            EstadoHabitacion = reader.GetString(reader.GetOrdinal("EstadoHabitacion"))
                        });
                    }
                }
            }
            return resultado;
        }

        public async Task<List<FacturaModelo>> GetFacturasPorRangoAsync(DateTime desde, DateTime hasta, CancellationToken ct = default)
        {
            const string sql = @"
                SELECT f.MontoTotal, f.FechaEmision, f.Estado
                FROM Facturacion.Factura f
                WHERE f.FechaEmision >= @Desde AND f.FechaEmision < DATEADD(DAY, 1, @Hasta);";

            var resultado = new List<FacturaModelo>();

            using (var conexion = new SqlConnection(_connectionString))
            using (var comando = new SqlCommand(sql, conexion) { CommandTimeout = CommandTimeoutSegundos })
            {
                comando.Parameters.Add("@Desde", System.Data.SqlDbType.DateTime).Value = desde.Date;
                comando.Parameters.Add("@Hasta", System.Data.SqlDbType.DateTime).Value = hasta.Date;

                await conexion.OpenAsync(ct);
                using (var reader = await comando.ExecuteReaderAsync(ct))
                {
                    while (await reader.ReadAsync(ct))
                    {
                        resultado.Add(new FacturaModelo
                        {
                            MontoTotal = reader.GetDecimal(reader.GetOrdinal("MontoTotal")),
                            FechaEmision = reader.GetDateTime(reader.GetOrdinal("FechaEmision")),
                            Estado = reader.GetString(reader.GetOrdinal("Estado"))
                        });
                    }
                }
            }
            return resultado;
        }
    }
}