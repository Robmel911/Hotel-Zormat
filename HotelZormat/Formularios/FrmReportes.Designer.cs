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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            // 
            // btnOcupacionDia
            // 
            this.btnOcupacionDia.BackColor = System.Drawing.Color.White;
            this.btnOcupacionDia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnOcupacionDia.FlatAppearance.BorderSize = 2;
            this.btnOcupacionDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnOcupacionDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcupacionDia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnOcupacionDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnOcupacionDia.Location = new System.Drawing.Point(570, 25);
            this.btnOcupacionDia.Name = "btnOcupacionDia";
            this.btnOcupacionDia.Size = new System.Drawing.Size(230, 44);
            this.btnOcupacionDia.TabIndex = 4;
            this.btnOcupacionDia.Text = "Ocupación del Día";
            this.btnOcupacionDia.UseVisualStyleBackColor = false;
            this.btnOcupacionDia.Click += new System.EventHandler(this.btnOcupacionDia_Click);
            // 
            // btnIngresosRango
            // 
            this.btnIngresosRango.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnIngresosRango.FlatAppearance.BorderSize = 0;
            this.btnIngresosRango.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnIngresosRango.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lblTotalIngresos.Location = new System.Drawing.Point(40, 20);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(216, 38);
            this.lblTotalIngresos.TabIndex = 0;
            this.lblTotalIngresos.Text = "Total: RD$ 0.00";
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReportes.ColumnHeadersHeight = 42;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportes.EnableHeadersVisualStyles = false;
            this.dgvReportes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.dgvReportes.Location = new System.Drawing.Point(40, 25);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.RowHeadersVisible = false;
            this.dgvReportes.RowHeadersWidth = 62;
            this.dgvReportes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReportes.RowTemplate.Height = 32;
            this.dgvReportes.Size = new System.Drawing.Size(1553, 689);
            this.dgvReportes.TabIndex = 6;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(105, 33);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(160, 33);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Value = new System.DateTime(2026, 7, 2, 0, 0, 0, 0);
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpRango_ValueChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(362, 33);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(160, 33);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.Value = new System.DateTime(2026, 8, 1, 0, 0, 0, 0);
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpRango_ValueChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblDesde.Location = new System.Drawing.Point(40, 38);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(71, 25);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblHasta.Location = new System.Drawing.Point(300, 38);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(67, 25);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblTituloReportes);
            this.pnlHeader.Controls.Add(this.lblSubtituloReportes);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1633, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTituloReportes
            // 
            this.lblTituloReportes.AutoSize = true;
            this.lblTituloReportes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloReportes.ForeColor = System.Drawing.Color.White;
            this.lblTituloReportes.Location = new System.Drawing.Point(40, 8);
            this.lblTituloReportes.Name = "lblTituloReportes";
            this.lblTituloReportes.Size = new System.Drawing.Size(170, 48);
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
            this.lblSubtituloReportes.Size = new System.Drawing.Size(422, 25);
            this.lblSubtituloReportes.TabIndex = 1;
            this.lblSubtituloReportes.Text = "Ocupación del día e ingresos por rango de fecha";
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.btnOcupacionDia);
            this.pnlFiltros.Controls.Add(this.btnIngresosRango);
            this.pnlFiltros.Controls.Add(this.pnlDividerFiltros);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 90);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1633, 110);
            this.pnlFiltros.TabIndex = 1;
            // 
            // pnlDividerFiltros
            // 
            this.pnlDividerFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.pnlDividerFiltros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDividerFiltros.Location = new System.Drawing.Point(0, 108);
            this.pnlDividerFiltros.Name = "pnlDividerFiltros";
            this.pnlDividerFiltros.Size = new System.Drawing.Size(1633, 2);
            this.pnlDividerFiltros.TabIndex = 6;
            // 
            // pnlResumen
            // 
            this.pnlResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlResumen.Controls.Add(this.lblTotalIngresos);
            this.pnlResumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResumen.Location = new System.Drawing.Point(0, 200);
            this.pnlResumen.Name = "pnlResumen";
            this.pnlResumen.Size = new System.Drawing.Size(1633, 70);
            this.pnlResumen.TabIndex = 2;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Controls.Add(this.dgvReportes);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 270);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(40, 25, 40, 40);
            this.pnlContenido.Size = new System.Drawing.Size(1633, 754);
            this.pnlContenido.TabIndex = 3;
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