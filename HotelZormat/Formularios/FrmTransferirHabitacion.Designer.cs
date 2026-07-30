

namespace HotelZormat.UI.Formularios
{
    partial class FrmTransferirHabitacion
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

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cboHabitaciones;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cboHabitaciones = new System.Windows.Forms.ComboBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Transferir Habitacion";
            //
            // lblHabitacion
            //
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(30, 70);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(120, 15);
            this.lblHabitacion.TabIndex = 1;
            this.lblHabitacion.Text = "Habitacion destino:";
            //
            // cboHabitaciones
            //
            this.cboHabitaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHabitaciones.FormattingEnabled = true;
            this.cboHabitaciones.Location = new System.Drawing.Point(30, 90);
            this.cboHabitaciones.Name = "cboHabitaciones";
            this.cboHabitaciones.Size = new System.Drawing.Size(280, 23);
            this.cboHabitaciones.TabIndex = 2;
            //
            // lblMotivo
            //
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(30, 130);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(120, 15);
            this.lblMotivo.TabIndex = 3;
            this.lblMotivo.Text = "Motivo (opcional):";
            //
            // txtMotivo
            //
            this.txtMotivo.Location = new System.Drawing.Point(30, 150);
            this.txtMotivo.MaxLength = 200;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(280, 23);
            this.txtMotivo.TabIndex = 4;
            //
            // btnConfirmar
            //
            this.btnConfirmar.Location = new System.Drawing.Point(30, 200);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 30);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(180, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // FrmTransferirHabitacion
            //
            this.AcceptButton = this.btnConfirmar;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(340, 260);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.cboHabitaciones);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferirHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transferir Habitacion";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}