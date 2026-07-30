

namespace HotelZormat.UI.Formularios
{
    partial class FrmAgregarServicio
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
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblConsumos;
        private System.Windows.Forms.ListBox lstConsumos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCerrar;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblConsumos = new System.Windows.Forms.Label();
            this.lstConsumos = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Servicio";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(20, 60);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(68, 20);
            this.lblServicio.TabIndex = 1;
            this.lblServicio.Text = "Servicio:";
            // 
            // cboServicios
            // 
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(20, 80);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(250, 28);
            this.cboServicios.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(280, 60);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(280, 80);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(70, 26);
            this.nudCantidad.TabIndex = 4;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 115);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(330, 42);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblConsumos
            // 
            this.lblConsumos.AutoSize = true;
            this.lblConsumos.Location = new System.Drawing.Point(20, 160);
            this.lblConsumos.Name = "lblConsumos";
            this.lblConsumos.Size = new System.Drawing.Size(165, 20);
            this.lblConsumos.TabIndex = 6;
            this.lblConsumos.Text = "Servicios consumidos:";
            // 
            // lstConsumos
            // 
            this.lstConsumos.FormattingEnabled = true;
            this.lstConsumos.IntegralHeight = false;
            this.lstConsumos.ItemHeight = 20;
            this.lstConsumos.Location = new System.Drawing.Point(20, 180);
            this.lstConsumos.Name = "lstConsumos";
            this.lstConsumos.Size = new System.Drawing.Size(330, 140);
            this.lstConsumos.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 30);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar seleccionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(190, 393);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(232, 28);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total consumido: $0.00";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(27, 440);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(395, 30);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmAgregarServicio
            // 
            this.AcceptButton = this.btnAgregar;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(438, 482);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lstConsumos);
            this.Controls.Add(this.lblConsumos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cboServicios);
            this.Controls.Add(this.lblServicio);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Servicio";
            this.Load += new System.EventHandler(this.FrmAgregarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}