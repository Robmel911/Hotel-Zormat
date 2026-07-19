using HotelReto;
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
    public partial class Prueba : Form
    {
        frmGestionHabitaciones frmGestor = new frmGestionHabitaciones();
        private Timer timer;
        private int colorIndex = 0;

        // Lista de colores del arcoíris
        private Color[] rainbowColors = new Color[]
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Indigo,
            Color.Violet
        };
        public Prueba()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 500; // medio segundo
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cambiar el color de fondo del formulario
            this.BackColor = rainbowColors[colorIndex];

            // Avanzar al siguiente color
            colorIndex++;
            if (colorIndex >= rainbowColors.Length)
                colorIndex = 0; // Reiniciar al inicio
        }
        private void Prueba_Load(object sender, EventArgs e)
        {
            

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGestor.ShowDialog();
            this.Dispose();
        }
    }
}

