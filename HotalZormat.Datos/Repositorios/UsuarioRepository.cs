// Cedula: 402-1035106-6
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Datos.Usuarios
{
    public class UsuarioDAL
    {
        // Ajusta "HotelZormatConnectionString" al name= real de tu App.config
        private string connString = ConfigurationManager
            .ConnectionStrings["Conexion"].ConnectionString;

        // Trae los datos del usuario por nombre (para validar login)
        public DataRow ObtenerUsuarioPorNombre(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT IdUsuario, Nombre, Contrasena, IdTipo, Activo 
                                  FROM InfoUsuario 
                                  WHERE Nombre = @Nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                if (tabla.Rows.Count == 0)
                    return null;

                return tabla.Rows[0];
            }
        }

        // Trae el nombre del rol (Tipo) a partir del IdTipo
        public string ObtenerNombreTipo(int idTipo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT Tipo FROM TipoUsuario WHERE IdTipo = @IdTipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);

                conn.Open();
                object resultado = cmd.ExecuteScalar();
                return resultado?.ToString();
            }
        }
    }
}
