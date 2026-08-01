namespace HotelZormat.UI.Formularios
{
    partial class FrmGestionHabitaciones
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtBuscarNumero = new System.Windows.Forms.TextBox();
            this.cboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.lblFiltroEstado = new System.Windows.Forms.Label();
            this.lblNuevoEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSeleccionTitulo = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.flpHabitaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timerRefresco = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblNumero.Location = new System.Drawing.Point(30, 36);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(91, 25);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // txtBuscarNumero
            // 
            this.txtBuscarNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNumero.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscarNumero.Location = new System.Drawing.Point(123, 31);
            this.txtBuscarNumero.Name = "txtBuscarNumero";
            this.txtBuscarNumero.Size = new System.Drawing.Size(140, 33);
            this.txtBuscarNumero.TabIndex = 1;
            this.txtBuscarNumero.TextChanged += new System.EventHandler(this.txtBuscarNumero_TextChanged);
            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboFiltroEstado.FormattingEnabled = true;
            this.cboFiltroEstado.Location = new System.Drawing.Point(498, 28);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Size = new System.Drawing.Size(160, 33);
            this.cboFiltroEstado.TabIndex = 2;
            this.cboFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cboFiltroEstado_SelectedIndexChanged);
            // 
            // lblFiltroEstado
            // 
            this.lblFiltroEstado.AutoSize = true;
            this.lblFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblFiltroEstado.Location = new System.Drawing.Point(311, 31);
            this.lblFiltroEstado.Name = "lblFiltroEstado";
            this.lblFiltroEstado.Size = new System.Drawing.Size(171, 25);
            this.lblFiltroEstado.TabIndex = 3;
            this.lblFiltroEstado.Text = "Filtrar por estado:";
            // 
            // lblNuevoEstado
            // 
            this.lblNuevoEstado.AutoSize = true;
            this.lblNuevoEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNuevoEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblNuevoEstado.Location = new System.Drawing.Point(24, 147);
            this.lblNuevoEstado.Name = "lblNuevoEstado";
            this.lblNuevoEstado.Size = new System.Drawing.Size(140, 25);
            this.lblNuevoEstado.TabIndex = 2;
            this.lblNuevoEstado.Text = "Nuevo estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(24, 174);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(240, 36);
            this.cboEstado.TabIndex = 3;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Location = new System.Drawing.Point(24, 230);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(240, 52);
            this.btnCambiarEstado.TabIndex = 4;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblSeleccionTitulo);
            this.groupBox1.Controls.Add(this.lblSeleccion);
            this.groupBox1.Controls.Add(this.lblNuevoEstado);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.btnCambiarEstado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(212)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 850);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitación Seleccionada";
            // 
            // lblSeleccionTitulo
            // 
            this.lblSeleccionTitulo.AutoSize = true;
            this.lblSeleccionTitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(148)))), ((int)(((byte)(158)))));
            this.lblSeleccionTitulo.Location = new System.Drawing.Point(24, 34);
            this.lblSeleccionTitulo.Name = "lblSeleccionTitulo";
            this.lblSeleccionTitulo.Size = new System.Drawing.Size(114, 23);
            this.lblSeleccionTitulo.TabIndex = 0;
            this.lblSeleccionTitulo.Text = "HABITACIÓN";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblSeleccion.Location = new System.Drawing.Point(24, 56);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(26, 21);
            this.lblSeleccion.TabIndex = 1;
            this.lblSeleccion.Text = "—";
            // 
            // flpHabitaciones
            // 
            this.flpHabitaciones.AutoScroll = true;
            this.flpHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.flpHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHabitaciones.Location = new System.Drawing.Point(300, 174);
            this.flpHabitaciones.Name = "flpHabitaciones";
            this.flpHabitaciones.Padding = new System.Windows.Forms.Padding(30);
            this.flpHabitaciones.Size = new System.Drawing.Size(1333, 850);
            this.flpHabitaciones.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtBuscarNumero);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.lblFiltroEstado);
            this.groupBox2.Controls.Add(this.cboFiltroEstado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(212)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1633, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // timerRefresco
            // 
            this.timerRefresco.Enabled = true;
            this.timerRefresco.Interval = 500;
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
            this.lblTitulo.Size = new System.Drawing.Size(428, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Habitaciones";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(43, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(288, 25);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Tablero de estado en tiempo real";
            // 
            // FrmGestionHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 1024);
            this.Controls.Add(this.flpHabitaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pnlHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionHabitaciones";
            this.Text = "Gestión de Habitaciones";
            this.Load += new System.EventHandler(this.FrmGestionHabitaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtBuscarNumero;
        private System.Windows.Forms.ComboBox cboFiltroEstado;
        private System.Windows.Forms.Label lblFiltroEstado;
        private System.Windows.Forms.Label lblNuevoEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.FlowLayoutPanel flpHabitaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timerRefresco;

        // ---- Controles nuevos, solo decorativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblSeleccionTitulo;
    }
}