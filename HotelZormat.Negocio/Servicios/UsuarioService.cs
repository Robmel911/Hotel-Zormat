// Cedula:  402-1035106-6
using HotelZormat.Datos;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Sesion;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelZormat.Negocio.Servicios
{
    public class UsuarioService
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();
        private BitacoraService bitacoraService = new BitacoraService();


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
            DataRow fila = usuarioRepository.ObtenerUsuarioPorNombre(nombre);

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
            string rol = usuarioRepository.ObtenerNombreTipo(idTipo);

            return new Usuario
            {
                IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                Nombre = fila["Nombre"].ToString(),
                Rol = rol
            };
        }

       
        // Metodo nuevo: envuelve ValidarLogin, agrega sesion + bitacora.
        // ValidarLogin se queda intacto, sigue siendo reusable sin efectos secundarios.
        public Usuario IniciarSesion(string nombre, string contrasenaPlano)
        {
            Usuario usuario = ValidarLogin(nombre, contrasenaPlano);

            if (usuario == null)
                return null;

            SesionActual.UsuarioActivo = usuario;

            // Fire-and-forget: si bitacora tarda o falla, no bloquea ni tumba el login
            RegistrarLoginEnBitacora(usuario.Nombre);

            return usuario;
        }

        private void RegistrarLoginEnBitacora(string nombreUsuario)
        {
            Task.Run(() =>
            {
                try
                {
                    bitacoraService.Registrar("Inicio de sesion", nombreUsuario + " inicio sesion");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error al registrar bitacora: " + ex.Message);
                }
            });
        }
    }
    
}