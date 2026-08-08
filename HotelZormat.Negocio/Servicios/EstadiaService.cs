// Cedula 402-1035106-6
using HotelZormat.Datos;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Exepciones;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelZormat.Negocio.Servicios
{
    public class EstadiaService
    {
        private EstadiaRepository estadiaDAL = new EstadiaRepository();
        private EstadiaServicioRepository estadiaServicioDAL = new EstadiaServicioRepository();
        private ServicioRepository servicioDAL = new ServicioRepository();
        private HabitacionRepository habitacionDAL = new HabitacionRepository();

        // ================= ESTADIA =================

        public int CrearEstadia(int idReserva, int idHabitacion, string motivo)
        {
            return estadiaDAL.Insertar(idReserva, idHabitacion, motivo);
        }

        public Estadia ObtenerActivaPorReserva(int idReserva)
        {
            DataTable tabla = estadiaDAL.ObtenerActivaPorReserva(idReserva);
            if (tabla.Rows.Count == 0) return null;
            return MapearEstadia(tabla.Rows[0]);
        }

        public List<Estadia> ObtenerHistorialPorReserva(int idReserva)
        {
            DataTable tabla = estadiaDAL.ObtenerHistorialPorReserva(idReserva);
            List<Estadia> lista = new List<Estadia>();
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(MapearEstadia(fila));
            }
            return lista;
        }

        // Cierra el segmento actual y abre uno nuevo en otra habitacion.
        // Actualiza tambien el estado fisico de ambas habitaciones.
        public int TransferirHabitacion(int idEstadiaActual, int idReserva, int idHabitacionNueva, string motivo)
        {
            string estadoNueva = habitacionDAL.ObtenerEstado(idHabitacionNueva);
            if (estadoNueva != "Disponible")
            {
                throw new ReservaNoDisponibleException(
                    "La habitacion destino no esta disponible (estado actual: " + estadoNueva + ").");
            }

            Estadia estadiaActual = MapearEstadia(estadiaDAL.ObtenerPorId(idEstadiaActual).Rows[0]);

            estadiaDAL.CerrarEstadia(idEstadiaActual);
            habitacionDAL.ActualizarEstado(estadiaActual.IdHabitacion, "Disponible");

            int idNuevaEstadia = estadiaDAL.Insertar(idReserva, idHabitacionNueva, motivo);
            habitacionDAL.ActualizarEstado(idHabitacionNueva, "Ocupada");

            return idNuevaEstadia;
        }

        // Cierra la estadia activa (usado en el check-out final, junto con la reserva)
        public void CerrarEstadia(int idEstadia)
        {
            estadiaDAL.CerrarEstadia(idEstadia);
        }

        // ================= SERVICIOS CONSUMIDOS =================

        public List<Servicio> ObtenerServiciosActivos()
        {
            DataTable tabla = servicioDAL.ObtenerActivos();
            List<Servicio> lista = new List<Servicio>();
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(MapearServicio(fila));
            }
            return lista;
        }

        public List<EstadiaServicio> ObtenerConsumoPorEstadia(int idEstadia)
        {
            DataTable tabla = estadiaServicioDAL.ObtenerPorEstadia(idEstadia);
            List<EstadiaServicio> lista = new List<EstadiaServicio>();
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(MapearEstadiaServicio(fila));
            }
            return lista;
        }

        // Agrega un consumo, tomando el precio actual del catalogo como snapshot
        public int AgregarServicio(int idEstadia, Servicio servicio, int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser mayor a cero.");
            }

            return estadiaServicioDAL.Insertar(idEstadia, servicio.IdServicio, cantidad, servicio.Precio);
        }

        public bool EliminarServicio(int idEstadiaServicio)
        {
            return estadiaServicioDAL.Eliminar(idEstadiaServicio);
        }

        public decimal ObtenerTotalConsumo(int idEstadia)
        {
            return estadiaServicioDAL.ObtenerTotalPorEstadia(idEstadia);
        }
        // EstadiaService.cs — agregar estos dos métodos dentro de la clase

        public List<Estadia> ObtenerTodasActivas()
        {
            DataTable tabla = estadiaDAL.ObtenerTodasActivas();
            List<Estadia> lista = new List<Estadia>();
            foreach (DataRow fila in tabla.Rows)
            {
                Estadia estadia = new Estadia();
                estadia.IdEstadia = Convert.ToInt32(fila["IdEstadia"]);
                estadia.IdReserva = Convert.ToInt32(fila["IdReserva"]);
                estadia.IdHabitacion = Convert.ToInt32(fila["IdHabitacion"]);
                estadia.Numero = Convert.ToInt32(fila["Numero"]);
                estadia.FechaInicio = Convert.ToDateTime(fila["FechaInicio"]);
                estadia.FechaFin = null; // esta lista solo trae activas, siempre null
                estadia.Motivo = fila["Motivo"] == DBNull.Value ? null : fila["Motivo"].ToString();
                lista.Add(estadia);
            }
            return lista;
        }

        public Estadia ObtenerPorId(int idEstadia)
        {
            DataTable tabla = estadiaDAL.ObtenerPorId(idEstadia);
            if (tabla.Rows.Count == 0) return null;
            return MapearEstadia(tabla.Rows[0]);
        }

        // ================= MAPEO =================

        private Estadia MapearEstadia(DataRow fila)
        {
            Estadia estadia = new Estadia();
            estadia.IdEstadia = Convert.ToInt32(fila["IdEstadia"]);
            estadia.IdReserva = Convert.ToInt32(fila["IdReserva"]);
            estadia.IdHabitacion = Convert.ToInt32(fila["IdHabitacion"]);
            estadia.Numero = Convert.ToInt32(fila["Numero"]);
            estadia.FechaInicio = Convert.ToDateTime(fila["FechaInicio"]);
            estadia.FechaFin = fila["FechaFin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["FechaFin"]);
            estadia.Motivo = fila["Motivo"] == DBNull.Value ? null : fila["Motivo"].ToString();
            return estadia;
        }

        private Servicio MapearServicio(DataRow fila)
        {
            Servicio servicio = new Servicio();
            servicio.IdServicio = Convert.ToInt32(fila["IdServicio"]);
            servicio.Nombre = fila["Nombre"].ToString();
            servicio.Precio = Convert.ToDecimal(fila["Precio"]);
            servicio.Activo = Convert.ToBoolean(fila["Activo"]);
            return servicio;
        }

        private EstadiaServicio MapearEstadiaServicio(DataRow fila)
        {
            EstadiaServicio consumo = new EstadiaServicio();
            consumo.IdEstadiaServicio = Convert.ToInt32(fila["IdEstadiaServicio"]);
            consumo.IdEstadia = Convert.ToInt32(fila["IdEstadia"]);
            consumo.IdServicio = Convert.ToInt32(fila["IdServicio"]);
            consumo.NombreServicio = fila["NombreServicio"].ToString();
            consumo.Cantidad = Convert.ToInt32(fila["Cantidad"]);
            consumo.PrecioUnitario = Convert.ToDecimal(fila["PrecioUnitario"]);
            consumo.FechaConsumo = Convert.ToDateTime(fila["FechaConsumo"]);
            return consumo;
        }
        public List<EstadiaHistorial> ObtenerHistorialPorHuesped(int idHuesped)
        {
            DataTable tabla = estadiaDAL.ObtenerHistorialPorHuesped(idHuesped);
            List<EstadiaHistorial> lista = new List<EstadiaHistorial>();

            foreach (DataRow fila in tabla.Rows)
            {
                EstadiaHistorial item = new EstadiaHistorial();
                item.IdEstadia = Convert.ToInt32(fila["IdEstadia"]);
                item.IdReserva = Convert.ToInt32(fila["IdReserva"]);
                item.Numero = Convert.ToInt32(fila["Numero"]);
                item.FechaInicio = Convert.ToDateTime(fila["FechaInicio"]);
                item.FechaFin = fila["FechaFin"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["FechaFin"]);
                item.Motivo = fila["Motivo"] == DBNull.Value ? null : fila["Motivo"].ToString();
                item.TotalServicios = Convert.ToDecimal(fila["TotalServicios"]);
                lista.Add(item);
            }

            return lista;
        }
    }
}
