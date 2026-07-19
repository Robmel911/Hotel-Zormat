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
    public partial class FrmHabitacion : Form
    {
        public FrmHabitacion()
        {
            InitializeComponent();
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            string estado= txtEstado.Text;
            ActualizarColor(estado);
        }

        private void ActualizarColor(string estado)
        {
            lblEstadoHab.Text = estado;

            switch (estado)
            {
                case "Disponible":
                    lblEstadoHab.Text = "Disponible";
                    lblEstadoHab.ForeColor = Color.Green;
                break;

                case "Mantenimiento":
                    lblEstadoHab.Text = "Mantenimiento";
                    lblEstadoHab.ForeColor = Color.Orange;
                    break;
            }
        }
    }
}
