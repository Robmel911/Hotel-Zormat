// Cedula: [tu cedula aqui]
using HotelZormat.UI.Formularios;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmGestionHuespedes : Form
    {
        private HuespedService huespedService = new HuespedService();
        private Huesped huespedSeleccionado = null;

        public FrmGestionHuespedes()
        {
            InitializeComponent();
        }

        private void FrmGestionHuespedes_Load(object sender, EventArgs e)
        {
            CargarLista(huespedService.ObtenerTodos());

            string mensajeBusqueda = "Puedes buscar por nombre, apellido o numero de documento";
            tt.SetToolTip(lblBuscar, mensajeBusqueda);
            tt.SetToolTip(txtBuscar, mensajeBusqueda);
            tt.SetToolTip(btnBuscar, mensajeBusqueda);
        }

        private void CargarLista(System.Collections.Generic.List<Huesped> huespedes)
        {
            lstHuespedes.DataSource = null;
            lstHuespedes.DataSource = huespedes;
        }

        private void lstHuespedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            huespedSeleccionado = lstHuespedes.SelectedItem as Huesped;
            btnEditar.Enabled = huespedSeleccionado != null;
            btnEliminar.Enabled = huespedSeleccionado != null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                CargarLista(huespedService.ObtenerTodos());
                return;
            }

            CargarLista(huespedService.Buscar(txtBuscar.Text.Trim()));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCrearHuesped frm = new FrmCrearHuesped();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarLista(huespedService.ObtenerTodos());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (huespedSeleccionado == null)
                return;

            FrmCrearHuesped frm = new FrmCrearHuesped(huespedSeleccionado);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarLista(huespedService.ObtenerTodos());
                huespedSeleccionado = null;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (huespedSeleccionado == null)
                return;

            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que deseas eliminar a " + huespedSeleccionado.NombreCompleto() + "?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                huespedService.Eliminar(huespedSeleccionado.IdHuesped);
                CargarLista(huespedService.ObtenerTodos());
                huespedSeleccionado = null;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No se puede eliminar: el huesped tiene reservas u otros registros asociados.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}