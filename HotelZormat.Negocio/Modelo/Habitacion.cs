namespace HotelZormat.Negocio.Modelo
{
    public class Habitacion
    {
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int Piso { get; set; }
        public int Capacidad { get; set; }
        public decimal TarifaBase { get; set; }
        public EstadoHabitacion Estado { get; set; }

        public bool EstaDisponible()
        {
            return Estado == EstadoHabitacion.Disponible;
        }
    }
}
