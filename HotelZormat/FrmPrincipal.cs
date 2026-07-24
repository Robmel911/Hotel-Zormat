using HotelZormat.Negocio;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Sesion;
using HotelZormat.UI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelZormat
{
    public partial class FrmPrincipal : Form
    {
        

        public FrmPrincipal()
        {
           
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioActivo.Rol != "Administrador")
            {
               btnBitacora.Visible = false; // ajusta el nombre real de tu boton/menu
                btnModificarHabitaciones.Visible = false;
            }
        }
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            FrmBitacora frm = new FrmBitacora();
            frm.ShowDialog();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            FrmGestionHabitaciones frm = new FrmGestionHabitaciones();
            frm.ShowDialog();
        }

        private void btnModificarHabitaciones_Click(object sender, EventArgs e)
        {
            FrmModificarHabitaciones frm = new FrmModificarHabitaciones();
            frm.ShowDialog();
        }

        private void btnHuespedes_Click(object sender, EventArgs e)
        {
            FrmGestionHuespedes frm = new FrmGestionHuespedes();
            frm.ShowDialog();
        }
    }
}
