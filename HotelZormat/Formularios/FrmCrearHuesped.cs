// Cedula: 402-1035106-6
using System;
using System.Windows.Forms;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Excepciones;
using HotelZormat.Negocio.Validaciones;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmCrearHuesped : Form
    {
        private HuespedService huespedService = new HuespedService();
        private Huesped huespedActual = null; // null = modo Nuevo

        // Constructor modo NUEVO
        public FrmCrearHuesped()
        {
            InitializeComponent();
        }

        // Constructor modo EDITAR
        public FrmCrearHuesped(Huesped huesped)
        {
            InitializeComponent();
            huespedActual = huesped;
        }

        private void FrmCrearHuesped_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));

            cboNacionalidad.DisplayMember = "Nombre";
            cboNacionalidad.ValueMember = "IdNacionalidad";
            cboNacionalidad.DataSource = huespedService.ObtenerNacionalidades();
            cboTipoDocumento.SelectedIndex = -1;
            if (huespedActual == null)
            {
                this.Text = "Nuevo huesped";
            }
            else
            {
                this.Text = "Editar huesped";
                CargarDatosEnFormulario();
            }
        }

        private void CargarDatosEnFormulario()
        {
            txtNombre.Text = huespedActual.Nombre;
            txtApellido.Text = huespedActual.Apellido;
            cboTipoDocumento.SelectedItem = huespedActual.TipoDocumento;
            txtNumeroDocumento.Text = huespedActual.NumeroDocumento;
            cboNacionalidad.SelectedValue = huespedActual.IdNacionalidad;
            txtNacionalidadEspecifica.Text = huespedActual.NacionalidadEspecifica;
            txtTelefono.Text = huespedActual.Telefono;
            txtEmail.Text = huespedActual.Email;
        }

        private void cboNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cboNacionalidad.SelectedValue is int idNacionalidad))
                return;

            bool esOtros = idNacionalidad == Huesped.ID_NACIONALIDAD_OTROS;
            txtNacionalidadEspecifica.Enabled = esOtros;

            if (!esOtros)
                txtNacionalidadEspecifica.Clear();
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
            else
            {
                try
                {
                    Validador.ValidarNombre(txtNombre.Text.Trim(), "El nombre");
                }
                catch (NombreInvalidoException ex)
                {
                    ep.SetError(txtNombre, ex.Message);
                    valido = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                ep.SetError(txtApellido, "El apellido es obligatorio");
                valido = false;
            }
            else
            {
                try
                {
                    Validador.ValidarNombre(txtApellido.Text.Trim(), "El apellido");
                }
                catch (NombreInvalidoException ex)
                {
                    ep.SetError(txtApellido, ex.Message);
                    valido = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                ep.SetError(txtNumeroDocumento, "El numero de documento es obligatorio");
                valido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                try
                {
                    Validador.ValidarTelefono(txtTelefono.Text.Trim());
                }
                catch (TelefonoInvalidoException ex)
                {
                    ep.SetError(txtTelefono, ex.Message);
                    valido = false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    Validador.ValidarEmail(txtEmail.Text.Trim());
                }
                catch (EmailInvalidoException ex)
                {
                    ep.SetError(txtEmail, ex.Message);
                    valido = false;
                }
            }

            bool esOtros = cboNacionalidad.SelectedValue is int idNac && idNac == Huesped.ID_NACIONALIDAD_OTROS;
            if (esOtros && string.IsNullOrWhiteSpace(txtNacionalidadEspecifica.Text))
            {
                ep.SetError(txtNacionalidadEspecifica, "Especifica la nacionalidad");
                valido = false;
            }

            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            TipoDocumento tipoDocumento = (TipoDocumento)cboTipoDocumento.SelectedItem;
            int idNacionalidad = (int)cboNacionalidad.SelectedValue;
            string nacionalidadEspecifica = idNacionalidad == Huesped.ID_NACIONALIDAD_OTROS
                ? txtNacionalidadEspecifica.Text.Trim()
                : null;
            string telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim();
            string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim().ToLower();

            if (huespedActual == null)
            {
                huespedService.Insertar(
                    txtNombre.Text.Trim(), txtApellido.Text.Trim(), tipoDocumento,
                    txtNumeroDocumento.Text.Trim(), idNacionalidad, nacionalidadEspecifica,
                    telefono, email);

                MessageBox.Show("Huesped agregado correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                huespedService.Actualizar(
                    huespedActual.IdHuesped, txtNombre.Text.Trim(), txtApellido.Text.Trim(), tipoDocumento,
                    txtNumeroDocumento.Text.Trim(), idNacionalidad, nacionalidadEspecifica,
                    telefono, email);

                MessageBox.Show("Huesped modificado correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroDocumento.Mask = "";
            switch (cboTipoDocumento.SelectedIndex) 
            {
                case 0://cedula
                    txtNumeroDocumento.Mask = "000 - 0000000 - 0";
                    break;
                case 1://Pasaporte
                    txtNumeroDocumento.Mask = "AAAAAAAAAA";
                    break;
                case 2://Licencia
                    txtNumeroDocumento.Mask = "AAAAAAAAAAA";
                    break;

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

     
    }
}
