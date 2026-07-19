using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;

namespace HotelReto
{
    public partial class frmGestionHabitaciones : Form
    {
        private readonly HabitacionService _habitacionService;
        private Habitacion _habitacionActual;

        public frmGestionHabitaciones() 
        {
            InitializeComponent();
            _habitacionService = new HabitacionService();
        }

        private void frmGestionHabitaciones_Load(object sender, EventArgs e)
        {
            //paso 1
            List<string> tipos = new List<string>()
            {
                "Sencilla","Doble","Suite"
            };
           foreach (var tipo in tipos) 
           {
                cboTipo.Items.Add(tipo);
           }

           cboAccion.SelectedIndex = 0;
        }

        private void CargarPiso3() 
        {
            lstHabitaciones.Items.Clear();

            List<Habitacion> todas = _habitacionService.ObtenerTodas();

            foreach (var hab in todas)
            {
                if(hab.Piso == 3) 
                {
                    string linea= "#" + hab.Numero + " - " + hab.Tipo;
                    lstHabitaciones.Items.Add(linea);
                }
            }
        }

    }
}