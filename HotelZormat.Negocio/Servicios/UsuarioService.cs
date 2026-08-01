// Cedula:  402-1035106-6
using HotelZormat.Datos;
using HotelZormat.Datos.Repositorios;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Sesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        // ===== CREAR =====

        public string CrearUsuario(string nombre, string contrasenaPlano, int idTipo)
        {
            nombre = nombre.Trim();

            if (string.IsNullOrEmpty(nombre))
                return "El nombre de usuario es obligatorio.";

            if (string.IsNullOrEmpty(contrasenaPlano) || contrasenaPlano.Length < 6)
                return "La contrasena debe tener al menos 6 caracteres.";

            if (usuarioRepository.ExisteUsuario(nombre))
                return "Ya existe un usuario con ese nombre.";

            string hash = HashearContrasena(contrasenaPlano);
            usuarioRepository.CrearUsuario(nombre, hash, idTipo);

            return null; // sin errores
        }

        // ===== LEER =====

        public List<TipoUsuario> ObtenerTiposUsuario()
        {
            DataTable tabla = usuarioRepository.ObtenerTiposUsuario();
            List<TipoUsuario> lista = new List<TipoUsuario>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new TipoUsuario
                {
                    IdTipo = Convert.ToInt32(fila["IdTipo"]),
                    Tipo = fila["Tipo"].ToString()
                });
            }

            return lista;
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            DataTable tabla = usuarioRepository.ObtenerTodosUsuarios();
            List<Usuario> lista = new List<Usuario>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Usuario
                {
                    IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                    Nombre = fila["Nombre"].ToString(),
                    Rol = fila["Tipo"].ToString(),
                    Activo = Convert.ToBoolean(fila["Activo"]),
                    FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"])
                });
            }

            return lista;
        }

        // ===== ACTUALIZAR =====

        public string ActualizarUsuario(int idUsuario, string nombre, int idTipo)
        {
            nombre = nombre.Trim();

            if (string.IsNullOrEmpty(nombre))
                return "El nombre de usuario es obligatorio.";

            if (usuarioRepository.ExisteUsuario(nombre, idUsuario)) // ahora se excluye a si mismo
                return "Ya existe otro usuario con ese nombre.";

            usuarioRepository.ActualizarUsuario(idUsuario, nombre, idTipo);
            return null;
        }

        public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            DataRow fila = usuarioRepository.ObtenerUsuarioPorId(idUsuario);

            if (fila == null) return null;

            return new Usuario
            {
                IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                Nombre = fila["Nombre"].ToString(),
                Rol = null // no lo necesitamos aqui, se resuelve via IdTipo en el ComboBox
            };
        }

        // Devuelve tambien el IdTipo actual, util para preseleccionar el ComboBox
        public int ObtenerIdTipoDeUsuario(int idUsuario)
        {
            DataRow fila = usuarioRepository.ObtenerUsuarioPorId(idUsuario);
            return fila != null ? Convert.ToInt32(fila["IdTipo"]) : 0;
        }

        public string ActualizarContrasena(int idUsuario, string nuevaContrasenaPlano)
        {
            if (string.IsNullOrEmpty(nuevaContrasenaPlano) || nuevaContrasenaPlano.Length < 6)
                return "La contrasena debe tener al menos 6 caracteres.";

            string hash = HashearContrasena(nuevaContrasenaPlano);
            usuarioRepository.ActualizarContrasena(idUsuario, hash);
            return null;
        }

        public void CambiarEstadoUsuario(int idUsuario, bool activo)
        {
            usuarioRepository.CambiarEstadoUsuario(idUsuario, activo);
        }
    }
    
}