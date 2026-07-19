using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelZormat
{
    public partial class FrmPrincipal : Form
    {
        FrmHabitacion frmHabitacion = new FrmHabitacion();
        frmNuevaReserva frmNuevaReserva = new frmNuevaReserva();
        Prueba prueba = new Prueba();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btniniciarSesion_Click(object sender, EventArgs e)
        {
           string Usuario = txtUsuario.Text;
            string Contrasena = txtContrasena.Text;

            if (Contrasena == "1234")
            {
                MostrarBienvenida(Usuario);
              //  frmNuevaReserva.ShowDialog();
                this.Visible = false;
                
                prueba.ShowDialog();
                this.Dispose();


            }
            else { MessageBox.Show("Usuario Incorrecto"); }

        }

        private void MostrarBienvenida(string rol)
        {
            switch (rol)
            {
                case "Admin":
                    MessageBox.Show("Bienvenido Administrador");
                    break;
                case "Recepcionista":
                    MessageBox.Show("Hola,Recepcionista");
                    break;
                case "Gerente":
                    MessageBox.Show("Buenas,gerente");
                    break;
                default:
                    MessageBox.Show("Rol Desconocido");
                    break;
            }
        }
    }
}
