//Cedula 402-1035106-6
using HotelZormat.Negocio.Servicios;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelZormat.UI.Formularios
{
    public partial class FrmReportes : Form
    {
        private readonly ReportesService _reportesService = new ReportesService();


        public FrmReportes()
        {
            InitializeComponent();
            lblTotalIngresos.Text= string.Empty;
        }

        private async void btnOcupacionDia_Click(object sender, EventArgs e)
        {
            var lista = await _reportesService.GetOcupacionDelDiaAsync(DateTime.Today);
            dgvReportes.DataSource = lista;
            lblTotalIngresos.Text = string.Empty;
        }

        private async void btnIngresosRango_Click(object sender, EventArgs e)
        {
            await CargarIngresosAsync();
        }

        private async void dtpRango_ValueChanged(object sender, EventArgs e)
        {
            await CargarIngresosAsync();
        }

        private async Task CargarIngresosAsync()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.");
                return;
            }

            var facturas = await _reportesService.GetFacturasPorRangoAsync(desde, hasta);
            dgvReportes.DataSource = facturas;

            decimal total = facturas.Sum(f => f.MontoTotal);
            lblTotalIngresos.Text = $"Total: RD$ {total:N2}";
        }
    }
}