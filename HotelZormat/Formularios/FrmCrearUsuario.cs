// Cedula: 402-1035106-6
using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Sesion;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmCrearUsuario : Form
    {
        private UsuarioService usuarioService = new UsuarioService();
       

        // Si es 0 (o no se pasa), esta en modo Crear.
        // Si trae un Id valido, esta en modo Modificar.
        private int idUsuarioEditar = 0;
        private bool modoEditar => idUsuarioEditar != 0;

        // Constructor para CREAR
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        // Constructor para MODIFICAR
        public FrmCrearUsuario(int idUsuario)
        {
            InitializeComponent();
            idUsuarioEditar = idUsuario;
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioActivo.Rol != "Administrador")
            {
                MessageBox.Show("No tiene permisos para acceder a esta pantalla.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            CargarTiposUsuario();

            if (modoEditar)
            {
                this.Text = "Modificar Usuario";
                CargarDatosUsuario();

                // En modo editar, la contrasena esta oculta por defecto
                // (solo se muestra si el admin marca "Cambiar contrasena")
                chkCambiarContrasena.Visible = true;
                chkCambiarContrasena.Checked = false;
                lblContrasena.Visible = false;
                txtContrasena.Visible = false;
                lblConfirmar.Visible = false;
                txtConfirmarContrasena.Visible = false;
            }
            else
            {
                this.Text = "Crear Usuario";
                chkCambiarContrasena.Visible = false; // no aplica en modo Crear
            }
        }

        private void CargarTiposUsuario()
        {
            cboTipoUsuario.DataSource = usuarioService.ObtenerTiposUsuario();
            cboTipoUsuario.DisplayMember = "Tipo";
            cboTipoUsuario.ValueMember = "IdTipo";
        }

        private void CargarDatosUsuario()
        {
            var usuario = usuarioService.ObtenerUsuarioPorId(idUsuarioEditar);
            if (usuario == null) return;

            txtNombre.Text = usuario.Nombre;
            cboTipoUsuario.SelectedValue = usuarioService.ObtenerIdTipoDeUsuario(idUsuarioEditar);
        }

        // Muestra/oculta los campos de contrasena segun el checkbox (solo en modo editar)
        private void chkCambiarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            bool mostrar = chkCambiarContrasena.Checked;
            lblContrasena.Visible = mostrar;
            txtContrasena.Visible = mostrar;
            lblConfirmar.Visible = mostrar;
            txtConfirmarContrasena.Visible = mostrar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LimpiarErrores();

            string nombre = txtNombre.Text.Trim();

            if (cboTipoUsuario.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un rol.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idTipo = Convert.ToInt32(cboTipoUsuario.SelectedValue);

            if (modoEditar)
            {
                GuardarModificacion(nombre, idTipo);
            }
            else
            {
                GuardarNuevo(nombre, idTipo);
            }
        }

        private void GuardarNuevo(string nombre, int idTipo)
        {
            string contrasena = txtContrasena.Text;
            string confirmar = txtConfirmarContrasena.Text;

            if (contrasena != confirmar)
            {
                epCrearUsuario.SetError(txtConfirmarContrasena, "Las contrasenas no coinciden.");
                return;
            }

            string error = usuarioService.CrearUsuario(nombre, contrasena, idTipo);

            if (error != null)
            {
                MessageBox.Show(error, "No se pudo crear el usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            MessageBox.Show("Usuario creado correctamente.", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GuardarModificacion(string nombre, int idTipo)
        {
            string errorDatos = usuarioService.ActualizarUsuario(idUsuarioEditar, nombre, idTipo);

            if (errorDatos != null)
            {
                MessageBox.Show(errorDatos, "No se pudo modificar el usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si marco el checkbox, tambien actualiza la contrasena
            if (chkCambiarContrasena.Checked)
            {
                string contrasena = txtContrasena.Text;
                string confirmar = txtConfirmarContrasena.Text;

                if (contrasena != confirmar)
                {
                    epCrearUsuario.SetError(txtConfirmarContrasena, "Las contrasenas no coinciden.");
                    return;
                }

                string errorPass = usuarioService.ActualizarContrasena(idUsuarioEditar, contrasena);
                if (errorPass != null)
                {
                    MessageBox.Show(errorPass, "No se pudo actualizar la contrasena",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
            }

          
            MessageBox.Show("Usuario modificado correctamente.", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LimpiarErrores()
        {
            epCrearUsuario.SetError(txtNombre, "");
            epCrearUsuario.SetError(txtConfirmarContrasena, "");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}