//Cedula 402-1035106-6
using HotelZormat.Datos.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Datos
{
    public class EstadiaServicioRepository
    {
        private string connectionString = ConexionBD.ObtenerConnectionString();

        // Detalle de servicios consumidos en una estadia especifica (para el form de gestion)
        public DataTable ObtenerPorEstadia(int idEstadia)
        {
            DataTable tabla = new DataTable();
            string query = @"SELECT es.*, s.Nombre AS NombreServicio
                              FROM Estadias.EstadiaServicio es
                              INNER JOIN Estadias.Servicio s ON s.IdServicio = es.IdServicio
                              WHERE es.IdEstadia = @IdEstadia
                              ORDER BY es.FechaConsumo DESC";

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

        public int Insertar(int idEstadia, int idServicio, int cantidad, decimal precioUnitario)
        {
            string query = @"INSERT INTO Estadias.EstadiaServicio (IdEstadia, IdServicio, Cantidad, PrecioUnitario)
                              VALUES (@IdEstadia, @IdServicio, @Cantidad, @PrecioUnitario);
                              SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdEstadia", idEstadia);
                comando.Parameters.AddWithValue("@IdServicio", idServicio);
                comando.Parameters.AddWithValue("@Cantidad", cantidad);
                comando.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);

                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return Convert.ToInt32(resultado);
            }
        }

        public bool Eliminar(int idEstadiaServicio)
        {
            string query = "DELETE FROM Estadias.EstadiaServicio WHERE IdEstadiaServicio = @IdEstadiaServicio";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdEstadiaServicio", idEstadiaServicio);
                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        // Total consumido en una estadia (usa la vista que ya dejamos lista para Facturacion)
        public decimal ObtenerTotalPorEstadia(int idEstadia)
        {
            string query = "SELECT TotalServicios FROM Estadias.vw_ConsumoPorEstadia WHERE IdEstadia = @IdEstadia";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdEstadia", idEstadia);
                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return resultado == null ? 0m : Convert.ToDecimal(resultado);
            }
        }
    }
}
