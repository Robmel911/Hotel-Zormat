//Cedula: 402-1035106-6


using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmVerFactura : Form
    {
        private readonly int idReserva;
        private readonly FacturaService facturaService = new FacturaService();

        public FrmVerFactura(int idReserva)
        {
            InitializeComponent();
            this.idReserva = idReserva;
        }

        private void FrmVerFactura_Load(object sender, EventArgs e)
        {
            Factura factura = facturaService.ObtenerPorReserva(idReserva);

            if (factura == null)
            {
                MessageBox.Show("Esta reserva no tiene una factura asociada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            CargarDatos(factura);
            
        }

        private void CargarDatos(Factura factura)
        {
            lblNCF.Text = factura.NumeroNCF;
            lblEstado.Text = factura.Estado.ToString();

            lblHabitacion.Text = factura.Numero.ToString();
            lblHuesped.Text = factura.NombreHuesped;
            lblDocumento.Text = factura.NumeroDocumento;

            lblCheckIn.Text = factura.FechaCheckIn.ToShortDateString();
            lblCheckOut.Text = factura.FechaCheckOut.ToShortDateString();
            lblNoches.Text = factura.CantidadNoches.ToString();

            lblFechaEmision.Text = factura.FechaEmision.ToString("dd/MM/yyyy HH:mm");
            lblFormaPago.Text = factura.FormaPago.ToString();

            lblSubtotal.Text = "RD$" + factura.Subtotal.ToString("N2");
            lblITBIS.Text = "RD$" + factura.ITBIS.ToString("N2");
            lblPropinaLegal.Text = "RD$" + factura.PropinaLegal.ToString("N2");
            lblMontoTotal.Text = "RD$" + factura.MontoTotal.ToString("N2");

            // Si la factura esta Anulada, se lo dejamos visualmente claro
            if (factura.Estado == EstadoFactura.Anulada)
            {
                lblEstado.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factura facto = facturaService.ObtenerPorId(idReserva);
            CargarDatos(facto);
        }
    }
}
