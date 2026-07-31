

namespace HotelZormat.UI.Formularios
{
    partial class FrmHistorialEstadias
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
        private System.Windows.Forms.Label lblBuscarHuesped;
        private System.Windows.Forms.TextBox txtBuscarHuesped;
        private System.Windows.Forms.ListBox lstHuespedesSugeridos;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblSinResultados;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscarHuesped = new System.Windows.Forms.Label();
            this.txtBuscarHuesped = new System.Windows.Forms.TextBox();
            this.lstHuespedesSugeridos = new System.Windows.Forms.ListBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblSinResultados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Historial de Estadias por Huesped";
            //
            // lblBuscarHuesped
            //
            this.lblBuscarHuesped.AutoSize = true;
            this.lblBuscarHuesped.Location = new System.Drawing.Point(20, 60);
            this.lblBuscarHuesped.Name = "lblBuscarHuesped";
            this.lblBuscarHuesped.Size = new System.Drawing.Size(55, 15);
            this.lblBuscarHuesped.TabIndex = 1;
            this.lblBuscarHuesped.Text = "Huesped:";
            //
            // txtBuscarHuesped
            //
            this.txtBuscarHuesped.Location = new System.Drawing.Point(20, 80);
            this.txtBuscarHuesped.Name = "txtBuscarHuesped";
            this.txtBuscarHuesped.Size = new System.Drawing.Size(300, 23);
            this.txtBuscarHuesped.TabIndex = 2;
            this.txtBuscarHuesped.Click += new System.EventHandler(this.txtBuscarHuesped_Click);
            this.txtBuscarHuesped.TextChanged += new System.EventHandler(this.txtBuscarHuesped_TextChanged);
            //
            // lstHuespedesSugeridos
            //
            this.lstHuespedesSugeridos.FormattingEnabled = true;
            this.lstHuespedesSugeridos.IntegralHeight = false;
            this.lstHuespedesSugeridos.Location = new System.Drawing.Point(20, 106);
            this.lstHuespedesSugeridos.Name = "lstHuespedesSugeridos";
            this.lstHuespedesSugeridos.Size = new System.Drawing.Size(300, 130);
            this.lstHuespedesSugeridos.TabIndex = 3;
            this.lstHuespedesSugeridos.DoubleClick += new System.EventHandler(this.lstHuespedesSugeridos_DoubleClick);
            //
            // dgvHistorial
            //
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(20, 245);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersWidth = 25;
            this.dgvHistorial.Size = new System.Drawing.Size(700, 300);
            this.dgvHistorial.TabIndex = 4;
            //
            // lblSinResultados
            //
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.ForeColor = System.Drawing.Color.Gray;
            this.lblSinResultados.Location = new System.Drawing.Point(20, 250);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(260, 15);
            this.lblSinResultados.TabIndex = 5;
            this.lblSinResultados.Text = "Este huesped no tiene estadias registradas.";
            this.lblSinResultados.Visible = false;
            //
            // FrmHistorialEstadias
            //
            this.ClientSize = new System.Drawing.Size(740, 565);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.lstHuespedesSugeridos);
            this.Controls.Add(this.txtBuscarHuesped);
            this.Controls.Add(this.lblBuscarHuesped);
            this.Controls.Add(this.lblTitulo);
            this.MinimumSize = new System.Drawing.Size(756, 604);
            this.Name = "FrmHistorialEstadias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Estadias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}