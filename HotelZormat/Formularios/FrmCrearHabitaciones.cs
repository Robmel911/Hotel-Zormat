// Cedula: 402-1035106-6
using System;
using System.Windows.Forms;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Modelo;
using System.Drawing;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmCrearHabitaciones : Form
    {
        private HabitacionService habitacionService = new HabitacionService();

        // Si viene null, el form trabaja en modo "Agregar"; si trae una habitacion, modo "Editar"
        private Habitacion habitacionAEditar;

        public FrmCrearHabitaciones()
        {
            InitializeComponent();
            habitacionAEditar = null;
        }

        public FrmCrearHabitaciones(Habitacion habitacion)
        {
            InitializeComponent();
            habitacionAEditar = habitacion;
        }

        private void FrmCrearHabitaciones_Load(object sender, EventArgs e)
        {
            CargarComboTipos();

            if (habitacionAEditar != null)
            {
                this.Text = "Editar Habitacion";
                btnGuardar.Text = "Modificar";
                CargarDatosEnFormulario();
            }
            else
            {
                this.Text = "Crear Habitacion";
                btnGuardar.Text = "Agregar";
            }
        }

        private void CargarComboTipos()
        {
            var tipos = habitacionService.ObtenerTiposHabitacion();
            cboTipo.DataSource = tipos;
            cboTipo.DisplayMember = "Tipo";
            cboTipo.ValueMember = "IdTipo";
        }

        private void CargarDatosEnFormulario()
        {
            txtNumero.Text = habitacionAEditar.Numero.ToString();
            cboTipo.Text = habitacionAEditar.Tipo;
            nudPiso.Value = habitacionAEditar.Piso;
            nudCapacidad.Value = habitacionAEditar.Capacidad;
            txtTarifaBase.Text = habitacionAEditar.TarifaBase.ToString();
        }

        private bool ValidarFormulario()
        {
            epHabitaciones.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNumero.Text) || !int.TryParse(txtNumero.Text, out int numero) || numero <= 100)
            {
                epHabitaciones.SetError(txtNumero, "Ingrese un numero de habitacion valido");
                esValido = false;
            }

            if (cboTipo.SelectedValue == null)
            {
                epHabitaciones.SetError(cboTipo, "Seleccione un tipo de habitacion");
                esValido = false;
            }

            if (!decimal.TryParse(txtTarifaBase.Text, out decimal tarifa) || tarifa <= 0)
            {
                epHabitaciones.SetError(txtTarifaBase, "Ingrese una tarifa valida mayor a cero");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            try
            {
                int numero = int.Parse(txtNumero.Text);
                int idTipo = (int)cboTipo.SelectedValue;
                int piso = (int)nudPiso.Value;
                int capacidad = (int)nudCapacidad.Value;
                decimal tarifaBase = decimal.Parse(txtTarifaBase.Text);

                if (habitacionAEditar == null)
                {
                    habitacionService.Insertar(numero, idTipo, piso, capacidad, tarifaBase);
                    MessageBox.Show("Habitacion agregada correctamente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    habitacionService.Actualizar(habitacionAEditar.IdHabitacion, numero, idTipo, piso, capacidad, tarifaBase);
                    MessageBox.Show("Habitacion modificada correctamente.", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la habitacion: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void nudPiso_ValueChanged(object sender, EventArgs e)
        {
            decimal Prefijo = this.nudPiso.Value;

            txtNumero.Mask= Prefijo.ToString()+ "00";
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch (cboTipo.Text)
            {
                case "Doble":
                    nudCapacidad.Value = 1;
                    nudCapacidad.Maximum = 2;
                    break;
                case "Individual":
                    nudCapacidad.Value = 1;
                    nudCapacidad.Maximum = 1;
                    break;
                case "Suite":
                    nudCapacidad.Value = 1;
                    nudCapacidad.Maximum = 10;
                    break;
                case "Familiar":
                    nudCapacidad.Value = 3;
                    nudCapacidad.Minimum = 3;
                    nudCapacidad.Maximum = 8;
                    break;
            }
        }
    }
}