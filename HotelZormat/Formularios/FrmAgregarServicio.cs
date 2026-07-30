// FrmAgregarServicio.cs

using HotelZormat.Negocio;
using HotelZormat.Negocio.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmAgregarServicio : Form
    {
        private EstadiaService estadiaService = new EstadiaService();
        private int idEstadia;

        public FrmAgregarServicio(int idEstadia)
        {
            InitializeComponent();
            this.idEstadia = idEstadia;
        }

        private void FrmAgregarServicio_Load(object sender, EventArgs e)
        {
            CargarServicios();
            CargarConsumos();
        }

        private void CargarServicios()
        {
            List<Servicio> servicios = estadiaService.ObtenerServiciosActivos();
            cboServicios.DataSource = servicios;
        }

        private void CargarConsumos()
        {
            List<EstadiaServicio> consumos = estadiaService.ObtenerConsumoPorEstadia(idEstadia);
            lstConsumos.DataSource = null;
            lstConsumos.DataSource = consumos;

            decimal total = estadiaService.ObtenerTotalConsumo(idEstadia);
            lblTotal.Text = "Total consumido: " + total.ToString("C2");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboServicios.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un servicio.");
                return;
            }

            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }

            Servicio servicio = (Servicio)cboServicios.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            estadiaService.AgregarServicio(idEstadia, servicio, cantidad);

            CargarConsumos();
            nudCantidad.Value = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstConsumos.SelectedItem is EstadiaServicio consumoSeleccionado)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Eliminar este consumo?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    estadiaService.EliminarServicio(consumoSeleccionado.IdEstadiaServicio);
                    CargarConsumos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un consumo de la lista.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}