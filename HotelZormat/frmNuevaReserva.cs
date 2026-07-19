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
    public partial class frmNuevaReserva : Form
    {
        public frmNuevaReserva()
        {
            InitializeComponent();
        }

        private void frmNuevaReserva_Load(object sender, EventArgs e)
        {
            string[] tipohabitacion = { "Sencilla", "Doble", "Suite", "Presidecical" };
            cmbTipoHab.Items.Clear();

            foreach(string tipo in tipohabitacion)
            {
                cmbTipoHab.Items.Add(tipo);
            }
        }
    }
}
