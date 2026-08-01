
// Cedula: 402-1035106-6
namespace HotelZormat.Modelo
{
    public class Huesped
    {
        public const int ID_NACIONALIDAD_OTROS = 22;

        public int IdHuesped { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdNacionalidad { get; set; }
        public string NacionalidadEspecifica { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // Nombre que viene del catalogo via JOIN (llenado por el Service al mapear)
        public string NombreNacionalidad { get; set; }

        public string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }

        // Texto real a mostrar: si es "Otros", usa lo que escribio el usuario;
        // si no, usa el nombre que vino del catalogo
        public string NacionalidadMostrar()
        {
            return IdNacionalidad == ID_NACIONALIDAD_OTROS
                ? NacionalidadEspecifica
                : NombreNacionalidad;
        }

        public override string ToString()
        {
            return NombreCompleto() + " - " + NumeroDocumento;
        }
    }
}
