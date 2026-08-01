//
using HotelZormat.Datos.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;


namespace HotelZormat.Datos
{
    public class ServicioRepository
    {
        private string connectionString = ConexionBD.ObtenerConnectionString();

        // Solo servicios activos, para poblar combos/listas de seleccion
        public DataTable ObtenerActivos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Estadias.Servicio WHERE Activo = 1 ORDER BY Nombre";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        // Catalogo completo (activos e inactivos), para el mantenimiento del catalogo
        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Estadias.Servicio ORDER BY Nombre";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        public int Insertar(string nombre, decimal precio)
        {
            string query = @"INSERT INTO Estadias.Servicio (Nombre, Precio)
                              VALUES (@Nombre, @Precio);
                              SELECT SCOPE_IDENTITY();";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Precio", precio);

                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return Convert.ToInt32(resultado);
            }
        }

        public bool Actualizar(int idServicio, string nombre, decimal precio)
        {
            string query = @"UPDATE Estadias.Servicio
                              SET Nombre = @Nombre, Precio = @Precio
                              WHERE IdServicio = @IdServicio";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Precio", precio);
                comando.Parameters.AddWithValue("@IdServicio", idServicio);

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        // Borrado logico: no se elimina, se desactiva (mismo patron que el resto del proyecto)
        public bool CambiarActivo(int idServicio, bool activo)
        {
            string query = "UPDATE Estadias.Servicio SET Activo = @Activo WHERE IdServicio = @IdServicio";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@Activo", activo);
                comando.Parameters.AddWithValue("@IdServicio", idServicio);

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }
    }
}
