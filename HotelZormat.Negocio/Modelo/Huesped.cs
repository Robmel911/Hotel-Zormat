using System;
using System.Collections.Generic;
using System.Linq;
// Cedula: 402-1035106-6
namespace HotelZormat.Negocio.Modelo
{
    public class Huesped
    {
        public int IdHuesped { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nacionalidad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }
        public override string ToString()
        {
            return NombreCompleto() + " - " + NumeroDocumento;
        }
    }
}
