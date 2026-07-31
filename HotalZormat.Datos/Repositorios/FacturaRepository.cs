// Cedula: 402-1035106-6
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using HotalZormat.Datos.Conexion;

namespace HotelZormat.Datos
{
    public class FacturaRepository
    {
        private string connectionString =
            ConexionBD.ObtenerConnectionString();

        /// <summary>
        /// Genera la factura. El SP hace todo internamente en una sola transaccion:
        /// calcula el Subtotal (Reserva.MontoTotal + consumo de servicios de todas
        /// sus estadias), inserta la factura, pasa la habitacion a Limpieza,
        /// completa la reserva y cierra la estadia activa. Devuelve el IdFactura.
        /// </summary>
        public int GenerarFactura(int idReserva, int idHabitacion, string formaPago)
        {
            int idFactura;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            using (SqlCommand comando = new SqlCommand("Facturacion.sp_GenerarFactura", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdReserva", idReserva);
                comando.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                comando.Parameters.AddWithValue("@FormaPago", formaPago);

                conexion.Open();
                idFactura = Convert.ToInt32(comando.ExecuteScalar());
            }
            return idFactura;
        }

        /// <summary>
        /// Consulta de SOLO LECTURA que replica el mismo calculo que hace el SP
        /// internamente (Reserva.MontoTotal + consumo de servicios de todas sus
        /// estadias). Se usa unicamente para la vista previa antes de confirmar --
        /// no inserta nada.
        /// </summary>
        public DataTable ObtenerSubtotalParaFacturar(int idReserva)
        {
            DataTable tabla = new DataTable();
            string query = @"
                SELECT
                    r.MontoTotal AS CostoReserva,
                    ISNULL(SUM(vc.TotalServicios), 0) AS ConsumoServicios,
                    r.MontoTotal + ISNULL(SUM(vc.TotalServicios), 0) AS Subtotal
                FROM Reservas.Reserva r
                LEFT JOIN Estadias.Estadia e ON e.IdReserva = r.IdReserva
                LEFT JOIN Estadias.vw_ConsumoPorEstadia vc ON vc.IdEstadia = e.IdEstadia
                WHERE r.IdReserva = @IdReserva
                GROUP BY r.MontoTotal";

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
            string query = "UPDATE Facturacion.Factura SET Estado = 'Anulada' WHERE IdFactura = @IdFactura";
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