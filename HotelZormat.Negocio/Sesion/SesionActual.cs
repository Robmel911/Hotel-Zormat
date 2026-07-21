// Cedula: 402-1035106-6
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.Negocio.Sesion
{
    // Guarda el usuario logueado mientras la aplicacion esta abierta.
    // Vive en Negocio (no en UI) para que servicios como BitacoraService
    // puedan consultar quien esta logueado sin que Negocio dependa de UI.
    public static class SesionActual
    {
        public static Usuario UsuarioActivo { get; set; }

        // Util para BitacoraService mas adelante:
        // registrar acciones sabiendo quien las hizo
        public static bool HayUsuarioLogueado()
        {
            return UsuarioActivo != null;
        }

        public static void CerrarSesion()
        {
            UsuarioActivo = null;
        }
    }
}
