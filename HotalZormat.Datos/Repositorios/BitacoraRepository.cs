// Cedula: 402-1035106-6
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using HotelZormat.Datos.Conexion;

namespace HotelZormat.Datos.Repositorios
{
    public class BitacoraRepository
    {
        private string connString = ConexionBD.ObtenerConnectionString();

        // Inserta un nuevo registro de accion en la bitacora
        public void RegistrarAccion(int idUsuario, string accion, string descripcion)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
               
                string query = @"INSERT INTO Auditoria.Bitacora (IdUsuario, Accion, Descripcion) 
                  VALUES (@IdUsuario, @Accion, @Descripcion)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@Accion", accion);
                cmd.Parameters.AddWithValue("@Descripcion", (object)descripcion ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Trae todos los registros de la bitacora como DataTable (datos crudos)
        // NOTA: no conoce la clase Bitacora -- ese mapeo lo hace la capa Negocio
        public DataTable ObtenerBitacora()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT IdBitacora, Usuario, Rol, Accion, Descripcion, Fecha 
                  FROM Auditoria.VW_Bitacora 
                  ORDER BY Fecha DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }

        // Filtra bitacora por rango de fechas, tambien como DataTable
        public DataTable ObtenerBitacoraPorFecha(DateTime desde, DateTime hasta)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT IdBitacora, Usuario, Rol, Accion, Descripcion, Fecha 
                                  FROM Auditoria.VW_Bitacora 
                                  WHERE Fecha BETWEEN @Desde AND @Hasta
                                  ORDER BY Fecha DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Desde", desde);
                cmd.Parameters.AddWithValue("@Hasta", hasta);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
    }
}
