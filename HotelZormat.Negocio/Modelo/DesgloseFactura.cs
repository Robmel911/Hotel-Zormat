//Cedula 402-1035106-6
namespace HotelZormat.Negocio.Modelo
{
    public class DesgloseFactura
    {
        public decimal CostoReserva { get; set; }
        public decimal ConsumoServicios { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ITBIS { get; set; }
        public decimal PropinaLegal { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
