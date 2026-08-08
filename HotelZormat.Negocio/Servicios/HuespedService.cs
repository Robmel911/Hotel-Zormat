// Cedula: 402-1035106-6
using System;
using System.Collections.Generic;
using System.Data;
using HotelZormat.Datos;
using HotelZormat.Modelo;

namespace HotelZormat.Negocio.Servicios
{
    public class HuespedService
    {
        private HuespedRepository huespedDatos = new HuespedRepository();
        private BitacoraService bitacoraService = new BitacoraService();

        public List<Huesped> ObtenerTodos()
        {
            DataTable tabla = huespedDatos.ObtenerTodos();
            return MapearLista(tabla);
        }

        public Huesped ObtenerPorId(int idHuesped)
        {
            DataTable tabla = huespedDatos.ObtenerPorId(idHuesped);

            if (tabla.Rows.Count == 0)
                return null;

            return MapearHuesped(tabla.Rows[0]);
        }

        public List<Huesped> Buscar(string texto)
        {
            DataTable tabla = huespedDatos.Buscar(texto);
            return MapearLista(tabla);
        }

        public List<Nacionalidad> ObtenerNacionalidades()
        {
            DataTable tabla = huespedDatos.ObtenerNacionalidades();
            List<Nacionalidad> lista = new List<Nacionalidad>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Nacionalidad
                {
                    IdNacionalidad = Convert.ToInt32(fila["IdNacionalidad"]),
                    Nombre = fila["Nombre"].ToString()
                });
            }

            return lista;
        }

        public void Insertar(string nombre, string apellido, TipoDocumento tipoDocumento, string numeroDocumento,
            int idNacionalidad, string nacionalidadEspecifica, string telefono, string email)
        {
            huespedDatos.Insertar(nombre, apellido, tipoDocumento.ToString(), numeroDocumento,
                idNacionalidad, nacionalidadEspecifica, telefono, email);
            bitacoraService.Registrar("Creo Huesped ", $"El usuario creo al huesped" 
                + nombre + apellido + numeroDocumento);
        }

        public void Actualizar(int idHuesped, string nombre, string apellido, TipoDocumento tipoDocumento, string numeroDocumento,
            int idNacionalidad, string nacionalidadEspecifica, string telefono, string email)
        {
            huespedDatos.Actualizar(idHuesped, nombre, apellido, tipoDocumento.ToString(), numeroDocumento,
                idNacionalidad, nacionalidadEspecifica, telefono, email);
        }

        private List<Huesped> MapearLista(DataTable tabla)
        {
            List<Huesped> huespedes = new List<Huesped>();

            foreach (DataRow fila in tabla.Rows)
            {
                huespedes.Add(MapearHuesped(fila));
            }

            return huespedes;
        }
        public void Eliminar(int idHuesped)
        {
            huespedDatos.Eliminar(idHuesped);
            bitacoraService.Registrar("Eliminacion de huesped ",
                $"El usuario Elimino al Huesped con ID {idHuesped}");
        }
        private Huesped MapearHuesped(DataRow fila)
        {
            return new Huesped
            {
                IdHuesped = Convert.ToInt32(fila["IdHuesped"]),
                Nombre = fila["Nombre"].ToString(),
                Apellido = fila["Apellido"].ToString(),
                TipoDocumento = (TipoDocumento)Enum.Parse(typeof(TipoDocumento), fila["TipoDocumento"].ToString()),
                NumeroDocumento = fila["NumeroDocumento"].ToString(),
                IdNacionalidad = Convert.ToInt32(fila["IdNacionalidad"]),
                NacionalidadEspecifica = fila["NacionalidadEspecifica"] == DBNull.Value ? null : fila["NacionalidadEspecifica"].ToString(),
                NombreNacionalidad = fila["NombreNacionalidad"].ToString(),
                Telefono = fila["Telefono"] == DBNull.Value ? null : fila["Telefono"].ToString(),
                Email = fila["Email"] == DBNull.Value ? null : fila["Email"].ToString()
            };
        }
    }
}