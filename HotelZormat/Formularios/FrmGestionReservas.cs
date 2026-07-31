using HotelZormat.Negocio;
using HotelZormat.Negocio.Modelo;
using HotelZormat.Negocio.Servicios;
using HotelZormat.UI.Formularios;
using System;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmGestionReservas : Form
    {
        private ReservaService reservaService = new ReservaService();
        private HabitacionService habitacionService = new HabitacionService();
        private EstadiaService estadiaService = new EstadiaService();

        public FrmGestionReservas()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarGrid();
            ActualizarBotones(); // arranca todo deshabilitado, sin fila seleccionada
        }

        private void ConfigurarGrid()
        {
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.MultiSelect = false;
            dgvReservas.ReadOnly = true;
            dgvReservas.AllowUserToAddRows = false;
        }

        private void CargarGrid()
        {
            dgvReservas.DataSource = reservaService.ObtenerTodos();

            if (dgvReservas.Columns["IdReserva"] != null)
                dgvReservas.Columns["IdReserva"].Visible = false;
            if (dgvReservas.Columns["IdHabitacion"] != null)
                dgvReservas.Columns["IdHabitacion"].Visible = false;
            if (dgvReservas.Columns["IdHuesped"] != null)
                dgvReservas.Columns["IdHuesped"].Visible = false;
        }

        // ================= NUEVA RESERVA =================

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            using (FrmCrearReserva frm = new FrmCrearReserva())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarGrid();
                }
            }
        }

        // ================= SELECCION =================

        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarBotones();
        }

        private void ActualizarBotones()
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                btnConfirmar.Enabled = false;
                btnCancelar.Enabled = false;
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = false;
                return;
            }

            Reserva reserva = ObtenerReservaSeleccionada();

            btnConfirmar.Enabled = reserva.Estado == EstadoReserva.Pendiente;
            btnCancelar.Enabled = reserva.Estado != EstadoReserva.Cancelada;
            btnCheckIn.Enabled = reserva.Estado == EstadoReserva.Confirmada;
            btnCheckOut.Enabled = reserva.Estado == EstadoReserva.Confirmada;
        }

        private Reserva ObtenerReservaSeleccionada()
        {
            DataGridViewRow fila = dgvReservas.SelectedRows[0];
            int idReserva = Convert.ToInt32(fila.Cells["IdReserva"].Value);
            return reservaService.ObtenerPorId(idReserva);
        }

        // ================= ACCIONES =================

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva reserva = ObtenerReservaSeleccionada();
                reservaService.ConfirmarReserva(reserva.IdReserva, reserva.IdHabitacion,
                                                 reserva.FechaCheckIn, reserva.FechaCheckOut);
                MessageBox.Show("Reserva confirmada.");
                CargarGrid();
            }
            catch (ReservaNoDisponibleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reserva reserva = ObtenerReservaSeleccionada();

            DialogResult confirmacion = MessageBox.Show(
                "¿Seguro que desea cancelar esta reserva?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                reservaService.CancelarReserva(reserva.IdReserva);
                MessageBox.Show("Reserva cancelada.");
                CargarGrid();
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva reserva = ObtenerReservaSeleccionada();
                reservaService.RealizarCheckIn(reserva.IdReserva, reserva.IdHabitacion);
                MessageBox.Show("Check-in realizado.");
                CargarGrid();
            }
            catch (ReservaNoDisponibleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva reserva = ObtenerReservaSeleccionada();
                Habitacion habitacion = habitacionService.ObtenerPorId(reserva.IdHabitacion);
                Estadia estadia = estadiaService.ObtenerActivaPorReserva(reserva.IdReserva);
                FrmGenerarFactura frm = new FrmGenerarFactura(
                    reserva.IdReserva,reserva.IdHabitacion,estadia.IdEstadia
                    , Convert.ToString(habitacion.Numero) ,reserva.NombreHuesped
                    , reserva.FechaCheckIn, reserva.FechaCheckOut, reserva.CantidadNoches);
                frm.ShowDialog();
            }
            catch (ReservaNoDisponibleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= FILTROS =================

        private void btnVerProximas7Dias_Click(object sender, EventArgs e)
        {
            dgvReservas.DataSource = reservaService.ObtenerProximas7Dias();
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}