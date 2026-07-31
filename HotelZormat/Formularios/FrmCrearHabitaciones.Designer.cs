namespace HotelZormat.UI.Formularios
{
    partial class FrmCrearHabitaciones
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
            this.lblNumerohab = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifaBase = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.epHabitaciones = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHabitaciones)).BeginInit();
            this.SuspendLayout();
            //
            // lblNumerohab
            //
            this.lblNumerohab.AutoSize = true;
            this.lblNumerohab.Location = new System.Drawing.Point(30, 30);
            this.lblNumerohab.Name = "lblNumerohab";
            this.lblNumerohab.Text = "Numero";
            //
            // txtNumero
            //
            this.txtNumero.Location = new System.Drawing.Point(30, 55);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(150, 26);
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(30, 95);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Text = "Tipo";
            //
            // cboTipo
            //
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Location = new System.Drawing.Point(30, 120);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(150, 28);
            //
            // lblPiso
            //
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(30, 160);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Text = "Piso";
            //
            // nudPiso
            //
            this.nudPiso.Location = new System.Drawing.Point(30, 185);
            this.nudPiso.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.nudPiso.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(150, 26);
            this.nudPiso.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblCantidad
            //
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 225);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Text = "Capacidad";
            //
            // nudCapacidad
            //
            this.nudCapacidad.Location = new System.Drawing.Point(30, 250);
            this.nudCapacidad.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.nudCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(150, 26);
            this.nudCapacidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblTarifa
            //
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(30, 290);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Text = "Tarifa Base";
            //
            // txtTarifaBase
            //
            this.txtTarifaBase.Location = new System.Drawing.Point(30, 315);
            this.txtTarifaBase.Name = "txtTarifaBase";
            this.txtTarifaBase.Size = new System.Drawing.Size(150, 26);
            //
            // btnGuardar
            //
            this.btnGuardar.Location = new System.Drawing.Point(30, 365);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 45);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(150, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 45);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // epHabitaciones
            //
            this.epHabitaciones.ContainerControl = this;
            //
            // FrmCrearHabitaciones
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 440);
            this.Controls.Add(this.lblNumerohab);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.nudPiso);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.txtTarifaBase);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Habitacion";
            this.Load += new System.EventHandler(this.FrmCrearHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNumerohab;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.NumericUpDown nudPiso;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtTarifaBase;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider epHabitaciones;
    }
}