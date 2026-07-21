using HotelZormat.Negocio;
using HotelZormat.Negocio.Servicios;
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
        FrmLogin Login = new FrmLogin();
        public FrmPrincipal()
        {
           
            InitializeComponent();
        }
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
