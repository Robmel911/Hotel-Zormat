// Cedula: 402-1035106-6
using System;
using System.Data;
using System.Collections.Generic;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Sesion;

namespace HotelZormat.Negocio.Servicios
{
    public class BitacoraService
    {
        private BitacoraRepository bitacoraRepository = new BitacoraRepository();

        // Registra una accion usando el usuario actualmente logueado
        public void Registrar(string accion, string descripcion)
        {
            if (!SesionActual.HayUsuarioLogueado())
                return;

            int idUsuario = SesionActual.UsuarioActivo.IdUsuario;
            bitacoraRepository.RegistrarAccion(idUsuario, accion, descripcion);
        }

        public List<Bitacora> ObtenerBitacora()
        {
            DataTable tabla = bitacoraRepository.ObtenerBitacora();
            return MapearBitacora(tabla);
        }

        public List<Bitacora> ObtenerBitacoraPorFecha(DateTime desde, DateTime hasta)
        {
            DataTable tabla = bitacoraRepository.ObtenerBitacoraPorFecha(desde, hasta);
            return MapearBitacora(tabla);
        }

       
        private List<Bitacora> MapearBitacora(DataTable tabla)
        {
            List<Bitacora> lista = new List<Bitacora>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Bitacora
                {
                    IdBitacora = Convert.ToInt32(fila["IdBitacora"]),
                    Usuario = fila["Usuario"].ToString(),
                    Rol = fila["Rol"].ToString(),
                    Accion = fila["Accion"].ToString(),
                    Fecha = Convert.ToDateTime(fila["Fecha"]),
                    Descripcion = fila["Descripcion"] == DBNull.Value ? "" : fila["Descripcion"].ToString(),
                });
            }

            return lista;
        }
    }
}
