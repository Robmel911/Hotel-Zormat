using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelZormat.Negocio;

namespace HotelZormat
{
    public partial class FrmPrincipal : Form
    {
        Pruebas PruebasBD = new Pruebas();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool ConexionExitosa = PruebasBD.ProbarBD();
                if (ConexionExitosa) MessageBox.Show("Conexión Exitosa");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }
    }
}
