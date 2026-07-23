// Cedula: 402-1035106-6
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using HotelZormat.Negocio.Servicios;
using HotelZormat.Negocio.Modelo;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmGestionHabitaciones : Form
    {
        private HabitacionService habitacionService = new HabitacionService();
        private List<Habitacion> todasLasHabitaciones = new List<Habitacion>();
        private Habitacion habitacionSeleccionada = null;
        private const string FiltroTodos = "Todos";

        public FrmGestionHabitaciones()
        {
            InitializeComponent();
        }

        private void FrmGestionHabitaciones_Load(object sender, EventArgs e)
        {
            CargarComboEstado();
            CargarComboFiltroEstado();
            CargarDashboard();
            timerRefresco.Start();
        }

        private void timerRefresco_Tick(object sender, EventArgs e)
        {
            CargarDashboard();
        }

        private void CargarComboEstado()
        {
            cboEstado.DataSource = Enum.GetValues(typeof(EstadoHabitacion));
        }

        private void CargarComboFiltroEstado()
        {
            cboFiltroEstado.Items.Add(FiltroTodos);
            foreach (EstadoHabitacion estado in Enum.GetValues(typeof(EstadoHabitacion)))
            {
                cboFiltroEstado.Items.Add(estado);
            }
            cboFiltroEstado.SelectedIndex = 0;
        }

        private void CargarDashboard()
        {
            todasLasHabitaciones = habitacionService.ObtenerTodas();
            AplicarFiltro();
        }

        private void AplicarFiltro()
        {
            IEnumerable<Habitacion> resultado = todasLasHabitaciones;

            if (!string.IsNullOrWhiteSpace(txtBuscarNumero.Text))
            {
                resultado = resultado.Where(h => h.Numero.ToString().Contains(txtBuscarNumero.Text.Trim()));
            }

            if (cboFiltroEstado.SelectedItem != null && cboFiltroEstado.SelectedItem.ToString() != FiltroTodos)
            {
                EstadoHabitacion estadoFiltro = (EstadoHabitacion)cboFiltroEstado.SelectedItem;
                resultado = resultado.Where(h => h.Estado == estadoFiltro);
            }

            int idSeleccionadoAnterior = habitacionSeleccionada?.IdHabitacion ?? -1;

            flpHabitaciones.SuspendLayout();
            flpHabitaciones.Controls.Clear();
            habitacionSeleccionada = null;

            foreach (Habitacion h in resultado)
            {
                Panel tarjeta = CrearTarjeta(h);
                flpHabitaciones.Controls.Add(tarjeta);

                // Conserva la seleccion tras un refresco automatico
                if (h.IdHabitacion == idSeleccionadoAnterior)
                {
                    SeleccionarTarjeta(tarjeta, h);
                }
            }

            flpHabitaciones.ResumeLayout();
            ActualizarLabelSeleccion();
        }

        private void txtBuscarNumero_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void cboFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private Panel CrearTarjeta(Habitacion h)
        {
            Panel tarjeta = new Panel
            {
                Width = 140,
                Height = 100,
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

            Label lblCantidad = new Label
            {
                Text = "Cantidad: " + h.Capacidad ,
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
            tarjeta.Controls.Add(lblTipo);
            tarjeta.Controls.Add(lblNumero);

            // El clic en cualquier parte de la tarjeta (incluidos los labels) selecciona la habitacion
            EventHandler clickHandler = (s, e) => SeleccionarTarjeta(tarjeta, h);
            tarjeta.Click += clickHandler;
            lblNumero.Click += clickHandler;
            lblTipo.Click += clickHandler;
            lblEstado.Click += clickHandler;

            return tarjeta;
        }

        private void SeleccionarTarjeta(Panel tarjeta, Habitacion h)
        {
            // Quita el resaltado de la tarjeta previamente seleccionada
            foreach (Control c in flpHabitaciones.Controls)
            {
                if (c is Panel panelTarjeta)
                {
                    panelTarjeta.BorderStyle = BorderStyle.FixedSingle;
                }
            }

            tarjeta.BorderStyle = BorderStyle.Fixed3D;
            habitacionSeleccionada = h;
            ActualizarLabelSeleccion();
        }

        private void ActualizarLabelSeleccion()
        {
            lblSeleccion.Text = habitacionSeleccionada == null
                ? "Ninguna habitacion seleccionada"
                : "Seleccionada: Hab. " + habitacionSeleccionada.Numero + " (" + habitacionSeleccionada.Estado + ")";
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

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (habitacionSeleccionada == null)
            {
                MessageBox.Show("Seleccione una habitacion haciendo clic sobre su tarjeta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el nuevo estado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EstadoHabitacion nuevoEstado = (EstadoHabitacion)cboEstado.SelectedItem;

            habitacionService.CambiarEstado(habitacionSeleccionada.IdHabitacion, nuevoEstado);
            CargarDashboard();
        }

        private void FrmGestionHabitaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerRefresco.Stop();
        }
    }
}