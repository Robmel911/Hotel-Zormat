namespace HotelZormat.UI.Formularios
{
    partial class FrmCrearReserva
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
        private System.Windows.Forms.TextBox txtBuscarHuesped;
        private System.Windows.Forms.TextBox txtBuscarHabitacion;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.ComboBox cmbTemporada;
        private System.Windows.Forms.Label lblNoches;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHuesped;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblTemporada;
        private System.Windows.Forms.Label lbltitulonoches;
        private System.Windows.Forms.Label lbltituloMonto;
        private System.Windows.Forms.Label lblEstadoSeleccionado;
        private System.Windows.Forms.ListBox lstHuespedesSugeridos;
        private System.Windows.Forms.ListBox lstHabitacionesSugeridas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider ep;

        // ---- Controles nuevos, solo decorativos ----
        private System.Windows.Forms.Panel pnlHeader;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBuscarHuesped = new System.Windows.Forms.TextBox();
            this.txtBuscarHabitacion = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.cmbTemporada = new System.Windows.Forms.ComboBox();
            this.lblNoches = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblHuesped = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.lbltitulonoches = new System.Windows.Forms.Label();
            this.lbltituloMonto = new System.Windows.Forms.Label();
            this.lblEstadoSeleccionado = new System.Windows.Forms.Label();
            this.lstHuespedesSugeridos = new System.Windows.Forms.ListBox();
            this.lstHabitacionesSugeridas = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarHuesped
            // 
            this.txtBuscarHuesped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarHuesped.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarHuesped.Location = new System.Drawing.Point(148, 113);
            this.txtBuscarHuesped.Name = "txtBuscarHuesped";
            this.txtBuscarHuesped.Size = new System.Drawing.Size(240, 34);
            this.txtBuscarHuesped.TabIndex = 2;
            this.txtBuscarHuesped.Click += new System.EventHandler(this.txtBuscarHuesped_Click);
            this.txtBuscarHuesped.TextChanged += new System.EventHandler(this.txtBuscarHuesped_TextChanged);
            // 
            // txtBuscarHabitacion
            // 
            this.txtBuscarHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarHabitacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarHabitacion.Location = new System.Drawing.Point(148, 180);
            this.txtBuscarHabitacion.Name = "txtBuscarHabitacion";
            this.txtBuscarHabitacion.Size = new System.Drawing.Size(240, 34);
            this.txtBuscarHabitacion.TabIndex = 4;
            this.txtBuscarHabitacion.Click += new System.EventHandler(this.txtBuscarHabitacion_Click);
            this.txtBuscarHabitacion.TextChanged += new System.EventHandler(this.txtBuscarHabitacion_TextChanged);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(148, 247);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(240, 33);
            this.dtpCheckIn.TabIndex = 6;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(148, 314);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(240, 33);
            this.dtpCheckOut.TabIndex = 8;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // cmbTemporada
            // 
            this.cmbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemporada.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTemporada.FormattingEnabled = true;
            this.cmbTemporada.Location = new System.Drawing.Point(148, 381);
            this.cmbTemporada.Name = "cmbTemporada";
            this.cmbTemporada.Size = new System.Drawing.Size(240, 33);
            this.cmbTemporada.TabIndex = 10;
            this.cmbTemporada.SelectedIndexChanged += new System.EventHandler(this.cmbTemporada_SelectedIndexChanged);
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNoches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNoches.Location = new System.Drawing.Point(148, 440);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(22, 25);
            this.lblNoches.TabIndex = 12;
            this.lblNoches.Text = "0";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lblMontoTotal.Location = new System.Drawing.Point(148, 472);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(28, 32);
            this.lblMontoTotal.TabIndex = 14;
            this.lblMontoTotal.Text = "0";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEstado.Location = new System.Drawing.Point(148, 518);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(96, 25);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Pendiente";
            // 
            // lblHuesped
            // 
            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHuesped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblHuesped.Location = new System.Drawing.Point(45, 118);
            this.lblHuesped.Name = "lblHuesped";
            this.lblHuesped.Size = new System.Drawing.Size(96, 25);
            this.lblHuesped.TabIndex = 1;
            this.lblHuesped.Text = "Huésped:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblHabitacion.Location = new System.Drawing.Point(45, 185);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(114, 25);
            this.lblHabitacion.TabIndex = 3;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblEntrada.Location = new System.Drawing.Point(45, 252);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(86, 25);
            this.lblEntrada.TabIndex = 5;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblSalida.Location = new System.Drawing.Point(45, 319);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(70, 25);
            this.lblSalida.TabIndex = 7;
            this.lblSalida.Text = "Salida:";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTemporada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTemporada.Location = new System.Drawing.Point(18, 386);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(117, 25);
            this.lblTemporada.TabIndex = 9;
            this.lblTemporada.Text = "Temporada:";
            // 
            // lbltitulonoches
            // 
            this.lbltitulonoches.AutoSize = true;
            this.lbltitulonoches.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbltitulonoches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lbltitulonoches.Location = new System.Drawing.Point(45, 440);
            this.lbltitulonoches.Name = "lbltitulonoches";
            this.lbltitulonoches.Size = new System.Drawing.Size(82, 25);
            this.lbltitulonoches.TabIndex = 11;
            this.lbltitulonoches.Text = "Noches:";
            // 
            // lbltituloMonto
            // 
            this.lbltituloMonto.AutoSize = true;
            this.lbltituloMonto.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbltituloMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lbltituloMonto.Location = new System.Drawing.Point(8, 476);
            this.lbltituloMonto.Name = "lbltituloMonto";
            this.lbltituloMonto.Size = new System.Drawing.Size(126, 25);
            this.lbltituloMonto.TabIndex = 13;
            this.lbltituloMonto.Text = "Monto Total:";
            // 
            // lblEstadoSeleccionado
            // 
            this.lblEstadoSeleccionado.AutoSize = true;
            this.lblEstadoSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEstadoSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblEstadoSeleccionado.Location = new System.Drawing.Point(45, 518);
            this.lblEstadoSeleccionado.Name = "lblEstadoSeleccionado";
            this.lblEstadoSeleccionado.Size = new System.Drawing.Size(76, 25);
            this.lblEstadoSeleccionado.TabIndex = 15;
            this.lblEstadoSeleccionado.Text = "Estado:";
            // 
            // lstHuespedesSugeridos
            // 
            this.lstHuespedesSugeridos.BackColor = System.Drawing.Color.White;
            this.lstHuespedesSugeridos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHuespedesSugeridos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstHuespedesSugeridos.FormattingEnabled = true;
            this.lstHuespedesSugeridos.ItemHeight = 25;
            this.lstHuespedesSugeridos.Location = new System.Drawing.Point(420, 113);
            this.lstHuespedesSugeridos.Name = "lstHuespedesSugeridos";
            this.lstHuespedesSugeridos.Size = new System.Drawing.Size(410, 427);
            this.lstHuespedesSugeridos.TabIndex = 17;
            this.lstHuespedesSugeridos.Visible = false;
            this.lstHuespedesSugeridos.DoubleClick += new System.EventHandler(this.lstHuespedesSugeridos_DoubleClick);
            // 
            // lstHabitacionesSugeridas
            // 
            this.lstHabitacionesSugeridas.BackColor = System.Drawing.Color.White;
            this.lstHabitacionesSugeridas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHabitacionesSugeridas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstHabitacionesSugeridas.FormattingEnabled = true;
            this.lstHabitacionesSugeridas.ItemHeight = 25;
            this.lstHabitacionesSugeridas.Location = new System.Drawing.Point(420, 113);
            this.lstHabitacionesSugeridas.Name = "lstHabitacionesSugeridas";
            this.lstHabitacionesSugeridas.Size = new System.Drawing.Size(410, 427);
            this.lstHabitacionesSugeridas.TabIndex = 18;
            this.lstHabitacionesSugeridas.Visible = false;
            this.lstHabitacionesSugeridas.DoubleClick += new System.EventHandler(this.lstHabitacionesSugeridas_DoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(420, 560);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 52);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Reserva";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCancelar.Location = new System.Drawing.Point(630, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 52);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1030, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // FrmCrearReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 650);
            this.Controls.Add(this.lblHuesped);
            this.Controls.Add(this.txtBuscarHuesped);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.txtBuscarHabitacion);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.lblTemporada);
            this.Controls.Add(this.cmbTemporada);
            this.Controls.Add(this.lbltitulonoches);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.lbltituloMonto);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblEstadoSeleccionado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lstHuespedesSugeridos);
            this.Controls.Add(this.lstHabitacionesSugeridas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}