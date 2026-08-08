// Cedula: 402-1035106-6
using HotelZormat.Modelo;
using HotelZormat.Negocio.Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmInfoHabitacion : Form
    {
        private HabitacionService habitacionService = new HabitacionService();
        private int idHabitacion;

        public FrmInfoHabitacion(int idHabitacion)
        {
            InitializeComponent();
            this.idHabitacion = idHabitacion;
        }

        private void FrmInfoHabitacion_Load(object sender, EventArgs e)
        {
            Habitacion h = habitacionService.ObtenerPorId(idHabitacion);

            if (h == null)
            {
                MessageBox.Show("No se encontro la habitacion solicitada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            CargarDatos(h);
        }

        private void CargarDatos(Habitacion h)
        {
            lblTituloNumero.Text = "Habitacion " + h.Numero;
            lblTipo.Text = h.Tipo;
            lblPiso.Text = h.Piso.ToString();
            lblCapacidad.Text = h.Capacidad.ToString();
            lblTarifaBase.Text = h.TarifaBase.ToString("C2");
            lblEstado.Text = h.Estado.ToString();
            lblEstado.ForeColor = ColorPorEstado(h.Estado);
        }

        private Color ColorPorEstado(EstadoHabitacion estado)
        {
            switch (estado)
            {
                case EstadoHabitacion.Disponible:
                    return Color.Green;
                case EstadoHabitacion.Ocupada:
                    return Color.Red;
                case EstadoHabitacion.Reservada:
                    return Color.DarkOrange;
                case EstadoHabitacion.Limpieza:
                    return Color.SteelBlue;
                default:
                    return Color.Black;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
