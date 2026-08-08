namespace HotelZormat.UI.Formularios
{
    partial class FrmGestionReservas
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

        #region Windows Form Designer generated code

        // ---- Controles originales (mismos nombres, para no romper el codebehind) ----
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnVerProximas7Dias;
        private System.Windows.Forms.Button btnVerTodas;
        private System.Windows.Forms.Button btnCheckOut;

        // ---- Controles nuevos, solo decorativos/organizativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Label lblSeccionReserva;
        private System.Windows.Forms.Label lblSeccionEstadia;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlFiltroReservas;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnVerProximas7Dias = new System.Windows.Forms.Button();
            this.btnVerTodas = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.lblSeccionReserva = new System.Windows.Forms.Label();
            this.lblSeccionEstadia = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlFiltroReservas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlFiltroReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.dgvReservas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.ColumnHeadersHeight = 42;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservas.EnableHeadersVisualStyles = false;
            this.dgvReservas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.dgvReservas.Location = new System.Drawing.Point(40, 84);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersVisible = false;
            this.dgvReservas.RowHeadersWidth = 62;
            this.dgvReservas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReservas.RowTemplate.Height = 32;
            this.dgvReservas.Size = new System.Drawing.Size(1283, 810);
            this.dgvReservas.TabIndex = 1;
            this.dgvReservas.SelectionChanged += new System.EventHandler(this.dgvReservas_SelectionChanged);
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnNuevaReserva.FlatAppearance.BorderSize = 0;
            this.btnNuevaReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnNuevaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaReserva.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevaReserva.ForeColor = System.Drawing.Color.White;
            this.btnNuevaReserva.Location = new System.Drawing.Point(30, 42);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(220, 52);
            this.btnNuevaReserva.TabIndex = 1;
            this.btnNuevaReserva.Text = "+  Nueva Reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = false;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(78)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(30, 108);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(220, 52);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar Reserva";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(30, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(220, 52);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar Reserva";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.White;
            this.btnCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCheckIn.FlatAppearance.BorderSize = 2;
            this.btnCheckIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCheckIn.Location = new System.Drawing.Point(30, 274);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(220, 52);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnVerProximas7Dias
            // 
            this.btnVerProximas7Dias.BackColor = System.Drawing.Color.White;
            this.btnVerProximas7Dias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnVerProximas7Dias.FlatAppearance.BorderSize = 2;
            this.btnVerProximas7Dias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnVerProximas7Dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProximas7Dias.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerProximas7Dias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnVerProximas7Dias.Location = new System.Drawing.Point(203, 10);
            this.btnVerProximas7Dias.Name = "btnVerProximas7Dias";
            this.btnVerProximas7Dias.Size = new System.Drawing.Size(220, 44);
            this.btnVerProximas7Dias.TabIndex = 1;
            this.btnVerProximas7Dias.Text = "Próximos 7 Días";
            this.btnVerProximas7Dias.UseVisualStyleBackColor = false;
            this.btnVerProximas7Dias.Click += new System.EventHandler(this.btnVerProximas7Dias_Click);
            // 
            // btnVerTodas
            // 
            this.btnVerTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnVerTodas.FlatAppearance.BorderSize = 0;
            this.btnVerTodas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnVerTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodas.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerTodas.ForeColor = System.Drawing.Color.White;
            this.btnVerTodas.Location = new System.Drawing.Point(8, 10);
            this.btnVerTodas.Name = "btnVerTodas";
            this.btnVerTodas.Size = new System.Drawing.Size(180, 44);
            this.btnVerTodas.TabIndex = 0;
            this.btnVerTodas.Text = "Ver Todas";
            this.btnVerTodas.UseVisualStyleBackColor = false;
            this.btnVerTodas.Click += new System.EventHandler(this.btnVerTodas_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(30, 340);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(220, 52);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check-Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
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
            this.lblTitulo.Location = new System.Drawing.Point(40, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(356, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Reservas";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(43, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(380, 25);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Crea, confirma y gestiona el flujo de estadía";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlAcciones.Controls.Add(this.lblSeccionReserva);
            this.pnlAcciones.Controls.Add(this.btnNuevaReserva);
            this.pnlAcciones.Controls.Add(this.btnConfirmar);
            this.pnlAcciones.Controls.Add(this.btnCancelar);
            this.pnlAcciones.Controls.Add(this.lblSeccionEstadia);
            this.pnlAcciones.Controls.Add(this.btnCheckIn);
            this.pnlAcciones.Controls.Add(this.btnCheckOut);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAcciones.Location = new System.Drawing.Point(1353, 90);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(280, 934);
            this.pnlAcciones.TabIndex = 1;
            // 
            // lblSeccionReserva
            // 
            this.lblSeccionReserva.AutoSize = true;
            this.lblSeccionReserva.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccionReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.lblSeccionReserva.Location = new System.Drawing.Point(30, 17);
            this.lblSeccionReserva.Name = "lblSeccionReserva";
            this.lblSeccionReserva.Size = new System.Drawing.Size(82, 23);
            this.lblSeccionReserva.TabIndex = 0;
            this.lblSeccionReserva.Text = "RESERVA";
            // 
            // lblSeccionEstadia
            // 
            this.lblSeccionEstadia.AutoSize = true;
            this.lblSeccionEstadia.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSeccionEstadia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.lblSeccionEstadia.Location = new System.Drawing.Point(30, 248);
            this.lblSeccionEstadia.Name = "lblSeccionEstadia";
            this.lblSeccionEstadia.Size = new System.Drawing.Size(163, 23);
            this.lblSeccionEstadia.TabIndex = 4;
            this.lblSeccionEstadia.Text = "FLUJO DE ESTADÍA";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvReservas);
            this.pnlGrid.Controls.Add(this.pnlFiltroReservas);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 90);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(40, 20, 30, 40);
            this.pnlGrid.Size = new System.Drawing.Size(1353, 934);
            this.pnlGrid.TabIndex = 2;
            // 
            // pnlFiltroReservas
            // 
            this.pnlFiltroReservas.BackColor = System.Drawing.Color.White;
            this.pnlFiltroReservas.Controls.Add(this.btnVerTodas);
            this.pnlFiltroReservas.Controls.Add(this.btnVerProximas7Dias);
            this.pnlFiltroReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltroReservas.Location = new System.Drawing.Point(40, 20);
            this.pnlFiltroReservas.Name = "pnlFiltroReservas";
            this.pnlFiltroReservas.Size = new System.Drawing.Size(1283, 64);
            this.pnlFiltroReservas.TabIndex = 0;
            // 
            // FrmGestionReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 1024);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmGestionReservas";
            this.Text = "Gestión de Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlAcciones.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlFiltroReservas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}