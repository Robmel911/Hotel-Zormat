namespace HotelReto
{
    partial class frmGestionHabitaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblIcono = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTituloTarifa = new System.Windows.Forms.Label();
            this.lblTituloIcono = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTituloEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroHabitacion = new System.Windows.Forms.TextBox();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMarcarLimpiar = new System.Windows.Forms.Button();
            this.btnChkIn = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lblAccion = new System.Windows.Forms.Label();
            this.cboAccion = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTarifa);
            this.groupBox1.Controls.Add(this.lblIcono);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.lblTituloTarifa);
            this.groupBox1.Controls.Add(this.lblTituloIcono);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos De Habitacion";
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.BackColor = System.Drawing.SystemColors.Control;
            this.lblTarifa.ForeColor = System.Drawing.Color.Green;
            this.lblTarifa.Location = new System.Drawing.Point(69, 116);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(55, 20);
            this.lblTarifa.TabIndex = 5;
            this.lblTarifa.Text = "RD $0";
            // 
            // lblIcono
            // 
            this.lblIcono.AutoSize = true;
            this.lblIcono.Location = new System.Drawing.Point(69, 75);
            this.lblIcono.Name = "lblIcono";
            this.lblIcono.Size = new System.Drawing.Size(21, 20);
            this.lblIcono.TabIndex = 4;
            this.lblIcono.Text = "**";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(73, 35);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 28);
            this.cboTipo.TabIndex = 3;
            // 
            // lblTituloTarifa
            // 
            this.lblTituloTarifa.AutoSize = true;
            this.lblTituloTarifa.Location = new System.Drawing.Point(7, 116);
            this.lblTituloTarifa.Name = "lblTituloTarifa";
            this.lblTituloTarifa.Size = new System.Drawing.Size(53, 20);
            this.lblTituloTarifa.TabIndex = 2;
            this.lblTituloTarifa.Text = "Tarifa:";
            // 
            // lblTituloIcono
            // 
            this.lblTituloIcono.AutoSize = true;
            this.lblTituloIcono.Location = new System.Drawing.Point(7, 75);
            this.lblTituloIcono.Name = "lblTituloIcono";
            this.lblTituloIcono.Size = new System.Drawing.Size(53, 20);
            this.lblTituloIcono.TabIndex = 1;
            this.lblTituloIcono.Text = "Icono:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(7, 35);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumeroHabitacion);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTituloEstado);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar habitacion";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 38);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(69, 20);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Numero:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstHabitaciones);
            this.groupBox3.Location = new System.Drawing.Point(498, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 153);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "habitaciones piso 3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChkIn);
            this.groupBox4.Controls.Add(this.btnReservar);
            this.groupBox4.Controls.Add(this.btnMarcarLimpiar);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(12, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(664, 76);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGuardar);
            this.groupBox5.Controls.Add(this.btnConfirmar);
            this.groupBox5.Controls.Add(this.cboAccion);
            this.groupBox5.Controls.Add(this.lblAccion);
            this.groupBox5.Location = new System.Drawing.Point(12, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(674, 76);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Confirmar y guardar";
            // 
            // lblTituloEstado
            // 
            this.lblTituloEstado.AutoSize = true;
            this.lblTituloEstado.Location = new System.Drawing.Point(6, 116);
            this.lblTituloEstado.Name = "lblTituloEstado";
            this.lblTituloEstado.Size = new System.Drawing.Size(60, 20);
            this.lblTituloEstado.TabIndex = 7;
            this.lblTituloEstado.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sin Habitacion Seleccionada";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(193, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 29);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNumeroHabitacion
            // 
            this.txtNumeroHabitacion.Location = new System.Drawing.Point(82, 36);
            this.txtNumeroHabitacion.Name = "txtNumeroHabitacion";
            this.txtNumeroHabitacion.Size = new System.Drawing.Size(100, 26);
            this.txtNumeroHabitacion.TabIndex = 10;
            // 
            // lstHabitaciones
            // 
            this.lstHabitaciones.FormattingEnabled = true;
            this.lstHabitaciones.ItemHeight = 20;
            this.lstHabitaciones.Location = new System.Drawing.Point(7, 26);
            this.lstHabitaciones.Name = "lstHabitaciones";
            this.lstHabitaciones.Size = new System.Drawing.Size(181, 124);
            this.lstHabitaciones.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Check-Out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnMarcarLimpiar
            // 
            this.btnMarcarLimpiar.Location = new System.Drawing.Point(532, 25);
            this.btnMarcarLimpiar.Name = "btnMarcarLimpiar";
            this.btnMarcarLimpiar.Size = new System.Drawing.Size(126, 35);
            this.btnMarcarLimpiar.TabIndex = 3;
            this.btnMarcarLimpiar.Text = "Marcar Limpiar";
            this.btnMarcarLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnChkIn
            // 
            this.btnChkIn.Location = new System.Drawing.Point(206, 25);
            this.btnChkIn.Name = "btnChkIn";
            this.btnChkIn.Size = new System.Drawing.Size(112, 35);
            this.btnChkIn.TabIndex = 5;
            this.btnChkIn.Text = "Check-In";
            this.btnChkIn.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(53, 25);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(105, 35);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(7, 35);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(61, 20);
            this.lblAccion.TabIndex = 6;
            this.lblAccion.Text = "Accion:";
            // 
            // cboAccion
            // 
            this.cboAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccion.FormattingEnabled = true;
            this.cboAccion.Location = new System.Drawing.Point(75, 35);
            this.cboAccion.Name = "cboAccion";
            this.cboAccion.Size = new System.Drawing.Size(121, 28);
            this.cboAccion.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(206, 31);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 35);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Orange;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(546, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // frmGestionHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 344);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGestionHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HotelZormat - Gestion de Habitaciones";
            this.Load += new System.EventHandler(this.frmGestionHabitaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTituloTarifa;
        private System.Windows.Forms.Label lblTituloIcono;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroHabitacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloEstado;
        private System.Windows.Forms.ListBox lstHabitaciones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnChkIn;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnMarcarLimpiar;
        private System.Windows.Forms.ComboBox cboAccion;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConfirmar;
    }
}
