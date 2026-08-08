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

        // ---- Controles originales (mismos nombres, para no romper el codebehind) ----
        private System.Windows.Forms.Label lblNumerohab;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.NumericUpDown nudPiso;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider epHabitaciones;

        // ---- Controles nuevos, solo decorativos ----
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblTituloVentana;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNumerohab = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.epHabitaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtTarifaBase = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHabitaciones)).BeginInit();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumerohab
            // 
            this.lblNumerohab.AutoSize = true;
            this.lblNumerohab.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNumerohab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblNumerohab.Location = new System.Drawing.Point(25, 70);
            this.lblNumerohab.Name = "lblNumerohab";
            this.lblNumerohab.Size = new System.Drawing.Size(91, 25);
            this.lblNumerohab.TabIndex = 1;
            this.lblNumerohab.Text = "Número:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTipo.Location = new System.Drawing.Point(25, 140);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(57, 25);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo:";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTipo.Location = new System.Drawing.Point(25, 168);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(270, 36);
            this.cboTipo.TabIndex = 4;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblPiso.Location = new System.Drawing.Point(25, 208);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(54, 25);
            this.lblPiso.TabIndex = 5;
            this.lblPiso.Text = "Piso:";
            // 
            // nudPiso
            // 
            this.nudPiso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudPiso.Location = new System.Drawing.Point(25, 234);
            this.nudPiso.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPiso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(270, 34);
            this.nudPiso.TabIndex = 6;
            this.nudPiso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPiso.ValueChanged += new System.EventHandler(this.nudPiso_ValueChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblCantidad.Location = new System.Drawing.Point(25, 272);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 25);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Capacidad:";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudCapacidad.Location = new System.Drawing.Point(25, 300);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(270, 34);
            this.nudCapacidad.TabIndex = 8;
            this.nudCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTarifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTarifa.Location = new System.Drawing.Point(25, 340);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(111, 25);
            this.lblTarifa.TabIndex = 9;
            this.lblTarifa.Text = "Tarifa Base:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(25, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 46);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCancelar.Location = new System.Drawing.Point(165, 420);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 46);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epHabitaciones
            // 
            this.epHabitaciones.ContainerControl = this;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.txtTarifaBase);
            this.panelCard.Controls.Add(this.txtNumero);
            this.panelCard.Controls.Add(this.lblTituloVentana);
            this.panelCard.Controls.Add(this.lblNumerohab);
            this.panelCard.Controls.Add(this.lblTipo);
            this.panelCard.Controls.Add(this.cboTipo);
            this.panelCard.Controls.Add(this.lblPiso);
            this.panelCard.Controls.Add(this.nudPiso);
            this.panelCard.Controls.Add(this.lblCantidad);
            this.panelCard.Controls.Add(this.nudCapacidad);
            this.panelCard.Controls.Add(this.lblTarifa);
            this.panelCard.Controls.Add(this.btnGuardar);
            this.panelCard.Controls.Add(this.btnCancelar);
            this.panelCard.Location = new System.Drawing.Point(30, 30);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(320, 486);
            this.panelCard.TabIndex = 0;
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloVentana.Location = new System.Drawing.Point(0, 25);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(320, 32);
            this.lblTituloVentana.TabIndex = 0;
            this.lblTituloVentana.Text = "Crear Habitación";
            this.lblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(25, 98);
            this.txtNumero.Mask = "100";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(270, 26);
            this.txtNumero.TabIndex = 13;
            // 
            // txtTarifaBase
            // 
            this.txtTarifaBase.Location = new System.Drawing.Point(25, 368);
            this.txtTarifaBase.Mask = "00000";
            this.txtTarifaBase.Name = "txtTarifaBase";
            this.txtTarifaBase.Size = new System.Drawing.Size(270, 26);
            this.txtTarifaBase.TabIndex = 14;
            // 
            // FrmCrearHabitaciones
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(380, 550);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Habitación";
            this.Load += new System.EventHandler(this.FrmCrearHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epHabitaciones)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTarifaBase;
        private System.Windows.Forms.MaskedTextBox txtNumero;
    }
}