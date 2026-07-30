
using HotalZormat.Datos.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Datos
{
    public class EstadiaDAL
    {
        private string connectionString = ConexionBD.ObtenerConnectionString();

        public int Insertar(int idReserva, int idHabitacion, string motivo)
        {
            string query = @"INSERT INTO Estadias.Estadia (IdReserva, IdHabitacion, Motivo)
                              VALUES (@IdReserva, @IdHabitacion, @Motivo);
                              SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdReserva", idReserva);
                comando.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                comando.Parameters.AddWithValue("@Motivo", (object)motivo ?? DBNull.Value);

                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return Convert.ToInt32(resultado);
            }
        }

        public void CerrarEstadia(int idEstadia)
        {
            string query = "UPDATE Estadias.Estadia SET FechaFin = GETDATE() WHERE IdEstadia = @IdEstadia";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdEstadia", idEstadia);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerPorId(int idEstadia)
        {
            DataTable tabla = new DataTable();
            string query = @"SELECT e.*, h.Numero
                              FROM Estadias.Estadia e
                              INNER JOIN Habitaciones.Habitacion h ON h.IdHabitacion = e.IdHabitacion
                              WHERE e.IdEstadia = @IdEstadia";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdEstadia", idEstadia);
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        public DataTable ObtenerActivaPorReserva(int idReserva)
        {
            DataTable tabla = new DataTable();
            string query = @"SELECT e.*, h.Numero
                              FROM Estadias.Estadia e
                              INNER JOIN Habitaciones.Habitacion h ON h.IdHabitacion = e.IdHabitacion
                              WHERE e.IdReserva = @IdReserva AND e.FechaFin IS NULL";

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
        // Todas las estadias activas del hotel, con datos de habitacion y huesped para el grid
        public DataTable ObtenerTodasActivas()
        {
            DataTable tabla = new DataTable();
            string query = @"SELECT e.IdEstadia, e.IdReserva, e.IdHabitacion, h.Numero,
                             hu.Nombre + ' ' + hu.Apellido AS NombreHuesped,
                             e.FechaInicio, e.Motivo
                      FROM Estadias.Estadia e
                      INNER JOIN Habitaciones.Habitacion h ON h.IdHabitacion = e.IdHabitacion
                      INNER JOIN Reservas.Reserva r ON r.IdReserva = e.IdReserva
                      INNER JOIN Huespedes.Huesped hu ON hu.IdHuesped = r.IdHuesped
                      WHERE e.FechaFin IS NULL
                      ORDER BY e.FechaInicio";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        // Historial completo de segmentos de una reserva (para ver transferencias pasadas)
        public DataTable ObtenerHistorialPorReserva(int idReserva)
        {
            DataTable tabla = new DataTable();
            string query = @"SELECT e.*, h.Numero
                              FROM Estadias.Estadia e
                              INNER JOIN Habitaciones.Habitacion h ON h.IdHabitacion = e.IdHabitacion
                              WHERE e.IdReserva = @IdReserva
                              ORDER BY e.FechaInicio";

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
    }
}