using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalZormat.Datos.Repositorios
{
        public class ReservaDal 
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Reservas.Reserva ";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        public DataTable ObtenerVistaSimple()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Reservas.vw_ReservaSimple ";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }

            return tabla;
        }


        public void Insertar(int IdHabitacion, int IdHuesped, DateTime FechaCheckIn, DateTime FechaCheckOut
            ,string Estado, string Temporada, decimal TarifaAplicada, decimal MontoTotal)
        {
            DataTable tabla = new DataTable();
            string query = "INSERT INTO Reservas.Reserva " +
                "(IdHabitacion, IdHuesped, FechaCheckIn, FechaCheckOut, Estado, Temporada," +
                " TarifaAplicada, MontoTotal) VALUES " +
                "(@IdHabitacion, @IdHuesped, @FechaCheckIn, @FechaCheckOut," +
                " @Estado, @Temporada, @TarifaAplicada, @MontoTotal)";


            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdHabitacion", IdHabitacion);
                comando.Parameters.AddWithValue("@IdHuesped", IdHuesped);
                comando.Parameters.AddWithValue("@FechaCheckIn", FechaCheckIn);
                comando.Parameters.AddWithValue("@FechaCheckOut", FechaCheckOut);
                comando.Parameters.AddWithValue("@Estado", Estado);
                comando.Parameters.AddWithValue("@Temporada", Temporada);
                comando.Parameters.AddWithValue("@TarifaAplicada", TarifaAplicada);
                comando.Parameters.AddWithValue("@MontoTotal", MontoTotal);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
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
    }
}
