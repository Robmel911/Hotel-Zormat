namespace HotelZormat.UI.Formularios
{
    partial class FrmGestionFacturas
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

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnCerrar;

        private void InitializeComponent()
        {
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();

            // ---- dgvFacturas ----
            this.dgvFacturas.Location = new System.Drawing.Point(15, 15);
            this.dgvFacturas.Size = new System.Drawing.Size(760, 400);
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dgvFacturas_SelectionChanged);

            // ---- btnVerDetalle ----
            this.btnVerDetalle.Location = new System.Drawing.Point(15, 430);
            this.btnVerDetalle.Size = new System.Drawing.Size(120, 32);
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.Enabled = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);

            // ---- btnAnular ----
            this.btnAnular.Location = new System.Drawing.Point(145, 430);
            this.btnAnular.Size = new System.Drawing.Size(120, 32);
            this.btnAnular.Text = "Anular Factura";
            this.btnAnular.Enabled = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);

            // ---- btnCerrar ----
            this.btnCerrar.Location = new System.Drawing.Point(655, 430);
            this.btnCerrar.Size = new System.Drawing.Size(120, 32);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // ---- FrmGestionFacturas ----
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 480);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Facturas";
            this.Load += new System.EventHandler(this.FrmGestionFacturas_Load);

            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnCerrar);

            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
        }
    }
}