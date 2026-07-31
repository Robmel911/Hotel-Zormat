// FrmGestionEstadias.Designer.cs

namespace HotelZormat.UI.Formularios
{
    partial class FrmGestionEstadias
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
        private System.Windows.Forms.DataGridView dgvEstadias;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnActualizar;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvEstadias = new System.Windows.Forms.DataGridView();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVerHistrorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestion de Estadias";
            // 
            // dgvEstadias
            // 
            this.dgvEstadias.AllowUserToAddRows = false;
            this.dgvEstadias.AllowUserToDeleteRows = false;
            this.dgvEstadias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadias.Location = new System.Drawing.Point(20, 55);
            this.dgvEstadias.Name = "dgvEstadias";
            this.dgvEstadias.ReadOnly = true;
            this.dgvEstadias.RowHeadersWidth = 25;
            this.dgvEstadias.Size = new System.Drawing.Size(700, 350);
            this.dgvEstadias.TabIndex = 1;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Location = new System.Drawing.Point(20, 420);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(180, 35);
            this.btnAgregarServicio.TabIndex = 2;
            this.btnAgregarServicio.Text = "Agregar Servicio";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(220, 420);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(180, 35);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Transferir Habitacion";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(739, 420);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 35);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar Lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnVerHistrorial
            // 
            this.btnVerHistrorial.Location = new System.Drawing.Point(453, 420);
            this.btnVerHistrorial.Name = "btnVerHistrorial";
            this.btnVerHistrorial.Size = new System.Drawing.Size(223, 35);
            this.btnVerHistrorial.TabIndex = 5;
            this.btnVerHistrorial.Text = "Ver Historial de Huespedes";
            this.btnVerHistrorial.UseVisualStyleBackColor = true;
            this.btnVerHistrorial.Click += new System.EventHandler(this.btnVerHistrorial_Click);
            // 
            // FrmGestionEstadias
            // 
            this.ClientSize = new System.Drawing.Size(948, 475);
            this.Controls.Add(this.btnVerHistrorial);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.dgvEstadias);
            this.Controls.Add(this.lblTitulo);
            this.MinimumSize = new System.Drawing.Size(756, 514);
            this.Name = "FrmGestionEstadias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Estadias";
            this.Load += new System.EventHandler(this.FrmGestionEstadias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnVerHistrorial;
    }
}