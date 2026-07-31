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

        // ---- Controles ----
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
            this.lblTituloMontoTotal = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDesglose.SuspendLayout();
            this.SuspendLayout();

            // ---- Habitacion ----
            this.lblTituloHabitacion.AutoSize = true;
            this.lblTituloHabitacion.Location = new System.Drawing.Point(20, 20);
            this.lblTituloHabitacion.Text = "Habitación:";

            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(120, 20);
            this.lblHabitacion.Text = "101";

            // ---- Huesped ----
            this.lblTituloHuesped.AutoSize = true;
            this.lblTituloHuesped.Location = new System.Drawing.Point(20, 50);
            this.lblTituloHuesped.Text = "Huésped:";

            this.lblHuesped.AutoSize = true;
            this.lblHuesped.Location = new System.Drawing.Point(120, 50);
            this.lblHuesped.Text = "Nombre Apellido";

            // ---- Check-In ----
            this.lblTituloCheckIn.AutoSize = true;
            this.lblTituloCheckIn.Location = new System.Drawing.Point(20, 80);
            this.lblTituloCheckIn.Text = "Check-In:";

            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(120, 80);
            this.lblCheckIn.Text = "00/00/0000";

            // ---- Check-Out ----
            this.lblTituloCheckOut.AutoSize = true;
            this.lblTituloCheckOut.Location = new System.Drawing.Point(280, 80);
            this.lblTituloCheckOut.Text = "Check-Out:";

            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(370, 80);
            this.lblCheckOut.Text = "00/00/0000";

            // ---- Noches ----
            this.lblTituloNoches.AutoSize = true;
            this.lblTituloNoches.Location = new System.Drawing.Point(20, 110);
            this.lblTituloNoches.Text = "Noches:";

            this.lblNoches.AutoSize = true;
            this.lblNoches.Location = new System.Drawing.Point(120, 110);
            this.lblNoches.Text = "0";

            // ---- Forma de Pago ----
            this.lblTituloFormaPago.AutoSize = true;
            this.lblTituloFormaPago.Location = new System.Drawing.Point(20, 150);
            this.lblTituloFormaPago.Text = "Forma de Pago:";

            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.Location = new System.Drawing.Point(140, 147);
            this.cmbFormaPago.Size = new System.Drawing.Size(150, 21);
            this.cmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPago_SelectedIndexChanged);

            // ---- Agregar Servicio (abre FrmAgregarServicio, luego refresca el desglose) ----
            this.btnAgregarServicio.Location = new System.Drawing.Point(310, 146);
            this.btnAgregarServicio.Size = new System.Drawing.Size(130, 25);
            this.btnAgregarServicio.Text = "Agregar Servicio";
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);

            // ---- GroupBox Desglose (altura +60 por las 2 filas nuevas) ----
            this.grpDesglose.Location = new System.Drawing.Point(20, 190);
            this.grpDesglose.Size = new System.Drawing.Size(420, 220);
            this.grpDesglose.Text = "Desglose (vista previa)";
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
            this.grpDesglose.Controls.Add(this.lblTituloMontoTotal);
            this.grpDesglose.Controls.Add(this.lblMontoTotal);

            // Costo Reserva
            this.lblTituloCostoReserva.AutoSize = true;
            this.lblTituloCostoReserva.Location = new System.Drawing.Point(20, 30);
            this.lblTituloCostoReserva.Text = "Costo Reserva:";

            this.lblCostoReserva.AutoSize = true;
            this.lblCostoReserva.Location = new System.Drawing.Point(150, 30);
            this.lblCostoReserva.Text = "RD$0.00";

            // Consumo Servicios
            this.lblTituloConsumoServicios.AutoSize = true;
            this.lblTituloConsumoServicios.Location = new System.Drawing.Point(20, 60);
            this.lblTituloConsumoServicios.Text = "Consumo Servicios:";

            this.lblConsumoServicios.AutoSize = true;
            this.lblConsumoServicios.Location = new System.Drawing.Point(150, 60);
            this.lblConsumoServicios.Text = "RD$0.00";

            // Subtotal (corrido de Y=30 a Y=90)
            this.lblTituloSubtotal.AutoSize = true;
            this.lblTituloSubtotal.Location = new System.Drawing.Point(20, 90);
            this.lblTituloSubtotal.Text = "Subtotal:";

            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(150, 90);
            this.lblSubtotal.Text = "RD$0.00";

            // ITBIS (corrido de Y=60 a Y=120)
            this.lblTituloITBIS.AutoSize = true;
            this.lblTituloITBIS.Location = new System.Drawing.Point(20, 120);
            this.lblTituloITBIS.Text = "ITBIS (18%):";

            this.lblITBIS.AutoSize = true;
            this.lblITBIS.Location = new System.Drawing.Point(150, 120);
            this.lblITBIS.Text = "RD$0.00";

            // Propina Legal (corrido de Y=90 a Y=150)
            this.lblTituloPropinaLegal.AutoSize = true;
            this.lblTituloPropinaLegal.Location = new System.Drawing.Point(20, 150);
            this.lblTituloPropinaLegal.Text = "Propina Legal (10%):";

            this.lblPropinaLegal.AutoSize = true;
            this.lblPropinaLegal.Location = new System.Drawing.Point(150, 150);
            this.lblPropinaLegal.Text = "RD$0.00";

            // Monto Total (corrido de Y=125 a Y=185)
            this.lblTituloMontoTotal.AutoSize = true;
            this.lblTituloMontoTotal.Location = new System.Drawing.Point(20, 185);
            this.lblTituloMontoTotal.Text = "MONTO TOTAL:";
            this.lblTituloMontoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(180, 185);
            this.lblMontoTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.Text = "RD$0.00";

            // ---- Botones (corridos de Y=370 a Y=430 por la altura nueva del groupbox) ----
            this.btnGenerarFactura.Location = new System.Drawing.Point(220, 430);
            this.btnGenerarFactura.Size = new System.Drawing.Size(120, 32);
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);

            this.btnCancelar.Location = new System.Drawing.Point(350, 430);
            this.btnCancelar.Size = new System.Drawing.Size(90, 32);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // ---- FrmGenerarFactura (alto +60 por las 2 filas nuevas del desglose) ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 481);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generar Factura";
            this.Load += new System.EventHandler(this.FrmGenerarFactura_Load);

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
            this.Controls.Add(this.lblTituloFormaPago);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.grpDesglose);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.btnCancelar);

            this.grpDesglose.ResumeLayout(false);
            this.grpDesglose.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}