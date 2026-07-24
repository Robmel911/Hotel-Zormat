// Cedula: 402-1035106-6
using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

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
            string mensajeBusqueda = "Puedes buscar por nombre, apellido o numero de documento";
            tt.SetToolTip(lblBuscar, mensajeBusqueda);
            tt.SetToolTip(txtBuscar, mensajeBusqueda);
            tt.SetToolTip(btnBuscar, mensajeBusqueda);

            cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            CargarLista(huespedService.ObtenerTodos());
        }

        private void CargarLista(System.Collections.Generic.List<Huesped> huespedes)
        {
            lstHuespedes.DataSource = null;
            lstHuespedes.DataSource = huespedes;
        }

        private void lstHuespedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            huespedSeleccionado = lstHuespedes.SelectedItem as Huesped;

            if (huespedSeleccionado == null)
            {
                btnModificar.Enabled = false;
                return;
            }

            txtNombre.Text = huespedSeleccionado.Nombre;
            txtApellido.Text = huespedSeleccionado.Apellido;
            cboTipoDocumento.SelectedItem = huespedSeleccionado.TipoDocumento;
            txtNumeroDocumento.Text = huespedSeleccionado.NumeroDocumento;
            txtNacionalidad.Text = huespedSeleccionado.Nacionalidad;
            txtTelefono.Text = huespedSeleccionado.Telefono;
            txtEmail.Text = huespedSeleccionado.Email;

            btnModificar.Enabled = true;
        }

        private bool ValidarCampos()
        {
            ep.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ep.SetError(txtNombre, "El nombre es obligatorio");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                ep.SetError(txtApellido, "El apellido es obligatorio");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                ep.SetError(txtNumeroDocumento, "El numero de documento es obligatorio");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                ep.SetError(txtNacionalidad, "La nacionalidad es obligatoria");
                valido = false;
            }

            return valido;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            TipoDocumento tipoDocumento = (TipoDocumento)cboTipoDocumento.SelectedItem;

            huespedService.Insertar(
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                tipoDocumento,
                txtNumeroDocumento.Text.Trim(),
                txtNacionalidad.Text.Trim(),
                string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim()
            );

            MessageBox.Show("Huesped agregado correctamente.", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarLista(huespedService.ObtenerTodos());
            btnLimpiar_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (huespedSeleccionado == null)
                return;

            if (!ValidarCampos())
                return;

            TipoDocumento tipoDocumento = (TipoDocumento)cboTipoDocumento.SelectedItem;

            huespedService.Actualizar(
                huespedSeleccionado.IdHuesped,
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                tipoDocumento,
                txtNumeroDocumento.Text.Trim(),
                txtNacionalidad.Text.Trim(),
                string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim()
            );

            MessageBox.Show("Huesped modificado correctamente.", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarLista(huespedService.ObtenerTodos());
            btnLimpiar_Click(sender, e);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNumeroDocumento.Clear();
            txtNacionalidad.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtBuscar.Clear();
            cboTipoDocumento.SelectedIndex = -1;
            ep.Clear();

            lstHuespedes.ClearSelected();
            huespedSeleccionado = null;
            btnModificar.Enabled = false;
        }
    }
}
