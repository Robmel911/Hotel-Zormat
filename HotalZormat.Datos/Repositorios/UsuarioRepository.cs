// Cedula: 402-1035106-6
using HotelZormat.Datos.Conexion;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Datos.Repositorios
{
    public class UsuarioRepository
    {
        // Ajusta "HotelZormatConnectionString" al name= real de tu App.config
        private string connString = ConexionBD.ObtenerConnectionString();

        // Trae los datos del usuario por nombre (para validar login)
        public DataRow ObtenerUsuarioPorNombre(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT IdUsuario, Nombre, Contrasena, IdTipo, Activo 
                                  FROM Usuarios.InfoUsuario 
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
                string query = "SELECT Tipo FROM Usuarios.TipoUsuario WHERE IdTipo = @IdTipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);

                conn.Open();
                object resultado = cmd.ExecuteScalar();
                return resultado?.ToString();
            }
        }
        // ===== CREAR =====

        // Verifica si ya existe un usuario con ese nombre (antes de insertar)
        public bool ExisteUsuario(string nombre, int idExcluir = 0)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT COUNT(1) FROM Usuarios.InfoUsuario 
                          WHERE Nombre = @Nombre AND IdUsuario != @IdExcluir";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@IdExcluir", idExcluir);

                conn.Open();
                int cantidad = (int)cmd.ExecuteScalar();
                return cantidad > 0;
            }
        }

        // Trae un usuario por su Id (para precargar datos en modo Modificar)
        public DataRow ObtenerUsuarioPorId(int idUsuario)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT IdUsuario, Nombre, IdTipo 
                          FROM Usuarios.InfoUsuario 
                          WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla.Rows.Count > 0 ? tabla.Rows[0] : null;
            }
        }

        // Inserta un nuevo usuario
        public void CrearUsuario(string nombre, string hashContrasena, int idTipo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO Usuarios.InfoUsuario (Nombre, Contrasena, IdTipo) 
                          VALUES (@Nombre, @Contrasena, @IdTipo)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Contrasena", hashContrasena);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ===== LEER =====

        // Trae todos los tipos de usuario (para ComboBox)
        public DataTable ObtenerTiposUsuario()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT IdTipo, Tipo FROM Usuarios.TipoUsuario ORDER BY Tipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        // Trae todos los usuarios (para el DataGridView de gestion)
        public DataTable ObtenerTodosUsuarios()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT u.IdUsuario, u.Nombre, t.Tipo, u.Activo, u.FechaCreacion
                          FROM Usuarios.InfoUsuario u
                          INNER JOIN Usuarios.TipoUsuario t ON u.IdTipo = t.IdTipo
                          ORDER BY u.Nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        // ===== ACTUALIZAR =====

        // Actualiza nombre y tipo (rol) de un usuario existente, sin tocar la contrasena
        public void ActualizarUsuario(int idUsuario, string nombre, int idTipo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Usuarios.InfoUsuario 
                          SET Nombre = @Nombre, IdTipo = @IdTipo 
                          WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualiza solo la contrasena (accion separada, mas sensible que editar datos generales)
        public void ActualizarContrasena(int idUsuario, string nuevoHash)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Usuarios.InfoUsuario 
                          SET Contrasena = @Contrasena 
                          WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Contrasena", nuevoHash);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Activa/desactiva un usuario (soft delete -- nunca se borra realmente)
        public void CambiarEstadoUsuario(int idUsuario, bool activo)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Usuarios.InfoUsuario 
                          SET Activo = @Activo 
                          WHERE IdUsuario = @IdUsuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Activo", activo);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
