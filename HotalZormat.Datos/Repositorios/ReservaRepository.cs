// Cedula: 402-1035106-6
using HotelZormat.Datos.Conexion;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Datos.Repositorios
{
    public class ReservaRepository
    {
        private string connectionString = ConexionBD.ObtenerConnectionString();

        // Listado completo con detalle (para DataGridView, reportes)
        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Reservas.vw_ReservaDetalle ORDER BY FechaCheckIn DESC";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        // Una reserva puntual, para cargar el formulario de edicion/check-in
        public DataTable ObtenerPorId(int idReserva)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Reservas.vw_ReservaDetalle WHERE IdReserva = @IdReserva";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdReserva", idReserva);

                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        // Reservas con check-in en los proximos 7 dias
        public DataTable ObtenerProximas7Dias()
        {
            DataTable tabla = new DataTable();
            string query = @"SELECT * FROM Reservas.vw_ReservaDetalle
                              WHERE FechaCheckIn BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(DAY, 7, CAST(GETDATE() AS DATE))
                                AND Estado <> 'Cancelada'
                              ORDER BY FechaCheckIn";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        // Devuelve true si la habitacion YA tiene una reserva confirmada que se cruza con ese rango de fechas
        public bool ExisteSolapamiento(int idHabitacion, DateTime checkIn, DateTime checkOut, int idReservaExcluir = 0)
        {
            string query = @"SELECT COUNT(*) FROM Reservas.Reserva
                              WHERE IdHabitacion = @IdHabitacion
                                AND Estado = 'Confirmada'
                                AND IdReserva <> @IdReservaExcluir
                                AND FechaCheckIn < @FechaCheckOut
                                AND FechaCheckOut > @FechaCheckIn";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                comando.Parameters.AddWithValue("@FechaCheckIn", checkIn);
                comando.Parameters.AddWithValue("@FechaCheckOut", checkOut);
                comando.Parameters.AddWithValue("@IdReservaExcluir", idReservaExcluir);

                conexion.Open();
                int cantidad = (int)comando.ExecuteScalar();
                return cantidad > 0;
            }
        }

        // Inserta la reserva y devuelve el IdReserva generado
        public int Insertar(int idHabitacion, int idHuesped, DateTime checkIn, DateTime checkOut,
                             string temporada, decimal tarifaAplicada, decimal montoTotal)
        {
            string query = @"INSERT INTO Reservas.Reserva
                                  (IdHabitacion, IdHuesped, FechaCheckIn, FechaCheckOut, Temporada, TarifaAplicada, MontoTotal)
                              VALUES
                                  (@IdHabitacion, @IdHuesped, @FechaCheckIn, @FechaCheckOut, @Temporada, @TarifaAplicada, @MontoTotal);
                              SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                comando.Parameters.AddWithValue("@IdHuesped", idHuesped);
                comando.Parameters.AddWithValue("@FechaCheckIn", checkIn);
                comando.Parameters.AddWithValue("@FechaCheckOut", checkOut);
                comando.Parameters.AddWithValue("@Temporada", temporada);
                comando.Parameters.AddWithValue("@TarifaAplicada", tarifaAplicada);
                comando.Parameters.AddWithValue("@MontoTotal", montoTotal);

                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return Convert.ToInt32(resultado);
            }
        }

        // Cambia el estado de una reserva (Pendiente -> Confirmada / Cancelada)
        public bool ActualizarEstado(int idReserva, string nuevoEstado)
        {
            string query = "UPDATE Reservas.Reserva SET Estado = @Estado WHERE IdReserva = @IdReserva";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Estado", nuevoEstado);
                comando.Parameters.AddWithValue("@IdReserva", idReserva);

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }
       
    }
}