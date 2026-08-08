//Cedula 402-1035106-6
using System;
using System.Text;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmCreditos : Form
    {
        private int Matricula = 20242008;
        public FrmCreditos()
        {
            InitializeComponent();
            Ponermatricula(Matricula);
        }
        public void Ponermatricula(int matricula) 
        {
            string MatriculaTexto = matricula.ToString();
            MatriculaTexto = MatriculaTexto.Insert(4, "-");
            lblMatricula.Text = MatriculaTexto;
            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}