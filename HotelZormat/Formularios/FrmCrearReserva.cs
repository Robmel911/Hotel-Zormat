// Cedula: 402-1035106-6
using HotelZormat.Negocio;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmCrearReserva : Form
    {
        private HuespedService huespedService = new HuespedService();
        private HabitacionService habitacionService = new HabitacionService();
        private ReservaService reservaService = new ReservaService();

        // Guardan el Id real seleccionado, aunque en pantalla solo se vea el nombre/numero
        private int idHuespedSeleccionado = 0;
        private int idHabitacionSeleccionado = 0;
        private bool actualizandoTextoProgramaticamente = false;

        public FrmCrearReserva()
        {
            InitializeComponent();
            lstHuespedesSugeridos.Visible = false;
            lstHabitacionesSugeridas.Visible = false;
            cmbTemporada.DataSource = Enum.GetValues(typeof(Temporada));
            dtpCheckIn.Value = DateTime.Today;
            dtpCheckOut.Value = DateTime.Today.AddDays(1);
            RecalcularNochesYMonto();
        }

        // ================= HUESPED =================

        private void txtBuscarHuesped_Click(object sender, EventArgs e)
        {
            CargarListaHuespedes(txtBuscarHuesped.Text);
            lstHuespedesSugeridos.Visible = true;
            lstHabitacionesSugeridas.Focus();
        }

        

        private void CargarListaHuespedes(string filtro)
        {
            var lista = huespedService.ObtenerTodos();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                lista = lista.Where(h => h.NombreCompleto().ToLower().Contains(filtro.ToLower())
                                       || h.NumeroDocumento.Contains(filtro))
                              .ToList();
            }

            lstHuespedesSugeridos.DataSource = null;
            lstHuespedesSugeridos.DataSource = lista;
        }
        private void txtBuscarHuesped_TextChanged(object sender, EventArgs e)
        {
            if (actualizandoTextoProgramaticamente) return;

            idHuespedSeleccionado = 0;
            CargarListaHuespedes(txtBuscarHuesped.Text);
            lstHuespedesSugeridos.Visible = true;
        }

        private void lstHuespedesSugeridos_DoubleClick(object sender, EventArgs e)
        {
            if (lstHuespedesSugeridos.SelectedItem is Huesped huespedSeleccionado)
            {
                idHuespedSeleccionado = huespedSeleccionado.IdHuesped;

                actualizandoTextoProgramaticamente = true;
                txtBuscarHuesped.Text = huespedSeleccionado.NombreCompleto();
                actualizandoTextoProgramaticamente = false;

                lstHuespedesSugeridos.Visible = false;
            }
        }

        // ================= HABITACION =================

        private void txtBuscarHabitacion_Click(object sender, EventArgs e)
        {
            CargarListaHabitaciones(txtBuscarHabitacion.Text);
            lstHabitacionesSugeridas.Visible = true;
            lstHabitacionesSugeridas.Focus();
        }

        private void txtBuscarHabitacion_TextChanged(object sender, EventArgs e)
        {
            if (actualizandoTextoProgramaticamente) return; // ignora el cambio si lo generamos nosotros

            idHabitacionSeleccionado = 0;
            CargarListaHabitaciones(txtBuscarHabitacion.Text);
            lstHabitacionesSugeridas.Visible = true;
        }

        private void CargarListaHabitaciones(string filtro)
        {
          
            var lista = habitacionService.ObtenerTodas();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                lista = lista.Where(h => h.Numero.ToString().Contains(filtro)).ToList();
            }

            lstHabitacionesSugeridas.DataSource = null;
            lstHabitacionesSugeridas.DataSource = lista;
        }

        private void lstHabitacionesSugeridas_DoubleClick(object sender, EventArgs e)
        {
            if (lstHabitacionesSugeridas.SelectedItem is Habitacion habitacionSeleccionada)
            {
                idHabitacionSeleccionado = habitacionSeleccionada.IdHabitacion;

                actualizandoTextoProgramaticamente = true;
                txtBuscarHabitacion.Text = habitacionSeleccionada.Numero.ToString();
                actualizandoTextoProgramaticamente = false;

                lstHabitacionesSugeridas.Visible = false;
                RecalcularNochesYMonto();
            }
        }

        // ================= CALCULO EN TIEMPO REAL =================

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            RecalcularNochesYMonto();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            RecalcularNochesYMonto();
        }

        private void cmbTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecalcularNochesYMonto();
        }

        private void RecalcularNochesYMonto()
        {
            if (dtpCheckOut.Value.Date <= dtpCheckIn.Value.Date || idHabitacionSeleccionado == 0
                || cmbTemporada.SelectedItem == null)
            {
                lblNoches.Text = "0";
                lblMontoTotal.Text = "0.00";
                return;
            }

            int noches = (dtpCheckOut.Value.Date - dtpCheckIn.Value.Date).Days;
            Temporada temporada = (Temporada)cmbTemporada.SelectedItem;
            decimal tarifaBase = habitacionService.ObtenerTarifaBase(idHabitacionSeleccionado);
            decimal montoTotal = reservaService.CalcularMonto(noches, tarifaBase, temporada);

            lblNoches.Text = noches.ToString();
            lblMontoTotal.Text = montoTotal.ToString("C2");
        }

        // ================= GUARDAR =================

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idHuespedSeleccionado == 0)
                {
                    ep.SetError(txtBuscarHuesped, "El huesped esta vacio o no es valido");
                    return;
                }

                if (idHabitacionSeleccionado == 0)
                {
                    ep.SetError(txtBuscarHabitacion, "La habitacion esta vacia o no es valida");
                    return;
                }

                if (cmbTemporada.SelectedItem == null)
                {
                    ep.SetError(cmbTemporada, "Seleccione una temporada");
                    return;
                }

                Temporada temporada = (Temporada)cmbTemporada.SelectedItem;
                decimal tarifaBase = habitacionService.ObtenerTarifaBase(idHabitacionSeleccionado);

                reservaService.CrearReserva(
                    idHabitacionSeleccionado,
                    idHuespedSeleccionado,
                    dtpCheckIn.Value.Date,
                    dtpCheckOut.Value.Date,
                    temporada,
                    tarifaBase);

                MessageBox.Show("Reserva creada correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ReservaFechasInvalidasException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
