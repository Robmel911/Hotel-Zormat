// Celula 402-1035106-6


using System;
using System.Linq;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmGestionFacturas : Form
    {
        private readonly FacturaService facturaService = new FacturaService();

        public FrmGestionFacturas()
        {
            InitializeComponent();
        }

        private void FrmGestionFacturas_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            var facturas = facturaService.ObtenerTodos();
            dgvFacturas.DataSource = facturas;

            // IdFactura e IdReserva quedan en el DataSource pero ocultos visualmente --
            // se necesitan para las acciones (btnVerDetalle/btnAnular), mismo criterio
            // que las columnas de ID ocultas en dgvReservas.
            if (dgvFacturas.Columns["IdFactura"] != null)
                dgvFacturas.Columns["IdFactura"].Visible = false;
            if (dgvFacturas.Columns["IdReserva"] != null)
                dgvFacturas.Columns["IdReserva"].Visible = false;

            // Encabezados legibles para las columnas que si se muestran
            if (dgvFacturas.Columns["NumeroNCF"] != null)
                dgvFacturas.Columns["NumeroNCF"].HeaderText = "NCF";
            if (dgvFacturas.Columns["Numero"] != null)
                dgvFacturas.Columns["Numero"].HeaderText = "Habitación";
            if (dgvFacturas.Columns["NombreHuesped"] != null)
                dgvFacturas.Columns["NombreHuesped"].HeaderText = "Huésped";
            if (dgvFacturas.Columns["FechaEmision"] != null)
                dgvFacturas.Columns["FechaEmision"].HeaderText = "Fecha Emisión";
            if (dgvFacturas.Columns["MontoTotal"] != null)
                dgvFacturas.Columns["MontoTotal"].HeaderText = "Monto Total";
            if (dgvFacturas.Columns["FormaPago"] != null)
                dgvFacturas.Columns["FormaPago"].HeaderText = "Forma de Pago";

            ActualizarBotones();
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarBotones();
        }

        private void ActualizarBotones()
        {
            if (dgvFacturas.SelectedRows.Count == 0)
            {
                btnVerDetalle.Enabled = false;
                btnAnular.Enabled = false;
                return;
            }

            var factura = (Factura)dgvFacturas.SelectedRows[0].DataBoundItem;

            btnVerDetalle.Enabled = true;
            // Solo se puede anular una factura que este Emitida -- mismo criterio que
            // habilitar/deshabilitar botones segun Estado en FrmGestionReservas.
            btnAnular.Enabled = factura.Estado == EstadoFactura.Emitida;
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0) return;

            var factura = (Factura)dgvFacturas.SelectedRows[0].DataBoundItem;
            var frmVer = new FrmVerFactura(factura.IdReserva);
            frmVer.ShowDialog();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count == 0) return;

            var factura = (Factura)dgvFacturas.SelectedRows[0].DataBoundItem;

            var confirmacion = MessageBox.Show(
                $"¿Anular la factura {factura.NumeroNCF}? Esta acción no libera la habitación ni revierte el check-out.",
                "Confirmar anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            facturaService.Anular(factura.IdFactura);
            CargarGrid(); // refresca para reflejar el nuevo Estado
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
