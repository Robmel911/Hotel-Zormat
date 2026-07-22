// Cedula: [PON AQUI TU CEDULA]
using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Sesion;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmLogin : Form
    {
        private UsuarioService usuarioService = new UsuarioService();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtUsuario.Focus();
            LimpiarErrores();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RealizarLogin();
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RealizarLogin();
            }
        }

        private void RealizarLogin()
        {
            LimpiarErrores();

            string nombre = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            bool hayError = false;

            if (string.IsNullOrEmpty(nombre))
            {
                epLogin.SetError(txtUsuario, "Ingrese el usuario.");
                hayError = true;
            }

            if (string.IsNullOrEmpty(contrasena))
            {
                epLogin.SetError(txtContrasena, "Ingrese la contrasena.");
                hayError = true;
            }

            if (hayError) return;

            Usuario usuario = usuarioService.ValidarLogin(nombre, contrasena);

            if (usuario == null)
            {
                // Error de credenciales: lo marcamos en ambos campos
                epLogin.SetError(txtUsuario, "Usuario o contrasena incorrectos.");
                epLogin.SetError(txtContrasena, "Usuario o contrasena incorrectos.");
                txtContrasena.Clear();
                txtContrasena.Focus();
                return;
            }

            SesionActual.UsuarioActivo = usuario;
            new BitacoraService().Registrar("Inicio de sesion");
            AbrirFormPrincipal();
            
        }

        private void LimpiarErrores()
        {
            epLogin.Clear();
            epLogin.Clear();
        }

        private void AbrirFormPrincipal()
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Hide(); 
           
        }
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SesionActual.UsuarioActivo == null)
            {
                Application.Exit();
            }
        }

    }
}
