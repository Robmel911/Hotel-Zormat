// Cedula: 402-1035106-6
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Datos.Repositorios
{
    public class HuespedDAL
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Huespedes.Huesped ORDER BY Apellido, Nombre";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ObtenerPorId(int idHuesped)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Huespedes.Huesped WHERE IdHuesped = @IdHuesped";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdHuesped", idHuesped);

                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        public DataTable Buscar(string texto)
        {
            DataTable tabla = new DataTable();
            string query = @"SELECT * FROM Huespedes.Huesped
                      WHERE Nombre LIKE @Texto
                         OR Apellido LIKE @Texto
                         OR NumeroDocumento LIKE @Texto
                      ORDER BY Apellido, Nombre";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Texto", "%" + texto + "%");

                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }

            return tabla;
        }

        public void Insertar(string nombre, string apellido, string tipoDocumento,
            string numeroDocumento, string nacionalidad, string telefono, string email)
        {
            string query = @"INSERT INTO Huespedes.Huesped
                (Nombre, Apellido, TipoDocumento, NumeroDocumento, Nacionalidad, Telefono, Email)
                VALUES (@Nombre, @Apellido, @TipoDocumento, @NumeroDocumento, @Nacionalidad, @Telefono, @Email)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                comando.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                comando.Parameters.AddWithValue("@Telefono", (object)telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Actualizar(int idHuesped, string nombre, string apellido, string tipoDocumento,
            string numeroDocumento, string nacionalidad, string telefono, string email)
        {
            string query = @"UPDATE Huespedes.Huesped SET
                Nombre = @Nombre,
                Apellido = @Apellido,
                TipoDocumento = @TipoDocumento,
                NumeroDocumento = @NumeroDocumento,
                Nacionalidad = @Nacionalidad,
                Telefono = @Telefono,
                Email = @Email
                WHERE IdHuesped = @IdHuesped";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdHuesped", idHuesped);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                comando.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                comando.Parameters.AddWithValue("@Telefono", (object)telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
