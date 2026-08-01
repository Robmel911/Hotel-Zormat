using HotelZormat.Negocio;
using HotelZormat.Modelo;
using HotelZormat.UI.Formularios;
using System;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmGestionEstadias : Form
    {
        private EstadiaService estadiaService = new EstadiaService();

        public FrmGestionEstadias()
        {
            InitializeComponent();
        }

        private void FrmGestionEstadias_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvEstadias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstadias.MultiSelect = false;
            dgvEstadias.ReadOnly = true;
            dgvEstadias.AllowUserToAddRows = false;
        }

        private void CargarGrid()
        {
            dgvEstadias.DataSource = estadiaService.ObtenerTodasActivas();

            if (dgvEstadias.Columns["IdReserva"] != null)
                dgvEstadias.Columns["IdReserva"].Visible = false;
            if (dgvEstadias.Columns["IdHabitacion"] != null)
                dgvEstadias.Columns["IdHabitacion"].Visible = false;
        }

        private Estadia ObtenerEstadiaSeleccionada()
        {
            if (dgvEstadias.SelectedRows.Count == 0) return null;

            DataGridViewRow fila = dgvEstadias.SelectedRows[0];
            int idEstadia = Convert.ToInt32(fila.Cells["IdEstadia"].Value);
            return estadiaService.ObtenerPorId(idEstadia);
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            Estadia estadia = ObtenerEstadiaSeleccionada();
            if (estadia == null)
            {
                MessageBox.Show("Seleccione una estadia primero.");
                return;
            }

            using (FrmAgregarServicio frm = new FrmAgregarServicio(estadia.IdEstadia))
            {
                frm.ShowDialog();
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Estadia estadia = ObtenerEstadiaSeleccionada();
            if (estadia == null)
            {
                MessageBox.Show("Seleccione una estadia primero.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Esta seguro/a de transferir esta habitacion a otro cuarto?",
                "Confirmar transferencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            using (FrmTransferirHabitacion frmTransferir = new FrmTransferirHabitacion())
            {
                if (frmTransferir.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        estadiaService.TransferirHabitacion(
                            estadia.IdEstadia,
                            estadia.IdReserva,
                            frmTransferir.IdHabitacionSeleccionada,
                            frmTransferir.Motivo);

                        MessageBox.Show("Transferencia realizada correctamente.");
                        CargarGrid();
                    }
                    catch (ReservaNoDisponibleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnVerHistrorial_Click(object sender, EventArgs e)
        {
            FrmHistorialEstadias frm = new FrmHistorialEstadias();
            frm.ShowDialog();
        }
    }
}
