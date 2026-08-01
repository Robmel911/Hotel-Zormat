namespace HotelZormat.UI.Formularios
{
    partial class FrmGestionFacturas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // ---- Controles originales (mismos nombres, para no romper el codebehind) ----
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnCerrar;

        // ---- Controles nuevos, solo decorativos/organizativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Panel pnlGrid;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dgvFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFacturas.ColumnHeadersHeight = 42;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.dgvFacturas.Location = new System.Drawing.Point(40, 25);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.RowHeadersWidth = 62;
            this.dgvFacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFacturas.RowTemplate.Height = 32;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(1283, 869);
            this.dgvFacturas.TabIndex = 0;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dgvFacturas_SelectionChanged);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnVerDetalle.Enabled = false;
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnVerDetalle.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalle.Location = new System.Drawing.Point(30, 30);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(220, 52);
            this.btnVerDetalle.TabIndex = 0;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnAnular.Enabled = false;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Location = new System.Drawing.Point(30, 96);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(220, 52);
            this.btnAnular.TabIndex = 1;
            this.btnAnular.Text = "Anular Factura";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCerrar.Location = new System.Drawing.Point(30, 852);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(220, 52);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1633, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(349, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Facturas";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(43, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(337, 25);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Consulta el detalle o anula una factura";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlAcciones.Controls.Add(this.btnVerDetalle);
            this.pnlAcciones.Controls.Add(this.btnAnular);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAcciones.Location = new System.Drawing.Point(1353, 90);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(280, 934);
            this.pnlAcciones.TabIndex = 1;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvFacturas);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 90);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(40, 25, 30, 40);
            this.pnlGrid.Size = new System.Drawing.Size(1353, 934);
            this.pnlGrid.TabIndex = 2;
            // 
            // FrmGestionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 1024);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmGestionFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Facturas";
            this.Load += new System.EventHandler(this.FrmGestionFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}