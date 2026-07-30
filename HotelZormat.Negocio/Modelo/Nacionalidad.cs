// Cedula: 402-1035106-6
namespace HotelZormat.Negocio.Modelo
{
    public class Nacionalidad
    {
        public int IdNacionalidad { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
