
namespace HotelZormat.Negocio.Modelo
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Nombre + " - " + Precio.ToString("C2");
        }
    }
}
