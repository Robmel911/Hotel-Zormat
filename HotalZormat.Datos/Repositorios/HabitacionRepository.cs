// Cedula: 402-1035106-6
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HotelZormat.Datos.Repositorios
{
    public class HabitacionDAL
    {
        private string connString = ConfigurationManager
            .ConnectionStrings["Conexion"].ConnectionString;

        public DataTable ObtenerTodas()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT IdHabitacion, Numero, Tipo, Piso, Capacidad, TarifaBase, Estado
                                  FROM Habitaciones.VW_Habitacion
                                  ORDER BY Numero";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerPorId(int idHabitacion)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT IdHabitacion, Numero, Tipo, Piso, Capacidad, TarifaBase, Estado
                                  FROM Habitaciones.VW_Habitacion
                                  WHERE IdHabitacion = @IdHabitacion";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ObtenerTiposHabitacion()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT IdTipo, Tipo FROM Habitaciones.TipoHabitacion ORDER BY Tipo";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insertar(int numero, int idTipo, int piso, int capacidad, decimal tarifaBase)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO Habitaciones.Habitacion (Numero, IdTipo, Piso, Capacidad, TarifaBase)
                                  VALUES (@Numero, @IdTipo, @Piso, @Capacidad, @TarifaBase)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Numero", numero);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                cmd.Parameters.AddWithValue("@Piso", piso);
                cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                cmd.Parameters.AddWithValue("@TarifaBase", tarifaBase);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarEstado(int idHabitacion, string nuevoEstado)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Habitaciones.Habitacion
                                  SET Estado = @Estado
                                  WHERE IdHabitacion = @IdHabitacion";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Estado", nuevoEstado);
                cmd.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(int idHabitacion, int numero, int idTipo, int piso, int capacidad, decimal tarifaBase)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Habitaciones.Habitacion
                          SET Numero = @Numero, IdTipo = @IdTipo, Piso = @Piso,
                              Capacidad = @Capacidad, TarifaBase = @TarifaBase
                          WHERE IdHabitacion = @IdHabitacion";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Numero", numero);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                cmd.Parameters.AddWithValue("@Piso", piso);
                cmd.Parameters.AddWithValue("@Capacidad", capacidad);
                cmd.Parameters.AddWithValue("@TarifaBase", tarifaBase);
                cmd.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
