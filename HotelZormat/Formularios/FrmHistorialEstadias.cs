using HotelZormat.Negocio;
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmHistorialEstadias : Form
    {
        private HuespedService huespedService = new HuespedService();
        private EstadiaService estadiaService = new EstadiaService();

        private int idHuespedSeleccionado = 0;
        private bool actualizandoTextoProgramaticamente = false;

        public FrmHistorialEstadias()
        {
            InitializeComponent();
            lstHuespedesSugeridos.Visible = false;
        }

        private void txtBuscarHuesped_Click(object sender, EventArgs e)
        {
            CargarListaHuespedes(txtBuscarHuesped.Text);
            lstHuespedesSugeridos.Visible = true;
        }

        private void txtBuscarHuesped_TextChanged(object sender, EventArgs e)
        {
            if (actualizandoTextoProgramaticamente) return;

            idHuespedSeleccionado = 0;
            dgvHistorial.DataSource = null;
            CargarListaHuespedes(txtBuscarHuesped.Text);
            lstHuespedesSugeridos.Visible = true;
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

        private void lstHuespedesSugeridos_DoubleClick(object sender, EventArgs e)
        {
            if (lstHuespedesSugeridos.SelectedItem is Huesped huespedSeleccionado)
            {
                idHuespedSeleccionado = huespedSeleccionado.IdHuesped;

                actualizandoTextoProgramaticamente = true;
                txtBuscarHuesped.Text = huespedSeleccionado.NombreCompleto();
                actualizandoTextoProgramaticamente = false;

                lstHuespedesSugeridos.Visible = false;
                CargarHistorial();
            }
        }

        private void CargarHistorial()
        {
            var historial = estadiaService.ObtenerHistorialPorHuesped(idHuespedSeleccionado);
            dgvHistorial.DataSource = historial;

            if (dgvHistorial.Columns["IdEstadia"] != null)
                dgvHistorial.Columns["IdEstadia"].Visible = false;
            if (dgvHistorial.Columns["IdReserva"] != null)
                dgvHistorial.Columns["IdReserva"].Visible = false;

            lblSinResultados.Visible = historial.Count == 0;
        }
    }
}
