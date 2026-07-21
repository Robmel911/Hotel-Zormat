// Cedula:  402-1035106-6
using HotelZormat.Datos;
using HotelZormat.Datos.Usuarios;
using HotelZormat.Negocio.Modelo;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace HotelZormat.Negocio.Servicios
{
    public class UsuarioService
    {
        private UsuarioDAL dal = new UsuarioDAL();

        public string HashearContrasena(string textoPlano)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textoPlano);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        public Usuario ValidarLogin(string nombre, string contrasenaPlano)
        {
            DataRow fila = dal.ObtenerUsuarioPorNombre(nombre);

            if (fila == null)
                return null;

            bool activo = Convert.ToBoolean(fila["Activo"]);
            if (!activo)
                return null;

            string hashGuardado = fila["Contrasena"].ToString();
            string hashIngresado = HashearContrasena(contrasenaPlano);

            if (hashGuardado != hashIngresado)
                return null;

            int idTipo = Convert.ToInt32(fila["IdTipo"]);
            string rol = dal.ObtenerNombreTipo(idTipo);

            return new Usuario
            {
                IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                Nombre = fila["Nombre"].ToString(),
                Rol = rol
            };
        }
    }
}