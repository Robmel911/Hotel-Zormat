// Cedula: 402-1035106-6
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Sesion;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmModificarHabitaciones : Form
    {
        private HabitacionService habitacionService = new HabitacionService();
        private Habitacion habitacionSeleccionada = null;
        private const string Matricula = "2024-2008"; 

        public FrmModificarHabitaciones()
        {
            InitializeComponent();
        }

        private void FrmModificarHabitaciones_Load(object sender, EventArgs e)
        {
            if (SesionActual.UsuarioActivo == null || SesionActual.UsuarioActivo.Rol != "Administrador")
            {
                MessageBox.Show("Acceso restringido a Administradores.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            CargarComboTipos();
            CargarTarjetas();
        }

        private void CargarComboTipos()
        {
            var tipos = habitacionService.ObtenerTiposHabitacion();
            cboTipo.DataSource = tipos;
            cboTipo.DisplayMember = "Tipo";
            cboTipo.ValueMember = "IdTipo";
        }

        private void CargarTarjetas()
        {
            int idSeleccionadoAnterior = habitacionSeleccionada?.IdHabitacion ?? -1;

            List<Habitacion> habitaciones = habitacionService.ObtenerTodas();

            flpHabitaciones.SuspendLayout();
            flpHabitaciones.Controls.Clear();
            habitacionSeleccionada = null;

            foreach (Habitacion h in habitaciones)
            {
                Panel tarjeta = CrearTarjeta(h);
                flpHabitaciones.Controls.Add(tarjeta);

                if (h.IdHabitacion == idSeleccionadoAnterior)
                {
                    SeleccionarTarjeta(tarjeta, h);
                }
            }

            flpHabitaciones.ResumeLayout();

            if (habitacionSeleccionada == null)
            {
                LimpiarFormulario();
            }
        }

        private Panel CrearTarjeta(Habitacion h)
        {
            Panel tarjeta = new Panel
            {
                Width = 140,
                Height = 120,
                Margin = new Padding(8),
                BackColor = ColorPorEstado(h.Estado),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = h,
                Cursor = Cursors.Hand
            };

            Label lblNumero = new Label
            {
                Text = "Hab. " + h.Numero,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblTipo = new Label
            {
                Text = h.Tipo + " - Piso " + h.Piso,
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 25,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblCapacidad = new Label
            {
                Text = "Capacidad: " + h.Capacidad,
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblEstado = new Label
            {
                Text = h.Estado.ToString(),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = false,
                Dock = DockStyle.Bottom,
                Height = 25,
                TextAlign = ContentAlignment.MiddleCenter
            };

            tarjeta.Controls.Add(lblEstado);
            tarjeta.Controls.Add(lblCapacidad);
            tarjeta.Controls.Add(lblTipo);
            tarjeta.Controls.Add(lblNumero);

            EventHandler clickHandler = (s, e) => SeleccionarTarjeta(tarjeta, h);
            tarjeta.Click += clickHandler;
            lblNumero.Click += clickHandler;
            lblTipo.Click += clickHandler;
            lblCapacidad.Click += clickHandler;
            lblEstado.Click += clickHandler;

            return tarjeta;
        }

        private void SeleccionarTarjeta(Panel tarjeta, Habitacion h)
        {
            foreach (Control c in flpHabitaciones.Controls)
            {
                if (c is Panel panelTarjeta)
                {
                    panelTarjeta.BorderStyle = BorderStyle.FixedSingle;
                }
            }

            tarjeta.BorderStyle = BorderStyle.Fixed3D;
            habitacionSeleccionada = h;

            // Autocompleta el formulario con los datos de la tarjeta elegida
            txtNumero.Text = h.Numero.ToString();
            cboTipo.Text = h.Tipo;
            nudPiso.Value = h.Piso;
            nudCapacidad.Value = h.Capacidad;
            txtTarifaBase.Text = h.TarifaBase.ToString();

            lblSeleccion.Text = "Editando: Hab. " + h.Numero;
        }

        private Color ColorPorEstado(EstadoHabitacion estado)
        {
            switch (estado)
            {
                case EstadoHabitacion.Disponible:
                    return Color.LightGreen;
                case EstadoHabitacion.Ocupada:
                    return Color.LightCoral;
                case EstadoHabitacion.Reservada:
                    return Color.Orange;
                case EstadoHabitacion.Limpieza:
                    return Color.LightBlue;
                default:
                    return Color.LightGray;
            }
        }

        private bool ValidarFormulario()
        {
            epHabitaciones.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtNumero.Text) || !int.TryParse(txtNumero.Text, out int numero) || numero <= 0)
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

        private void btnAgregar_Click(object sender, EventArgs e)
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

                habitacionService.Insertar(numero, idTipo, piso, capacidad, tarifaBase);

                CargarTarjetas();
                LimpiarFormulario();
                MessageBox.Show("Habitacion agregada correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la habitacion: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (habitacionSeleccionada == null)
            {
                MessageBox.Show("Seleccione una habitacion haciendo clic sobre su tarjeta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarFormulario())
                return;

            try
            {
                int numero = int.Parse(txtNumero.Text);
                int idTipo = (int)cboTipo.SelectedValue;
                int piso = (int)nudPiso.Value;
                int capacidad = (int)nudCapacidad.Value;
                decimal tarifaBase = decimal.Parse(txtTarifaBase.Text);

                habitacionService.Actualizar(habitacionSeleccionada.IdHabitacion, numero, idTipo, piso, capacidad, tarifaBase);

                CargarTarjetas();
                LimpiarFormulario();
                MessageBox.Show("Habitacion modificada correctamente.", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar la habitacion: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNumero.Clear();
            txtTarifaBase.Clear();
            nudPiso.Value = 1;
            nudCapacidad.Value = 1;
            epHabitaciones.Clear();
            habitacionSeleccionada = null;
            lblSeleccion.Text = "Ninguna habitacion seleccionada (modo: nueva habitacion)";

            foreach (Control c in flpHabitaciones.Controls)
            {
                if (c is Panel panelTarjeta)
                {
                    panelTarjeta.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }
    }
}
