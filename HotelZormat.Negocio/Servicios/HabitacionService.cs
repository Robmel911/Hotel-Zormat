// Cedula: 402-1035106-6
using HotelZormat.Datos.Repositorios;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelZormat.Negocio.Servicios
{
    public class HabitacionService
    {
        private HabitacionRepository habdatos = new HabitacionRepository();

        public List<Habitacion> ObtenerTodas()
        {
            DataTable dt = habdatos.ObtenerTodas();
            return MapearLista(dt);
        }

        public List<Habitacion> ObtenerDisponibles()
        {
            List<Habitacion> todas = ObtenerTodas();
            List<Habitacion> disponibles = new List<Habitacion>();
            foreach (Habitacion h in todas)
            {
                if (h.EstaDisponible())
                    disponibles.Add(h);
            }
            return disponibles;
        }

        public List<TipoHabitacion> ObtenerTiposHabitacion()
        {
            DataTable dt = habdatos.ObtenerTiposHabitacion();
            List<TipoHabitacion> lista = new List<TipoHabitacion>();
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new TipoHabitacion
                {
                    IdTipo = (int)row["IdTipo"],
                    Tipo = row["Tipo"].ToString()
                });
            }
            return lista;
        }

        public void Insertar(int numero, int idTipo, int piso, int capacidad, decimal tarifaBase)
        {
            habdatos.Insertar(numero, idTipo, piso, capacidad, tarifaBase);
        }

        public void Actualizar(int idHabitacion, int numero, int idTipo, int piso, int capacidad, decimal tarifaBase)
        {
            habdatos.Actualizar(idHabitacion, numero, idTipo, piso, capacidad, tarifaBase);
        }

        public void CambiarEstado(int idHabitacion, EstadoHabitacion nuevoEstado)
        {
            string estadoActualTexto = habdatos.ObtenerEstado(idHabitacion);
            EstadoHabitacion estadoActual = (EstadoHabitacion)Enum.Parse(typeof(EstadoHabitacion), estadoActualTexto);

            bool esCambioValido = estadoActual == EstadoHabitacion.Limpieza
                                && nuevoEstado == EstadoHabitacion.Disponible;

            if (!esCambioValido)
            {
                throw new CambioEstadoNoPermitidoException(estadoActual, nuevoEstado);
            }

            habdatos.ActualizarEstado(idHabitacion, nuevoEstado.ToString());
        }

        private List<Habitacion> MapearLista(DataTable dt)
        {
            List<Habitacion> lista = new List<Habitacion>();
            foreach (DataRow row in dt.Rows)
            {
                lista.Add(MapearHabitacion(row));
            }
            return lista;
        }

        private Habitacion MapearHabitacion(DataRow row)
        {
            return new Habitacion
            {
                IdHabitacion = (int)row["IdHabitacion"],
                Numero = (int)row["Numero"],
                Tipo = row["Tipo"].ToString(),
                Piso = (int)row["Piso"],
                Capacidad = (int)row["Capacidad"],
                TarifaBase = (decimal)row["TarifaBase"],
                Estado = (EstadoHabitacion)Enum.Parse(typeof(EstadoHabitacion), row["Estado"].ToString())
            };
        }
        public decimal ObtenerTarifaBase(int idHabitacion)
        {
            return habdatos.ObtenerTarifaBase(idHabitacion);
        }
        public Habitacion ObtenerPorId(int idHabitacion)
        {
            DataTable dt = habdatos.ObtenerPorId(idHabitacion);

            if (dt.Rows.Count == 0)
                return null;

            return MapearHabitacion(dt.Rows[0]);
        }

    }
}
