// Cedula: 402-1035106-6
using HotelZormat.Datos.Conexion;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Datos
{
    public class HuespedRepository
    {
        private string connectionString =
            ConexionBD.ObtenerConnectionString();

        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            string query = @"SELECT h.*, n.Nombre AS NombreNacionalidad
                              FROM Huespedes.Huesped h
                              INNER JOIN Huespedes.Nacionalidad n ON h.IdNacionalidad = n.IdNacionalidad
                              ORDER BY h.Apellido, h.Nombre";

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
            string query = @"SELECT h.*, n.Nombre AS NombreNacionalidad
                              FROM Huespedes.Huesped h
                              INNER JOIN Huespedes.Nacionalidad n ON h.IdNacionalidad = n.IdNacionalidad
                              WHERE h.IdHuesped = @IdHuesped";

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
            string query = @"SELECT h.*, n.Nombre AS NombreNacionalidad
                              FROM Huespedes.Huesped h
                              INNER JOIN Huespedes.Nacionalidad n ON h.IdNacionalidad = n.IdNacionalidad
                              WHERE h.Nombre LIKE @Texto
                                 OR h.Apellido LIKE @Texto
                                 OR h.NumeroDocumento LIKE @Texto
                                 OR n.Nombre LIKE @Texto
                                 OR h.NacionalidadEspecifica LIKE @Texto
                              ORDER BY h.Apellido, h.Nombre";

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

        public void Insertar(string nombre, string apellido, string tipoDocumento, string numeroDocumento,
            int idNacionalidad, string nacionalidadEspecifica, string telefono, string email)
        {
            string query = @"INSERT INTO Huespedes.Huesped
                (Nombre, Apellido, TipoDocumento, NumeroDocumento, IdNacionalidad, NacionalidadEspecifica, Telefono, Email)
                VALUES (@Nombre, @Apellido, @TipoDocumento, @NumeroDocumento, @IdNacionalidad, @NacionalidadEspecifica, @Telefono, @Email)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                comando.Parameters.AddWithValue("@NumeroDocumento", numeroDocumento);
                comando.Parameters.AddWithValue("@IdNacionalidad", idNacionalidad);
                comando.Parameters.AddWithValue("@NacionalidadEspecifica", (object)nacionalidadEspecifica ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Telefono", (object)telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void Actualizar(int idHuesped, string nombre, string apellido, string tipoDocumento, string numeroDocumento,
            int idNacionalidad, string nacionalidadEspecifica, string telefono, string email)
        {
            string query = @"UPDATE Huespedes.Huesped SET
                Nombre = @Nombre,
                Apellido = @Apellido,
                TipoDocumento = @TipoDocumento,
                NumeroDocumento = @NumeroDocumento,
                IdNacionalidad = @IdNacionalidad,
                NacionalidadEspecifica = @NacionalidadEspecifica,
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
                comando.Parameters.AddWithValue("@IdNacionalidad", idNacionalidad);
                comando.Parameters.AddWithValue("@NacionalidadEspecifica", (object)nacionalidadEspecifica ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Telefono", (object)telefono ?? DBNull.Value);
                comando.Parameters.AddWithValue("@Email", (object)email ?? DBNull.Value);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerNacionalidades()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Huespedes.Nacionalidad ORDER BY IdNacionalidad";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }
        public void Eliminar(int idHuesped)
        {
            string query = "DELETE FROM Huespedes.Huesped WHERE IdHuesped = @IdHuesped";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdHuesped", idHuesped);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
