// Cedula: 402-1035106-6
using System;

namespace HotelZormat.Modelo
{
    public class Bitacora
    {
        public int IdBitacora { get; set; }
        public string Usuario { get; set; }
        public string Rol { get; set; }
        public string Accion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
