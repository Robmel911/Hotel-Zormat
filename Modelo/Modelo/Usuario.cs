// Cedula:  402-1035106-6
using System;

namespace HotelZormat.Modelo
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }          // NUEVO
        public DateTime FechaCreacion { get; set; } // NUEVO
    }
}
