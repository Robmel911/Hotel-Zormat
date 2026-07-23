// Cedula: 402-1035106-6
using System;
using System.Collections.Generic;
using System.Data;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class HabitacionService
    {
        private HabitacionDAL dal = new HabitacionDAL();

        public List<Habitacion> ObtenerTodas()
        {
            DataTable dt = dal.ObtenerTodas();
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
            DataTable dt = dal.ObtenerTiposHabitacion();
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
            dal.Insertar(numero, idTipo, piso, capacidad, tarifaBase);
        }

        public void Actualizar(int idHabitacion, int numero, int idTipo, int piso, int capacidad, decimal tarifaBase)
        {
            dal.Actualizar(idHabitacion, numero, idTipo, piso, capacidad, tarifaBase);
        }

        public void CambiarEstado(int idHabitacion, EstadoHabitacion nuevoEstado)
        {
            dal.ActualizarEstado(idHabitacion, nuevoEstado.ToString());
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
    }
}
