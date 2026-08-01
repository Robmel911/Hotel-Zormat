using HotelZormat.Negocio;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Sesion;
using HotelZormat.UI.Formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelZormat
{
    public partial class FrmPrincipal : Form
    {
        // Formulario actualmente cargado dentro de pnlContenedor
        private Form frmActivo = null;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioActivo.Rol != "Administrador")
            {
                btnBitacora.Visible = false;
                btnAdministarHabitaciones.Visible = false;
                btnUsuarios.Visible = false;
            }

            MostrarInicio();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
                Application.Exit();
            
        }

        // ---------------------------------------------------------------
        // Carga de formularios dentro del panel de contenido
        // ---------------------------------------------------------------
        private void CargarFormularioEnPanel(Form frmHijo)
        {
            if (frmActivo != null)
            {
                frmActivo.Close();
                frmActivo.Dispose();
                frmActivo = null;
            }

            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(frmHijo);
            frmHijo.Show();

            frmActivo = frmHijo;
        }

        // ---------------------------------------------------------------
        // Home / Inicio
        // ---------------------------------------------------------------
        private void btnHome_Click(object sender, EventArgs e)
        {
            bool estabaAbierto = pnSubMenuInicio.Visible;
            MostrarInicio();
            pnSubMenuInicio.Visible = !estabaAbierto;

        }

        private void MostrarInicio()
        {
            CerrarTodosLosSubmenus();

            if (frmActivo != null)
            {
                frmActivo.Close();
                frmActivo.Dispose();
                frmActivo = null;
            }

            pnlContenedor.Controls.Clear();

            Label lblBienvenida = new Label
            {
                Text = "Bienvenido a Hotel Arrecife",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(13, 27, 42),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            pnlContenedor.Controls.Add(lblBienvenida);
        }

        // ---------------------------------------------------------------
        // Submenús estilo acordeón: solo uno abierto a la vez
        // ---------------------------------------------------------------
        private void CerrarTodosLosSubmenus()
        {
            pnSubmenuHabitaciones.Visible = false;
            pnSubmenuHuespedes.Visible = false;
            pnSubmenuReservas.Visible = false;
            pnSubMenuInicio.Visible = false;
        }

        private void btnMenuHabitaciones_Click(object sender, EventArgs e)
        {
            bool estabaAbierto = pnSubmenuHabitaciones.Visible;
            CerrarTodosLosSubmenus();
            pnSubmenuHabitaciones.Visible = !estabaAbierto;
        }

        private void btnMenuHuespedes_Click(object sender, EventArgs e)
        {
            bool estabaAbierto = pnSubmenuHuespedes.Visible;
            CerrarTodosLosSubmenus();
            pnSubmenuHuespedes.Visible = !estabaAbierto;
        }

        private void btnMenuReservas_Click(object sender, EventArgs e)
        {
            bool estabaAbierto = pnSubmenuReservas.Visible;
            CerrarTodosLosSubmenus();
            pnSubmenuReservas.Visible = !estabaAbierto;
        }

        // ---------------------------------------------------------------
        // Habitaciones
        // ---------------------------------------------------------------
        private void btnGestion_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmGestionHabitaciones());
        }

        private void btnAdministrarHabitaciones_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmAdministrarHabitaciones());
        }

        // ---------------------------------------------------------------
        // Huéspedes
        // ---------------------------------------------------------------
        private void btnGestionHuespedes_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmGestionHuespedes());
        }

        private void btnBuscarHuesped_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmHistorialEstadias());
        }

        // ---------------------------------------------------------------
        // Reservas
        // ---------------------------------------------------------------
        private void btnGestionReservas_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmGestionReservas());
        }

        // ---------------------------------------------------------------
        // Facturas y Bitácora
        // ---------------------------------------------------------------
        private void btnFacturas_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmGestionFacturas());
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmBitacora());
        }

        private void btnEstadias_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmGestionEstadias());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmGestionUsuarios());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que desea cerrar sesion?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            SesionActual.CerrarSesion();

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();

            this.Dispose();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            CargarFormularioEnPanel(new FrmReportes());
        }
    }
}