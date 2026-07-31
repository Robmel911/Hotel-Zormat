// Cedula: [tu cedula aqui]

using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmAdministrarHabitaciones : Form
    {
        private HabitacionService habitacionService = new HabitacionService();
        private Habitacion habitacionSeleccionada = null;

        public FrmAdministrarHabitaciones()
        {
            InitializeComponent();
        }

        private void FrmAdministrarHabitaciones_Load(object sender, EventArgs e)
        {
            CargarTarjetas();
        }

        private void CargarTarjetas()
        {
            int idSeleccionadoAnterior = habitacionSeleccionada?.IdHabitacion ?? -1;

            var habitaciones = habitacionService.ObtenerTodas();

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmCrearHabitaciones frm = new FrmCrearHabitaciones();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTarjetas();
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

            FrmCrearHabitaciones frm = new FrmCrearHabitaciones(habitacionSeleccionada);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarTarjetas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (habitacionSeleccionada == null)
            {
                MessageBox.Show("Seleccione una habitacion haciendo clic sobre su tarjeta.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Eliminar no implementado aun.", "Pendiente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}