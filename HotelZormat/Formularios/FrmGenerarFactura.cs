// Cedula 402-1035106-6

using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Excepciones;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmGenerarFactura : Form
    {
        private readonly int idReserva;
        private readonly int idHabitacion;
        private readonly decimal subtotal;
        

        private readonly FacturaService facturaService = new FacturaService();

        // Recibe todo ya resuelto desde FrmGestionReservas -- este form no busca nada por su cuenta.
        public FrmGenerarFactura(int idReserva, int idHabitacion, decimal subtotal,
            string numeroHabitacion, string nombreHuesped, DateTime fechaCheckIn,
            DateTime fechaCheckOut, int cantidadNoches)
        {
            InitializeComponent();

            this.idReserva = idReserva;
            this.idHabitacion = idHabitacion;
            this.subtotal = subtotal;
           

            lblHabitacion.Text = numeroHabitacion;
            lblHuesped.Text = nombreHuesped;
            lblCheckIn.Text = fechaCheckIn.ToShortDateString();
            lblCheckOut.Text = fechaCheckOut.ToShortDateString();
            lblNoches.Text = cantidadNoches.ToString();
            lblSubtotal.Text = "RD$" + subtotal.ToString("N2");
        }

        private void FrmGenerarFactura_Load(object sender, EventArgs e)
        {
            // Enum -> ComboBox, mismo criterio que cmbTemporada en FrmCrearReserva
            cmbFormaPago.DataSource = Enum.GetValues(typeof(FormaPago));
            ActualizarDesglose();
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            // FormaPago no afecta el calculo, pero se recalcula igual por consistencia
            // con el patron de recalculo en tiempo real de FrmCrearReserva.
            ActualizarDesglose();
        }

        private void ActualizarDesglose()
        {
            decimal itbis, propinaLegal, montoTotal;
            facturaService.CalcularDesglose(subtotal, out itbis, out propinaLegal, out montoTotal);

            lblITBIS.Text = "RD$" + itbis.ToString("N2");
            lblPropinaLegal.Text = "RD$" + propinaLegal.ToString("N2");
            lblMontoTotal.Text = "RD$" + montoTotal.ToString("N2");
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
                facturaService.GenerarFactura(idReserva, idHabitacion, subtotal, formaPago);

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
