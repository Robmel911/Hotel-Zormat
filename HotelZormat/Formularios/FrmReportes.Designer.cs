using System;

namespace HotelZormat.UI.Formularios
{
    partial class FrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // ---- Controles originales (mismos nombres, para no romper el codebehind) ----
        private System.Windows.Forms.Button btnOcupacionDia;
        private System.Windows.Forms.Button btnIngresosRango;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;

        // ---- Controles nuevos, solo decorativos/organizativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloReportes;
        private System.Windows.Forms.Label lblSubtituloReportes;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlDividerFiltros;
        private System.Windows.Forms.Panel pnlResumen;
        private System.Windows.Forms.Panel pnlContenido;

        private void InitializeComponent()
        {
            this.btnOcupacionDia = new System.Windows.Forms.Button();
            this.btnIngresosRango = new System.Windows.Forms.Button();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloReportes = new System.Windows.Forms.Label();
            this.lblSubtituloReportes = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.pnlDividerFiltros = new System.Windows.Forms.Panel();
            this.pnlResumen = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlResumen.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // pnlHeader
            // =========================================================
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1633, 90);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblTituloReportes);
            this.pnlHeader.Controls.Add(this.lblSubtituloReportes);

            // 
            // lblTituloReportes
            // 
            this.lblTituloReportes.AutoSize = true;
            this.lblTituloReportes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloReportes.ForeColor = System.Drawing.Color.White;
            this.lblTituloReportes.Location = new System.Drawing.Point(40, 16);
            this.lblTituloReportes.Name = "lblTituloReportes";
            this.lblTituloReportes.Size = new System.Drawing.Size(140, 32);
            this.lblTituloReportes.TabIndex = 0;
            this.lblTituloReportes.Text = "Reportes";

            // 
            // lblSubtituloReportes
            // 
            this.lblSubtituloReportes.AutoSize = true;
            this.lblSubtituloReportes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtituloReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtituloReportes.Location = new System.Drawing.Point(43, 54);
            this.lblSubtituloReportes.Name = "lblSubtituloReportes";
            this.lblSubtituloReportes.Size = new System.Drawing.Size(320, 20);
            this.lblSubtituloReportes.TabIndex = 1;
            this.lblSubtituloReportes.Text = "Ocupación del día e ingresos por rango de fecha";

            // =========================================================
            // pnlFiltros
            // =========================================================
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 90);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1633, 110);
            this.pnlFiltros.TabIndex = 1;
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.btnOcupacionDia);
            this.pnlFiltros.Controls.Add(this.btnIngresosRango);
            this.pnlFiltros.Controls.Add(this.pnlDividerFiltros);

            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblDesde.Location = new System.Drawing.Point(40, 38);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(58, 20);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";

            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(105, 33);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(160, 27);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Value = DateTime.Today.AddDays(-30);
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpRango_ValueChanged);

            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblHasta.Location = new System.Drawing.Point(300, 38);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(54, 20);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";

            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(362, 33);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(160, 27);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.Value = DateTime.Today;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpRango_ValueChanged);

            // 
            // btnOcupacionDia (estilo secundario: contorno navy)
            // 
            this.btnOcupacionDia.BackColor = System.Drawing.Color.White;
            this.btnOcupacionDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcupacionDia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnOcupacionDia.FlatAppearance.BorderSize = 2;
            this.btnOcupacionDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            this.btnOcupacionDia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOcupacionDia.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnOcupacionDia.Location = new System.Drawing.Point(570, 25);
            this.btnOcupacionDia.Name = "btnOcupacionDia";
            this.btnOcupacionDia.Size = new System.Drawing.Size(230, 44);
            this.btnOcupacionDia.TabIndex = 4;
            this.btnOcupacionDia.Text = "Ocupación del Día";
            this.btnOcupacionDia.UseVisualStyleBackColor = false;
            this.btnOcupacionDia.Click += new System.EventHandler(this.btnOcupacionDia_Click);

            // 
            // btnIngresosRango (estilo primario: azul Zormat)
            // 
            this.btnIngresosRango.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnIngresosRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresosRango.FlatAppearance.BorderSize = 0;
            this.btnIngresosRango.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnIngresosRango.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresosRango.ForeColor = System.Drawing.Color.White;
            this.btnIngresosRango.Location = new System.Drawing.Point(820, 25);
            this.btnIngresosRango.Name = "btnIngresosRango";
            this.btnIngresosRango.Size = new System.Drawing.Size(230, 44);
            this.btnIngresosRango.TabIndex = 5;
            this.btnIngresosRango.Text = "Ingresos por Rango";
            this.btnIngresosRango.UseVisualStyleBackColor = false;
            this.btnIngresosRango.Click += new System.EventHandler(this.btnIngresosRango_Click);

            // 
            // pnlDividerFiltros
            // 
            this.pnlDividerFiltros.BackColor = System.Drawing.Color.FromArgb(225, 228, 232);
            this.pnlDividerFiltros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDividerFiltros.Location = new System.Drawing.Point(0, 108);
            this.pnlDividerFiltros.Name = "pnlDividerFiltros";
            this.pnlDividerFiltros.Size = new System.Drawing.Size(1633, 2);
            this.pnlDividerFiltros.TabIndex = 6;

            // =========================================================
            // pnlResumen
            // =========================================================
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.FromArgb(247, 249, 251);
            this.pnlResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResumen.Location = new System.Drawing.Point(0, 200);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(1633, 70);
            this.pnlResumen.TabIndex = 2;
            this.pnlResumen.Controls.Add(this.lblTotalIngresos);

            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalIngresos.ForeColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.lblTotalIngresos.Location = new System.Drawing.Point(40, 20);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(180, 32);
            this.lblTotalIngresos.TabIndex = 0;
            this.lblTotalIngresos.Text = "Total: RD$ 0.00";

            // =========================================================
            // pnlContenido (contiene el grid, con margen interno)
            // =========================================================
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 270);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(40, 25, 40, 40);
            this.pnlContenido.Size = new System.Drawing.Size(1633, 754);
            this.pnlContenido.TabIndex = 3;
            this.pnlContenido.Controls.Add(this.dgvReportes);

            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReportes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.dgvReportes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReportes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvReportes.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.dgvReportes.ColumnHeadersHeight = 42;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReportes.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvReportes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.dgvReportes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportes.EnableHeadersVisualStyles = false;
            this.dgvReportes.GridColor = System.Drawing.Color.FromArgb(230, 233, 237);
            this.dgvReportes.Location = new System.Drawing.Point(40, 25);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersVisible = false;
            this.dgvReportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReportes.RowTemplate.Height = 32;
            this.dgvReportes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(247, 249, 251);
            this.dgvReportes.Size = new System.Drawing.Size(1553, 689);
            this.dgvReportes.TabIndex = 6;

            // =========================================================
            // FrmReportes
            // =========================================================
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 1024);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlResumen);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmReportes";
            this.Text = "Reportes";

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlResumen.ResumeLayout(false);
            this.pnlResumen.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}