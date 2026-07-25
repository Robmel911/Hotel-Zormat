namespace HotelZormat.UI.Formularios
{
    partial class FrmCrearReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarHuesped
            // 
            this.txtBuscarHuesped.Location = new System.Drawing.Point(148, 93);
            this.txtBuscarHuesped.Name = "txtBuscarHuesped";
            this.txtBuscarHuesped.Size = new System.Drawing.Size(100, 26);
            this.txtBuscarHuesped.TabIndex = 0;
            this.txtBuscarHuesped.Click += new System.EventHandler(this.txtBuscarHuesped_Click);
            this.txtBuscarHuesped.TextChanged += new System.EventHandler(this.txtBuscarHuesped_TextChanged);
            // 
            // txtBuscarHabitacion
            // 
            this.txtBuscarHabitacion.Location = new System.Drawing.Point(148, 170);
            this.txtBuscarHabitacion.Name = "txtBuscarHabitacion";
            this.txtBuscarHabitacion.Size = new System.Drawing.Size(100, 26);
            this.txtBuscarHabitacion.TabIndex = 1;
            this.txtBuscarHabitacion.Click += new System.EventHandler(this.txtBuscarHabitacion_Click);
            this.txtBuscarHabitacion.TextChanged += new System.EventHandler(this.txtBuscarHabitacion_TextChanged);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(148, 253);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 26);
            this.dtpCheckIn.TabIndex = 2;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(148, 320);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 26);
            this.dtpCheckOut.TabIndex = 3;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // cmbTemporada
            // 
            this.cmbTemporada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemporada.FormattingEnabled = true;
            this.cmbTemporada.Location = new System.Drawing.Point(148, 406);
            this.cmbTemporada.Name = "cmbTemporada";
            this.cmbTemporada.Size = new System.Drawing.Size(121, 28);
            this.cmbTemporada.TabIndex = 4;
            this.cmbTemporada.SelectedIndexChanged += new System.EventHandler(this.cmbTemporada_SelectedIndexChanged);
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Location = new System.Drawing.Point(148, 465);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(18, 20);
            this.lblNoches.TabIndex = 5;
            this.lblNoches.Text = "0";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(148, 504);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(18, 20);
            this.lblMontoTotal.TabIndex = 6;
            this.lblMontoTotal.Text = "0";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(148, 557);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(81, 20);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Pendiente";
            // 
            // lblHuesped
            // 
            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Location = new System.Drawing.Point(64, 99);
            this.lblHuesped.Name = "lblHuesped";
            this.lblHuesped.Size = new System.Drawing.Size(78, 20);
            this.lblHuesped.TabIndex = 8;
            this.lblHuesped.Text = "Huesped:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(53, 176);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(89, 20);
            this.lblHabitacion.TabIndex = 9;
            this.lblHabitacion.Text = "Habitacion:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(64, 259);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(70, 20);
            this.lblEntrada.TabIndex = 10;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(64, 326);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(57, 20);
            this.lblSalida.TabIndex = 11;
            this.lblSalida.Text = "Salida:";
            // 
            // lblTemporada
            // 
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.Location = new System.Drawing.Point(48, 414);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(94, 20);
            this.lblTemporada.TabIndex = 12;
            this.lblTemporada.Text = "Temporada:";
            // 
            // lbltitulonoches
            // 
            this.lbltitulonoches.AutoSize = true;
            this.lbltitulonoches.Location = new System.Drawing.Point(64, 465);
            this.lbltitulonoches.Name = "lbltitulonoches";
            this.lbltitulonoches.Size = new System.Drawing.Size(67, 20);
            this.lbltitulonoches.TabIndex = 13;
            this.lbltitulonoches.Text = "Noches:";
            // 
            // lbltituloMonto
            // 
            this.lbltituloMonto.AutoSize = true;
            this.lbltituloMonto.Location = new System.Drawing.Point(45, 504);
            this.lbltituloMonto.Name = "lbltituloMonto";
            this.lbltituloMonto.Size = new System.Drawing.Size(97, 20);
            this.lbltituloMonto.TabIndex = 14;
            this.lbltituloMonto.Text = "Monto Total:";
            // 
            // lblEstadoSeleccionado
            // 
            this.lblEstadoSeleccionado.AutoSize = true;
            this.lblEstadoSeleccionado.Location = new System.Drawing.Point(64, 557);
            this.lblEstadoSeleccionado.Name = "lblEstadoSeleccionado";
            this.lblEstadoSeleccionado.Size = new System.Drawing.Size(64, 20);
            this.lblEstadoSeleccionado.TabIndex = 15;
            this.lblEstadoSeleccionado.Text = "Estado:";
            // 
            // lstHuespedesSugeridos
            // 
            this.lstHuespedesSugeridos.FormattingEnabled = true;
            this.lstHuespedesSugeridos.ItemHeight = 20;
            this.lstHuespedesSugeridos.Location = new System.Drawing.Point(399, 93);
            this.lstHuespedesSugeridos.Name = "lstHuespedesSugeridos";
            this.lstHuespedesSugeridos.Size = new System.Drawing.Size(429, 464);
            this.lstHuespedesSugeridos.TabIndex = 16;
            this.lstHuespedesSugeridos.Visible = false;
            this.lstHuespedesSugeridos.DoubleClick += new System.EventHandler(this.lstHuespedesSugeridos_DoubleClick);
            // 
            // lstHabitacionesSugeridas
            // 
            this.lstHabitacionesSugeridas.FormattingEnabled = true;
            this.lstHabitacionesSugeridas.ItemHeight = 20;
            this.lstHabitacionesSugeridas.Location = new System.Drawing.Point(399, 93);
            this.lstHabitacionesSugeridas.Name = "lstHabitacionesSugeridas";
            this.lstHabitacionesSugeridas.Size = new System.Drawing.Size(429, 464);
            this.lstHabitacionesSugeridas.TabIndex = 17;
            this.lstHabitacionesSugeridas.Visible = false;
            this.lstHabitacionesSugeridas.DoubleClick += new System.EventHandler(this.lstHabitacionesSugeridas_DoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(877, 461);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 63);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Confirmar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Crear Reserva";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(877, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 63);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // FrmCrearReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 605);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstHabitacionesSugeridas);
            this.Controls.Add(this.lstHuespedesSugeridos);
            this.Controls.Add(this.lblEstadoSeleccionado);
            this.Controls.Add(this.lbltituloMonto);
            this.Controls.Add(this.lbltitulonoches);
            this.Controls.Add(this.lblTemporada);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblHuesped);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.cmbTemporada);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtBuscarHabitacion);
            this.Controls.Add(this.txtBuscarHuesped);
            this.Name = "FrmCrearReserva";
            this.Text = "FrmReserva";
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}