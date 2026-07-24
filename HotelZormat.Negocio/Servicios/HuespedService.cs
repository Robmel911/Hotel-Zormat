// Cedula: [tu cedula aqui]
using HotelZormat.Datos;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Negocio.Modelo;
using System;
using System.Collections.Generic;
using System.Data;

namespace HotelZormat.Negocio.Servicios
{
    public class HuespedService
    {
        private HuespedDAL huespedDAL = new HuespedDAL();

        public List<Huesped> ObtenerTodos()
        {
            DataTable tabla = huespedDAL.ObtenerTodos();
            return MapearLista(tabla);
        }

        public Huesped ObtenerPorId(int idHuesped)
        {
            DataTable tabla = huespedDAL.ObtenerPorId(idHuesped);

            if (tabla.Rows.Count == 0)
                return null;

            return MapearHuesped(tabla.Rows[0]);
        }

        public List<Huesped> Buscar(string texto)
        {
            DataTable tabla = huespedDAL.Buscar(texto);
            return MapearLista(tabla);
        }

        public void Insertar(string nombre, string apellido, TipoDocumento tipoDocumento,
            string numeroDocumento, string nacionalidad, string telefono, string email)
        {
            huespedDAL.Insertar(nombre, apellido, tipoDocumento.ToString(),
                numeroDocumento, nacionalidad, telefono, email);
        }

        public void Actualizar(int idHuesped, string nombre, string apellido, TipoDocumento tipoDocumento,
            string numeroDocumento, string nacionalidad, string telefono, string email)
        {
            huespedDAL.Actualizar(idHuesped, nombre, apellido, tipoDocumento.ToString(),
                numeroDocumento, nacionalidad, telefono, email);
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

        private Huesped MapearHuesped(DataRow fila)
        {
            return new Huesped
            {
                IdHuesped = Convert.ToInt32(fila["IdHuesped"]),
                Nombre = fila["Nombre"].ToString(),
                Apellido = fila["Apellido"].ToString(),
                TipoDocumento = (TipoDocumento)Enum.Parse(typeof(TipoDocumento), fila["TipoDocumento"].ToString()),
                NumeroDocumento = fila["NumeroDocumento"].ToString(),
                Nacionalidad = fila["Nacionalidad"].ToString(),
                Telefono = fila["Telefono"] == DBNull.Value ? null : fila["Telefono"].ToString(),
                Email = fila["Email"] == DBNull.Value ? null : fila["Email"].ToString()
            };
        }
    }
}
