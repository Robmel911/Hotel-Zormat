// FrmTransferirHabitacion.cs

using HotelZormat.Negocio;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmTransferirHabitacion : Form
    {
        private HabitacionService habitacionService = new HabitacionService();

        public int IdHabitacionSeleccionada { get; private set; }
        public string Motivo { get; private set; }

        public FrmTransferirHabitacion()
        {
            InitializeComponent();
            CargarHabitacionesDisponibles();
        }

        private void CargarHabitacionesDisponibles()
        {
            List<Habitacion> disponibles = habitacionService.ObtenerDisponibles();
            cboHabitaciones.DataSource = disponibles;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboHabitaciones.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una habitacion.");
                return;
            }

            Habitacion habitacion = (Habitacion)cboHabitaciones.SelectedItem;
            IdHabitacionSeleccionada = habitacion.IdHabitacion;
            Motivo = string.IsNullOrWhiteSpace(txtMotivo.Text) ? "Transferencia de habitacion" : txtMotivo.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
