// Cedula: 402-1035106-6
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace HotelZormat.Datos
{
    public class FacturaDAL
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

        /// <summary>
        /// Genera la factura y, en la misma transaccion (dentro del SP),
        /// libera la habitacion y marca la reserva como Completada.
        /// Devuelve el IdFactura generado.
        /// </summary>
        public int GenerarFactura(int idReserva, int idHabitacion, decimal subtotal, string FormaPago)
        {
            int idFactura;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("Facturacion.sp_GenerarFactura", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdReserva", idReserva);
                comando.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                comando.Parameters.AddWithValue("@Subtotal", subtotal);
                comando.Parameters.AddWithValue("@FormaPago", FormaPago);

                conexion.Open();
                idFactura = Convert.ToInt32(comando.ExecuteScalar()); 
                // el SP hace SELECT SCOPE_IDENTITY() al final
            }
            return idFactura;
        }

        /// <summary>
        /// Trae todas las facturas (para el grid de FrmGestionFacturas).
        /// </summary>
        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Facturacion.vw_FacturaDetalle ORDER BY FechaEmision DESC";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        /// <summary>
        /// Trae una factura puntual por su Id (para mostrar el detalle completo en pantalla).
        /// </summary>
        public DataTable ObtenerPorId(int idFactura)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Facturacion.vw_FacturaDetalle WHERE IdFactura = @IdFactura";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                comando.Parameters.AddWithValue("@IdFactura", idFactura);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        /// <summary>
        /// Trae la factura asociada a una reserva (0 o 1 fila, por la restriccion 1 a 1).
        /// Es el metodo que usa ReservaService.TieneFacturaAsociada() para dejar de ser un placeholder.
        /// </summary>
        public DataTable ObtenerPorReserva(int idReserva)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Facturacion.vw_FacturaDetalle WHERE IdReserva = @IdReserva";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                comando.Parameters.AddWithValue("@IdReserva", idReserva);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        /// <summary>
        /// Existe(...) simple para el chequeo de disponibilidad, mas barato que traer
        /// toda la fila cuando el Service solo necesita saber si existe o no.
        /// </summary>
        public bool ExisteFacturaPorReserva(int idReserva)
        {
            string query = "SELECT 1 FROM Facturacion.Factura WHERE IdReserva = @IdReserva";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdReserva", idReserva);
                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return resultado != null;
            }
        }

        /// <summary>
        /// Borrado logico: pasa Estado a 'Anulada'. No hay Eliminar() fisico,
        /// mismo criterio que Reservas.
        /// </summary>
        public void Anular(int idFactura)
        {
            string query =
                "UPDATE Facturacion.Factura SET Estado = 'Anulada' WHERE IdFactura = @IdFactura";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@IdFactura", idFactura);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
