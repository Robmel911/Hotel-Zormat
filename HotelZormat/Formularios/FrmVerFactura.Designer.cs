namespace HotelZormat.UI.Formularios
{
    partial class FrmVerFactura
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

        // ---- Controles ----

        // Encabezado (nuevo, decorativo)
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblNombreHotelFactura;
        private System.Windows.Forms.Label lblSubtituloFactura;

        private System.Windows.Forms.Label lblTituloNCF;
        private System.Windows.Forms.Label lblNCF;

        private System.Windows.Forms.Label lblTituloEstado;
        private System.Windows.Forms.Label lblEstado;

        // Tarjeta de información general (nuevo contenedor)
        private System.Windows.Forms.Panel pnlInfoGeneral;

        private System.Windows.Forms.Label lblTituloHabitacion;
        private System.Windows.Forms.Label lblHabitacion;

        private System.Windows.Forms.Label lblTituloHuesped;
        private System.Windows.Forms.Label lblHuesped;

        private System.Windows.Forms.Label lblTituloDocumento;
        private System.Windows.Forms.Label lblDocumento;

        private System.Windows.Forms.Label lblTituloCheckIn;
        private System.Windows.Forms.Label lblCheckIn;

        private System.Windows.Forms.Label lblTituloCheckOut;
        private System.Windows.Forms.Label lblCheckOut;

        private System.Windows.Forms.Label lblTituloNoches;
        private System.Windows.Forms.Label lblNoches;

        private System.Windows.Forms.Label lblTituloFechaEmision;
        private System.Windows.Forms.Label lblFechaEmision;

        private System.Windows.Forms.Label lblTituloFormaPago;
        private System.Windows.Forms.Label lblFormaPago;

        private System.Windows.Forms.GroupBox grpDesglose;
        private System.Windows.Forms.Label lblTituloSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTituloITBIS;
        private System.Windows.Forms.Label lblITBIS;
        private System.Windows.Forms.Label lblTituloPropinaLegal;
        private System.Windows.Forms.Label lblPropinaLegal;

        // Franja de total destacada (nuevo contenedor)
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTituloMontoTotal;
        private System.Windows.Forms.Label lblMontoTotal;

        private System.Windows.Forms.Button btnCerrar;

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblNombreHotelFactura = new System.Windows.Forms.Label();
            this.lblSubtituloFactura = new System.Windows.Forms.Label();
            this.lblTituloNCF = new System.Windows.Forms.Label();
            this.lblNCF = new System.Windows.Forms.Label();
            this.lblTituloEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();

            this.pnlInfoGeneral = new System.Windows.Forms.Panel();
            this.lblTituloHabitacion = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblTituloHuesped = new System.Windows.Forms.Label();
            this.lblHuesped = new System.Windows.Forms.Label();
            this.lblTituloDocumento = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblTituloCheckIn = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblTituloCheckOut = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblTituloNoches = new System.Windows.Forms.Label();
            this.lblNoches = new System.Windows.Forms.Label();
            this.lblTituloFechaEmision = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblTituloFormaPago = new System.Windows.Forms.Label();
            this.lblFormaPago = new System.Windows.Forms.Label();

            this.grpDesglose = new System.Windows.Forms.GroupBox();
            this.lblTituloSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTituloITBIS = new System.Windows.Forms.Label();
            this.lblITBIS = new System.Windows.Forms.Label();
            this.lblTituloPropinaLegal = new System.Windows.Forms.Label();
            this.lblPropinaLegal = new System.Windows.Forms.Label();

            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTituloMontoTotal = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();

            this.btnCerrar = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlInfoGeneral.SuspendLayout();
            this.grpDesglose.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // pnlHeader
            // =========================================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(726, 100);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblNombreHotelFactura);
            this.pnlHeader.Controls.Add(this.lblSubtituloFactura);
            this.pnlHeader.Controls.Add(this.lblTituloNCF);
            this.pnlHeader.Controls.Add(this.lblNCF);
            this.pnlHeader.Controls.Add(this.lblTituloEstado);
            this.pnlHeader.Controls.Add(this.lblEstado);

            // 
            // lblNombreHotelFactura
            // 
            this.lblNombreHotelFactura.AutoSize = true;
            this.lblNombreHotelFactura.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombreHotelFactura.ForeColor = System.Drawing.Color.White;
            this.lblNombreHotelFactura.Location = new System.Drawing.Point(30, 18);
            this.lblNombreHotelFactura.Name = "lblNombreHotelFactura";
            this.lblNombreHotelFactura.Size = new System.Drawing.Size(230, 30);
            this.lblNombreHotelFactura.TabIndex = 0;
            this.lblNombreHotelFactura.Text = "HOTEL ARRECIFE";

            // 
            // lblSubtituloFactura
            // 
            this.lblSubtituloFactura.AutoSize = true;
            this.lblSubtituloFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblSubtituloFactura.ForeColor = System.Drawing.Color.FromArgb(160, 180, 200);
            this.lblSubtituloFactura.Location = new System.Drawing.Point(32, 54);
            this.lblSubtituloFactura.Name = "lblSubtituloFactura";
            this.lblSubtituloFactura.Size = new System.Drawing.Size(130, 20);
            this.lblSubtituloFactura.TabIndex = 1;
            this.lblSubtituloFactura.Text = "Detalle de Factura";

            // 
            // lblTituloNCF
            // 
            this.lblTituloNCF.AutoSize = true;
            this.lblTituloNCF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloNCF.ForeColor = System.Drawing.Color.FromArgb(160, 180, 200);
            this.lblTituloNCF.Location = new System.Drawing.Point(420, 22);
            this.lblTituloNCF.Name = "lblTituloNCF";
            this.lblTituloNCF.Size = new System.Drawing.Size(51, 20);
            this.lblTituloNCF.TabIndex = 2;
            this.lblTituloNCF.Text = "NCF:";
            // 
            // lblNCF
            // 
            this.lblNCF.AutoSize = true;
            this.lblNCF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNCF.ForeColor = System.Drawing.Color.White;
            this.lblNCF.Location = new System.Drawing.Point(420, 42);
            this.lblNCF.Name = "lblNCF";
            this.lblNCF.Size = new System.Drawing.Size(150, 28);
            this.lblNCF.TabIndex = 3;
            this.lblNCF.Text = "B02-00000000";
            // 
            // lblTituloEstado
            // 
            this.lblTituloEstado.AutoSize = true;
            this.lblTituloEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloEstado.ForeColor = System.Drawing.Color.FromArgb(160, 180, 200);
            this.lblTituloEstado.Location = new System.Drawing.Point(605, 22);
            this.lblTituloEstado.Name = "lblTituloEstado";
            this.lblTituloEstado.Size = new System.Drawing.Size(64, 20);
            this.lblTituloEstado.TabIndex = 4;
            this.lblTituloEstado.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.lblEstado.Location = new System.Drawing.Point(605, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 28);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Emitida";

            // =========================================================
            // pnlInfoGeneral (tarjeta blanca con datos de la reserva)
            // =========================================================
            this.pnlInfoGeneral.BackColor = System.Drawing.Color.White;
            this.pnlInfoGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoGeneral.Location = new System.Drawing.Point(30, 125);
            this.pnlInfoGeneral.Name = "pnlInfoGeneral";
            this.pnlInfoGeneral.Size = new System.Drawing.Size(666, 200);
            this.pnlInfoGeneral.TabIndex = 1;
            this.pnlInfoGeneral.Controls.Add(this.lblTituloHabitacion);
            this.pnlInfoGeneral.Controls.Add(this.lblHabitacion);
            this.pnlInfoGeneral.Controls.Add(this.lblTituloHuesped);
            this.pnlInfoGeneral.Controls.Add(this.lblHuesped);
            this.pnlInfoGeneral.Controls.Add(this.lblTituloDocumento);
            this.pnlInfoGeneral.Controls.Add(this.lblDocumento);
            this.pnlInfoGeneral.Controls.Add(this.lblTituloCheckIn);
            this.pnlInfoGeneral.Controls.Add(this.lblCheckIn);
            this.pnlInfoGeneral.Controls.Add(this.lblTituloCheckOut);
            this.pnlInfoGeneral.Controls.Add(this.lblCheckOut);
            this.pnlInfoGeneral.Controls.Add(this.lblTituloNoches);
            this.pnlInfoGeneral.Controls.Add(this.lblNoches);
            this.pnlInfoGeneral.Controls.Add(this.lblTituloFechaEmision);
            this.pnlInfoGeneral.Controls.Add(this.lblFechaEmision);
            this.pnlInfoGeneral.Controls.Add(this.lblTituloFormaPago);
            this.pnlInfoGeneral.Controls.Add(this.lblFormaPago);

            // Fila 1: Habitación / Check-In
            // 
            // lblTituloHabitacion
            // 
            this.lblTituloHabitacion.AutoSize = true;
            this.lblTituloHabitacion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloHabitacion.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTituloHabitacion.Location = new System.Drawing.Point(24, 24);
            this.lblTituloHabitacion.Name = "lblTituloHabitacion";
            this.lblTituloHabitacion.Size = new System.Drawing.Size(89, 20);
            this.lblTituloHabitacion.TabIndex = 0;
            this.lblTituloHabitacion.Text = "Habitación:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHabitacion.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblHabitacion.Location = new System.Drawing.Point(160, 24);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(36, 20);
            this.lblHabitacion.TabIndex = 1;
            this.lblHabitacion.Text = "101";
            // 
            // lblTituloCheckIn
            // 
            this.lblTituloCheckIn.AutoSize = true;
            this.lblTituloCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloCheckIn.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTituloCheckIn.Location = new System.Drawing.Point(350, 24);
            this.lblTituloCheckIn.Name = "lblTituloCheckIn";
            this.lblTituloCheckIn.Size = new System.Drawing.Size(77, 20);
            this.lblTituloCheckIn.TabIndex = 6;
            this.lblTituloCheckIn.Text = "Check-In:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCheckIn.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblCheckIn.Location = new System.Drawing.Point(500, 24);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(89, 20);
            this.lblCheckIn.TabIndex = 7;
            this.lblCheckIn.Text = "00/00/0000";

            // Fila 2: Huésped / Check-Out
            // 
            // lblTituloHuesped
            // 
            this.lblTituloHuesped.AutoSize = true;
            this.lblTituloHuesped.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloHuesped.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTituloHuesped.Location = new System.Drawing.Point(24, 60);
            this.lblTituloHuesped.Name = "lblTituloHuesped";
            this.lblTituloHuesped.Size = new System.Drawing.Size(78, 20);
            this.lblTituloHuesped.TabIndex = 2;
            this.lblTituloHuesped.Text = "Huésped:";
            // 
            // lblHuesped
            // 
            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHuesped.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblHuesped.Location = new System.Drawing.Point(160, 60);
            this.lblHuesped.Name = "lblHuesped";
            this.lblHuesped.Size = new System.Drawing.Size(125, 20);
            this.lblHuesped.TabIndex = 3;
            this.lblHuesped.Text = "Nombre Apellido";
            // 
            // lblTituloCheckOut
            // 
            this.lblTituloCheckOut.AutoSize = true;
            this.lblTituloCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloCheckOut.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTituloCheckOut.Location = new System.Drawing.Point(350, 60);
            this.lblTituloCheckOut.Name = "lblTituloCheckOut";
            this.lblTituloCheckOut.Size = new System.Drawing.Size(89, 20);
            this.lblTituloCheckOut.TabIndex = 8;
            this.lblTituloCheckOut.Text = "Check-Out:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCheckOut.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblCheckOut.Location = new System.Drawing.Point(500, 60);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(89, 20);
            this.lblCheckOut.TabIndex = 9;
            this.lblCheckOut.Text = "00/00/0000";

            // Fila 3: Documento / Noches
            // 
            // lblTituloDocumento
            // 
            this.lblTituloDocumento.AutoSize = true;
            this.lblTituloDocumento.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloDocumento.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTituloDocumento.Location = new System.Drawing.Point(24, 96);
            this.lblTituloDocumento.Name = "lblTituloDocumento";
            this.lblTituloDocumento.Size = new System.Drawing.Size(96, 20);
            this.lblTituloDocumento.TabIndex = 4;
            this.lblTituloDocumento.Text = "Documento:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblDocumento.Location = new System.Drawing.Point(160, 96);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(118, 20);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "000-0000000-0";
            // 
            // lblTituloNoches
            // 
            this.lblTituloNoches.AutoSize = true;
            this.lblTituloNoches.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloNoches.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTituloNoches.Location = new System.Drawing.Point(350, 96);
            this.lblTituloNoches.Name = "lblTituloNoches";
            this.lblTituloNoches.Size = new System.Drawing.Size(67, 20);
            this.lblTituloNoches.TabIndex = 10;
            this.lblTituloNoches.Text = "Noches:";
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNoches.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblNoches.Location = new System.Drawing.Point(500, 96);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(18, 20);
            this.lblNoches.TabIndex = 11;
            this.lblNoches.Text = "0";

            // Fila 4 (separador visual con más espacio): Fecha Emisión / Forma de Pago
            // 
            // lblTituloFechaEmision
            // 
            this.lblTituloFechaEmision.AutoSize = true;
            this.lblTituloFechaEmision.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloFechaEmision.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTituloFechaEmision.Location = new System.Drawing.Point(24, 150);
            this.lblTituloFechaEmision.Name = "lblTituloFechaEmision";
            this.lblTituloFechaEmision.Size = new System.Drawing.Size(118, 20);
            this.lblTituloFechaEmision.TabIndex = 12;
            this.lblTituloFechaEmision.Text = "Fecha Emisión:";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFechaEmision.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblFechaEmision.Location = new System.Drawing.Point(160, 150);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(89, 20);
            this.lblFechaEmision.TabIndex = 13;
            this.lblFechaEmision.Text = "00/00/0000";
            // 
            // lblTituloFormaPago
            // 
            this.lblTituloFormaPago.AutoSize = true;
            this.lblTituloFormaPago.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTituloFormaPago.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTituloFormaPago.Location = new System.Drawing.Point(350, 150);
            this.lblTituloFormaPago.Name = "lblTituloFormaPago";
            this.lblTituloFormaPago.Size = new System.Drawing.Size(122, 20);
            this.lblTituloFormaPago.TabIndex = 14;
            this.lblTituloFormaPago.Text = "Forma de Pago:";
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFormaPago.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblFormaPago.Location = new System.Drawing.Point(500, 150);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(58, 20);
            this.lblFormaPago.TabIndex = 15;
            this.lblFormaPago.Text = "Tarjeta";

            // =========================================================
            // grpDesglose
            // =========================================================
            this.grpDesglose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpDesglose.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.grpDesglose.Controls.Add(this.lblTituloSubtotal);
            this.grpDesglose.Controls.Add(this.lblSubtotal);
            this.grpDesglose.Controls.Add(this.lblTituloITBIS);
            this.grpDesglose.Controls.Add(this.lblITBIS);
            this.grpDesglose.Controls.Add(this.lblTituloPropinaLegal);
            this.grpDesglose.Controls.Add(this.lblPropinaLegal);
            this.grpDesglose.Controls.Add(this.pnlTotal);
            this.grpDesglose.Location = new System.Drawing.Point(30, 340);
            this.grpDesglose.Name = "grpDesglose";
            this.grpDesglose.Size = new System.Drawing.Size(666, 260);
            this.grpDesglose.TabIndex = 2;
            this.grpDesglose.TabStop = false;
            this.grpDesglose.Text = "Desglose";
            // 
            // lblTituloSubtotal
            // 
            this.lblTituloSubtotal.AutoSize = true;
            this.lblTituloSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTituloSubtotal.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblTituloSubtotal.Location = new System.Drawing.Point(24, 40);
            this.lblTituloSubtotal.Name = "lblTituloSubtotal";
            this.lblTituloSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblTituloSubtotal.TabIndex = 0;
            this.lblTituloSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblSubtotal.Location = new System.Drawing.Point(480, 40);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "RD$0.00";
            // 
            // lblTituloITBIS
            // 
            this.lblTituloITBIS.AutoSize = true;
            this.lblTituloITBIS.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTituloITBIS.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblTituloITBIS.Location = new System.Drawing.Point(24, 78);
            this.lblTituloITBIS.Name = "lblTituloITBIS";
            this.lblTituloITBIS.Size = new System.Drawing.Size(100, 20);
            this.lblTituloITBIS.TabIndex = 2;
            this.lblTituloITBIS.Text = "ITBIS (18%):";
            // 
            // lblITBIS
            // 
            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblITBIS.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblITBIS.Location = new System.Drawing.Point(480, 78);
            this.lblITBIS.Name = "lblITBIS";
            this.lblITBIS.Size = new System.Drawing.Size(73, 20);
            this.lblITBIS.TabIndex = 3;
            this.lblITBIS.Text = "RD$0.00";
            // 
            // lblTituloPropinaLegal
            // 
            this.lblTituloPropinaLegal.AutoSize = true;
            this.lblTituloPropinaLegal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTituloPropinaLegal.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblTituloPropinaLegal.Location = new System.Drawing.Point(24, 116);
            this.lblTituloPropinaLegal.Name = "lblTituloPropinaLegal";
            this.lblTituloPropinaLegal.Size = new System.Drawing.Size(156, 20);
            this.lblTituloPropinaLegal.TabIndex = 4;
            this.lblTituloPropinaLegal.Text = "Propina Legal (10%):";
            // 
            // lblPropinaLegal
            // 
            this.lblPropinaLegal.AutoSize = true;
            this.lblPropinaLegal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPropinaLegal.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblPropinaLegal.Location = new System.Drawing.Point(480, 116);
            this.lblPropinaLegal.Name = "lblPropinaLegal";
            this.lblPropinaLegal.Size = new System.Drawing.Size(73, 20);
            this.lblPropinaLegal.TabIndex = 5;
            this.lblPropinaLegal.Text = "RD$0.00";

            // 
            // pnlTotal (franja azul destacada con el monto total)
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.pnlTotal.Location = new System.Drawing.Point(20, 165);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(626, 60);
            this.pnlTotal.TabIndex = 6;
            this.pnlTotal.Controls.Add(this.lblTituloMontoTotal);
            this.pnlTotal.Controls.Add(this.lblMontoTotal);
            // 
            // lblTituloMontoTotal
            // 
            this.lblTituloMontoTotal.AutoSize = true;
            this.lblTituloMontoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloMontoTotal.ForeColor = System.Drawing.Color.White;
            this.lblTituloMontoTotal.Location = new System.Drawing.Point(20, 16);
            this.lblTituloMontoTotal.Name = "lblTituloMontoTotal";
            this.lblTituloMontoTotal.Size = new System.Drawing.Size(180, 28);
            this.lblTituloMontoTotal.TabIndex = 0;
            this.lblTituloMontoTotal.Text = "MONTO TOTAL:";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.White;
            this.lblMontoTotal.Location = new System.Drawing.Point(460, 16);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(110, 28);
            this.lblMontoTotal.TabIndex = 1;
            this.lblMontoTotal.Text = "RD$0.00";

            // =========================================================
            // btnCerrar
            // =========================================================
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(516, 618);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(180, 46);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // =========================================================
            // FrmVerFactura
            // =========================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(726, 690);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlInfoGeneral);
            this.Controls.Add(this.grpDesglose);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Factura";
            this.Load += new System.EventHandler(this.FrmVerFactura_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInfoGeneral.ResumeLayout(false);
            this.pnlInfoGeneral.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.grpDesglose.ResumeLayout(false);
            this.grpDesglose.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}