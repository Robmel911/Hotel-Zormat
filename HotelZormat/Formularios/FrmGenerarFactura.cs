// Cedula 402-1035106-6

using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Excepciones;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmGenerarFactura : Form
    {
        private readonly int idReserva;
        private readonly int idHabitacion;
        private readonly int idEstadia;
        private readonly FacturaService facturaService = new FacturaService();

        public FrmGenerarFactura(int idReserva, int idHabitacion, int idEstadia, string numeroHabitacion,
            string nombreHuesped, DateTime fechaCheckIn, DateTime fechaCheckOut, int cantidadNoches)
        {
            InitializeComponent();

            this.idReserva = idReserva;
            this.idHabitacion = idHabitacion;
            this.idEstadia = idEstadia;

            lblHabitacion.Text = numeroHabitacion;
            lblHuesped.Text = nombreHuesped;
            lblCheckIn.Text = fechaCheckIn.ToShortDateString();
            lblCheckOut.Text = fechaCheckOut.ToShortDateString();
            lblNoches.Text = cantidadNoches.ToString();
        }

        private void FrmGenerarFactura_Load(object sender, EventArgs e)
        {
            cmbFormaPago.DataSource = Enum.GetValues(typeof(FormaPago));
            CargarDesglose();
        }

        private void CargarDesglose()
        {
            var desglose = facturaService.ObtenerDesglosePrevio(idReserva);

            lblCostoReserva.Text = "RD$" + desglose.CostoReserva.ToString("N2");
            lblConsumoServicios.Text = "RD$" + desglose.ConsumoServicios.ToString("N2");
            lblSubtotal.Text = "RD$" + desglose.Subtotal.ToString("N2");
            lblITBIS.Text = "RD$" + desglose.ITBIS.ToString("N2");
            lblPropinaLegal.Text = "RD$" + desglose.PropinaLegal.ToString("N2");
            lblMontoTotal.Text = "RD$" + desglose.MontoTotal.ToString("N2");
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            var frmServicio = new FrmAgregarServicio(idEstadia);
            frmServicio.ShowDialog();

            // Se recalcula al volver, sin importar si se agrego algo o no --
            // mas simple y seguro que tratar de rastrear si hubo cambios.
            CargarDesglose();
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FormaPago no afecta el calculo, pero se recalcula igual por consistencia
            // con el patron de recalculo en tiempo real de FrmCrearReserva.
            CargarDesglose();
        }

       

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (cmbFormaPago.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una forma de pago.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormaPago formaPago = (FormaPago)cmbFormaPago.SelectedItem;

            btnGenerarFactura.Enabled = false; // evita doble clic mientras se procesa
            try
            {
                facturaService.GenerarFactura(idReserva, idHabitacion, formaPago);

                this.DialogResult = DialogResult.OK; // FrmGestionReservas sabe que debe refrescar el grid
                this.Close();

                // Se muestra la factura recien generada -- reutiliza FrmVerFactura tal cual,
                // este form no necesita saber pintar NCF/desglose, ya existe quien lo hace.
                var frmVer = new FrmVerFactura(idReserva);
                frmVer.ShowDialog();
            }
            catch (FacturaNoGeneradaException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo generar la factura",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGenerarFactura.Enabled = true; // se puede reintentar sin perder el contexto
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
