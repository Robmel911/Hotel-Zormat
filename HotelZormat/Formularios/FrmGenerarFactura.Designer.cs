namespace HotelZormat.UI.Formularios
{
    partial class FrmGenerarFactura
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
        private System.Windows.Forms.Label lblTituloHabitacion;
        private System.Windows.Forms.Label lblHabitacion;

        private System.Windows.Forms.Label lblTituloHuesped;
        private System.Windows.Forms.Label lblHuesped;

        private System.Windows.Forms.Label lblTituloCheckIn;
        private System.Windows.Forms.Label lblCheckIn;

        private System.Windows.Forms.Label lblTituloCheckOut;
        private System.Windows.Forms.Label lblCheckOut;

        private System.Windows.Forms.Label lblTituloNoches;
        private System.Windows.Forms.Label lblNoches;

        private System.Windows.Forms.Label lblTituloFormaPago;
        private System.Windows.Forms.ComboBox cmbFormaPago;

        private System.Windows.Forms.Button btnAgregarServicio;

        private System.Windows.Forms.GroupBox grpDesglose;
        private System.Windows.Forms.Label lblTituloCostoReserva;
        private System.Windows.Forms.Label lblCostoReserva;
        private System.Windows.Forms.Label lblTituloConsumoServicios;
        private System.Windows.Forms.Label lblConsumoServicios;
        private System.Windows.Forms.Label lblTituloSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTituloITBIS;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Label lblTituloPropinaLegal;
        private System.Windows.Forms.Label lblPropinaLegal;
        private System.Windows.Forms.Label lblTituloMontoTotal;
        private System.Windows.Forms.Label lblMontoTotal;

        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnCancelar;

        // ---- Controles nuevos, solo decorativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloVentana;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlTotal;

        private void InitializeComponent()
        {
            this.lblTituloHabitacion = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblTituloHuesped = new System.Windows.Forms.Label();
            this.lblHuesped = new System.Windows.Forms.Label();
            this.lblTituloCheckIn = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblTituloCheckOut = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblTituloNoches = new System.Windows.Forms.Label();
            this.lblNoches = new System.Windows.Forms.Label();
            this.lblTituloFormaPago = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.grpDesglose = new System.Windows.Forms.GroupBox();
            this.lblTituloCostoReserva = new System.Windows.Forms.Label();
            this.lblCostoReserva = new System.Windows.Forms.Label();
            this.lblTituloConsumoServicios = new System.Windows.Forms.Label();
            this.lblConsumoServicios = new System.Windows.Forms.Label();
            this.lblTituloSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTituloITBIS = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblTituloPropinaLegal = new System.Windows.Forms.Label();
            this.lblPropinaLegal = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTituloMontoTotal = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.grpDesglose.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloHabitacion
            // 
            this.lblTituloHabitacion.AutoSize = true;
            this.lblTituloHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloHabitacion.Location = new System.Drawing.Point(30, 90);
            this.lblTituloHabitacion.Name = "lblTituloHabitacion";
            this.lblTituloHabitacion.Size = new System.Drawing.Size(110, 25);
            this.lblTituloHabitacion.TabIndex = 0;
            this.lblTituloHabitacion.Text = "Habitación:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHabitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblHabitacion.Location = new System.Drawing.Point(140, 90);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(42, 25);
            this.lblHabitacion.TabIndex = 1;
            this.lblHabitacion.Text = "101";
            // 
            // lblTituloHuesped
            // 
            this.lblTituloHuesped.AutoSize = true;
            this.lblTituloHuesped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloHuesped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloHuesped.Location = new System.Drawing.Point(330, 90);
            this.lblTituloHuesped.Name = "lblTituloHuesped";
            this.lblTituloHuesped.Size = new System.Drawing.Size(92, 25);
            this.lblTituloHuesped.TabIndex = 2;
            this.lblTituloHuesped.Text = "Huésped:";
            // 
            // lblHuesped
            // 
            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHuesped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblHuesped.Location = new System.Drawing.Point(420, 90);
            this.lblHuesped.Name = "lblHuesped";
            this.lblHuesped.Size = new System.Drawing.Size(149, 25);
            this.lblHuesped.TabIndex = 3;
            this.lblHuesped.Text = "Nombre Apellido";
            // 
            // lblTituloCheckIn
            // 
            this.lblTituloCheckIn.AutoSize = true;
            this.lblTituloCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloCheckIn.Location = new System.Drawing.Point(30, 122);
            this.lblTituloCheckIn.Name = "lblTituloCheckIn";
            this.lblTituloCheckIn.Size = new System.Drawing.Size(91, 25);
            this.lblTituloCheckIn.TabIndex = 4;
            this.lblTituloCheckIn.Text = "Check-In:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCheckIn.Location = new System.Drawing.Point(140, 122);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(106, 25);
            this.lblCheckIn.TabIndex = 5;
            this.lblCheckIn.Text = "00/00/0000";
            // 
            // lblTituloCheckOut
            // 
            this.lblTituloCheckOut.AutoSize = true;
            this.lblTituloCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloCheckOut.Location = new System.Drawing.Point(330, 122);
            this.lblTituloCheckOut.Name = "lblTituloCheckOut";
            this.lblTituloCheckOut.Size = new System.Drawing.Size(106, 25);
            this.lblTituloCheckOut.TabIndex = 6;
            this.lblTituloCheckOut.Text = "Check-Out:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCheckOut.Location = new System.Drawing.Point(420, 122);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(106, 25);
            this.lblCheckOut.TabIndex = 7;
            this.lblCheckOut.Text = "00/00/0000";
            // 
            // lblTituloNoches
            // 
            this.lblTituloNoches.AutoSize = true;
            this.lblTituloNoches.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloNoches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloNoches.Location = new System.Drawing.Point(30, 154);
            this.lblTituloNoches.Name = "lblTituloNoches";
            this.lblTituloNoches.Size = new System.Drawing.Size(80, 25);
            this.lblTituloNoches.TabIndex = 8;
            this.lblTituloNoches.Text = "Noches:";
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNoches.Location = new System.Drawing.Point(140, 154);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(22, 25);
            this.lblNoches.TabIndex = 9;
            this.lblNoches.Text = "0";
            // 
            // lblTituloFormaPago
            // 
            this.lblTituloFormaPago.AutoSize = true;
            this.lblTituloFormaPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloFormaPago.Location = new System.Drawing.Point(30, 216);
            this.lblTituloFormaPago.Name = "lblTituloFormaPago";
            this.lblTituloFormaPago.Size = new System.Drawing.Size(144, 25);
            this.lblTituloFormaPago.TabIndex = 10;
            this.lblTituloFormaPago.Text = "Forma de Pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFormaPago.Location = new System.Drawing.Point(175, 212);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(165, 33);
            this.cmbFormaPago.TabIndex = 11;
            this.cmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPago_SelectedIndexChanged);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.Color.White;
            this.btnAgregarServicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnAgregarServicio.FlatAppearance.BorderSize = 2;
            this.btnAgregarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnAgregarServicio.Location = new System.Drawing.Point(360, 210);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(230, 34);
            this.btnAgregarServicio.TabIndex = 12;
            this.btnAgregarServicio.Text = "+  Agregar Servicio";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // grpDesglose
            // 
            this.grpDesglose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.grpDesglose.Controls.Add(this.lblTituloCostoReserva);
            this.grpDesglose.Controls.Add(this.lblCostoReserva);
            this.grpDesglose.Controls.Add(this.lblTituloConsumoServicios);
            this.grpDesglose.Controls.Add(this.lblConsumoServicios);
            this.grpDesglose.Controls.Add(this.lblTituloSubtotal);
            this.grpDesglose.Controls.Add(this.lblSubtotal);
            this.grpDesglose.Controls.Add(this.lblTituloITBIS);
            this.grpDesglose.Controls.Add(this.lblITBIS);
            this.grpDesglose.Controls.Add(this.lblTituloPropinaLegal);
            this.grpDesglose.Controls.Add(this.lblPropinaLegal);
            this.grpDesglose.Controls.Add(this.pnlTotal);
            this.grpDesglose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDesglose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.grpDesglose.Location = new System.Drawing.Point(30, 262);
            this.grpDesglose.Name = "grpDesglose";
            this.grpDesglose.Size = new System.Drawing.Size(560, 258);
            this.grpDesglose.TabIndex = 13;
            this.grpDesglose.TabStop = false;
            this.grpDesglose.Text = "Desglose (vista previa)";
            // 
            // lblTituloCostoReserva
            // 
            this.lblTituloCostoReserva.AutoSize = true;
            this.lblTituloCostoReserva.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloCostoReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblTituloCostoReserva.Location = new System.Drawing.Point(25, 42);
            this.lblTituloCostoReserva.Name = "lblTituloCostoReserva";
            this.lblTituloCostoReserva.Size = new System.Drawing.Size(128, 25);
            this.lblTituloCostoReserva.TabIndex = 0;
            this.lblTituloCostoReserva.Text = "Costo Reserva:";
            // 
            // lblCostoReserva
            // 
            this.lblCostoReserva.AutoSize = true;
            this.lblCostoReserva.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCostoReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblCostoReserva.Location = new System.Drawing.Point(476, 42);
            this.lblCostoReserva.Name = "lblCostoReserva";
            this.lblCostoReserva.Size = new System.Drawing.Size(80, 25);
            this.lblCostoReserva.TabIndex = 1;
            this.lblCostoReserva.Text = "RD$0.00";
            // 
            // lblTituloConsumoServicios
            // 
            this.lblTituloConsumoServicios.AutoSize = true;
            this.lblTituloConsumoServicios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloConsumoServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblTituloConsumoServicios.Location = new System.Drawing.Point(25, 74);
            this.lblTituloConsumoServicios.Name = "lblTituloConsumoServicios";
            this.lblTituloConsumoServicios.Size = new System.Drawing.Size(167, 25);
            this.lblTituloConsumoServicios.TabIndex = 2;
            this.lblTituloConsumoServicios.Text = "Consumo Servicios:";
            // 
            // lblConsumoServicios
            // 
            this.lblConsumoServicios.AutoSize = true;
            this.lblConsumoServicios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConsumoServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblConsumoServicios.Location = new System.Drawing.Point(476, 74);
            this.lblConsumoServicios.Name = "lblConsumoServicios";
            this.lblConsumoServicios.Size = new System.Drawing.Size(80, 25);
            this.lblConsumoServicios.TabIndex = 3;
            this.lblConsumoServicios.Text = "RD$0.00";
            // 
            // lblTituloSubtotal
            // 
            this.lblTituloSubtotal.AutoSize = true;
            this.lblTituloSubtotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblTituloSubtotal.Location = new System.Drawing.Point(25, 106);
            this.lblTituloSubtotal.Name = "lblTituloSubtotal";
            this.lblTituloSubtotal.Size = new System.Drawing.Size(83, 25);
            this.lblTituloSubtotal.TabIndex = 4;
            this.lblTituloSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSubtotal.Location = new System.Drawing.Point(475, 106);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(80, 25);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "RD$0.00";
            // 
            // lblTituloITBIS
            // 
            this.lblTituloITBIS.AutoSize = true;
            this.lblTituloITBIS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloITBIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblTituloITBIS.Location = new System.Drawing.Point(25, 138);
            this.lblTituloITBIS.Name = "lblTituloITBIS";
            this.lblTituloITBIS.Size = new System.Drawing.Size(105, 25);
            this.lblTituloITBIS.TabIndex = 6;
            this.lblTituloITBIS.Text = "ITBIS (18%):";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblITBIS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblITBIS.Location = new System.Drawing.Point(474, 138);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(80, 25);
            this.lblITBIS.TabIndex = 7;
            this.lblITBIS.Text = "RD$0.00";
            // 
            // lblTituloPropinaLegal
            // 
            this.lblTituloPropinaLegal.AutoSize = true;
            this.lblTituloPropinaLegal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTituloPropinaLegal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblTituloPropinaLegal.Location = new System.Drawing.Point(25, 170);
            this.lblTituloPropinaLegal.Name = "lblTituloPropinaLegal";
            this.lblTituloPropinaLegal.Size = new System.Drawing.Size(173, 25);
            this.lblTituloPropinaLegal.TabIndex = 8;
            this.lblTituloPropinaLegal.Text = "Propina Legal (10%):";
            // 
            // lblPropinaLegal
            // 
            this.lblPropinaLegal.AutoSize = true;
            this.lblPropinaLegal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPropinaLegal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPropinaLegal.Location = new System.Drawing.Point(475, 170);
            this.lblPropinaLegal.Name = "lblPropinaLegal";
            this.lblPropinaLegal.Size = new System.Drawing.Size(80, 25);
            this.lblPropinaLegal.TabIndex = 9;
            this.lblPropinaLegal.Text = "RD$0.00";
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pnlTotal.Controls.Add(this.lblTituloMontoTotal);
            this.pnlTotal.Controls.Add(this.lblMontoTotal);
            this.pnlTotal.Location = new System.Drawing.Point(15, 202);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(530, 46);
            this.pnlTotal.TabIndex = 0;
            // 
            // lblTituloMontoTotal
            // 
            this.lblTituloMontoTotal.AutoSize = true;
            this.lblTituloMontoTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTituloMontoTotal.ForeColor = System.Drawing.Color.White;
            this.lblTituloMontoTotal.Location = new System.Drawing.Point(20, 12);
            this.lblTituloMontoTotal.Name = "lblTituloMontoTotal";
            this.lblTituloMontoTotal.Size = new System.Drawing.Size(174, 30);
            this.lblTituloMontoTotal.TabIndex = 0;
            this.lblTituloMontoTotal.Text = "MONTO TOTAL:";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.White;
            this.lblMontoTotal.Location = new System.Drawing.Point(390, 11);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(111, 32);
            this.lblMontoTotal.TabIndex = 1;
            this.lblMontoTotal.Text = "RD$0.00";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnGenerarFactura.FlatAppearance.BorderSize = 0;
            this.btnGenerarFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerarFactura.ForeColor = System.Drawing.Color.White;
            this.btnGenerarFactura.Location = new System.Drawing.Point(300, 540);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(160, 46);
            this.btnGenerarFactura.TabIndex = 14;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCancelar.Location = new System.Drawing.Point(470, 540);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 46);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblTituloVentana);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(620, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(30, 20);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(240, 41);
            this.lblTituloVentana.TabIndex = 0;
            this.lblTituloVentana.Text = "Generar Factura";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.pnlDivider.Location = new System.Drawing.Point(30, 190);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(560, 2);
            this.pnlDivider.TabIndex = 1;
            // 
            // FrmGenerarFactura
            // 
            this.AcceptButton = this.btnGenerarFactura;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(620, 620);
            this.Controls.Add(this.lblTituloHabitacion);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblTituloHuesped);
            this.Controls.Add(this.lblHuesped);
            this.Controls.Add(this.lblTituloCheckIn);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblTituloCheckOut);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblTituloNoches);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.pnlDivider);
            this.Controls.Add(this.lblTituloFormaPago);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.grpDesglose);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGenerarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar Factura";
            this.Load += new System.EventHandler(this.FrmGenerarFactura_Load);
            this.grpDesglose.ResumeLayout(false);
            this.grpDesglose.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}