// Cedula: 402-1035106-6
using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Sesion;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmBitacora : Form
    {
        private BitacoraService bitacoraService = new BitacoraService();

        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            // Defensa extra: si por alguna razon alguien abre este form
            // sin ser Administrador, se cierra de inmediato.
            if (SesionActual.UsuarioActivo == null ||
                SesionActual.UsuarioActivo.Rol != "Administrador")
            {
                MessageBox.Show("No tiene permisos para acceder a esta pantalla.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            CargarBitacora();
        }

        private void CargarBitacora()
        {
            dgvBitacora.DataSource = bitacoraService.ObtenerBitacora();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1); // incluye todo el dia "hasta"

            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.",
                    "Fechas invalidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvBitacora.DataSource = bitacoraService.ObtenerBitacoraPorFecha(desde, hasta);
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            CargarBitacora();
        }
    }
}
