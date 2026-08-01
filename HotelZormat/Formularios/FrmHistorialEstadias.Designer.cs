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

        // ---- Controles originales (mismos nombres, para no romper el codebehind) ----
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscarHuesped;
        private System.Windows.Forms.TextBox txtBuscarHuesped;
        private System.Windows.Forms.ListBox lstHuespedesSugeridos;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblSinResultados;

        // ---- Controles nuevos, solo decorativos ----
        private System.Windows.Forms.Panel pnlHeader;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscarHuesped = new System.Windows.Forms.Label();
            this.txtBuscarHuesped = new System.Windows.Forms.TextBox();
            this.lstHuespedesSugeridos = new System.Windows.Forms.ListBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblSinResultados = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 70);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblTitulo);

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Historial de Estadías por Huésped";

            // 
            // lblBuscarHuesped
            // 
            this.lblBuscarHuesped.AutoSize = true;
            this.lblBuscarHuesped.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscarHuesped.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblBuscarHuesped.Location = new System.Drawing.Point(30, 90);
            this.lblBuscarHuesped.Name = "lblBuscarHuesped";
            this.lblBuscarHuesped.Size = new System.Drawing.Size(65, 20);
            this.lblBuscarHuesped.TabIndex = 1;
            this.lblBuscarHuesped.Text = "Huésped:";

            // 
            // txtBuscarHuesped
            // 
            this.txtBuscarHuesped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarHuesped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarHuesped.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscarHuesped.Location = new System.Drawing.Point(30, 112);
            this.txtBuscarHuesped.Name = "txtBuscarHuesped";
            this.txtBuscarHuesped.Size = new System.Drawing.Size(320, 30);
            this.txtBuscarHuesped.TabIndex = 2;
            this.txtBuscarHuesped.Click += new System.EventHandler(this.txtBuscarHuesped_Click);
            this.txtBuscarHuesped.TextChanged += new System.EventHandler(this.txtBuscarHuesped_TextChanged);

            // 
            // lstHuespedesSugeridos
            // 
            this.lstHuespedesSugeridos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHuespedesSugeridos.BackColor = System.Drawing.Color.White;
            this.lstHuespedesSugeridos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHuespedesSugeridos.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lstHuespedesSugeridos.FormattingEnabled = true;
            this.lstHuespedesSugeridos.IntegralHeight = false;
            this.lstHuespedesSugeridos.ItemHeight = 22;
            this.lstHuespedesSugeridos.Location = new System.Drawing.Point(30, 148);
            this.lstHuespedesSugeridos.Name = "lstHuespedesSugeridos";
            this.lstHuespedesSugeridos.Size = new System.Drawing.Size(320, 140);
            this.lstHuespedesSugeridos.TabIndex = 3;
            this.lstHuespedesSugeridos.DoubleClick += new System.EventHandler(this.lstHuespedesSugeridos_DoubleClick);

            // 
            // dgvHistorial
            // 
            this.dgvHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvHistorial.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.dgvHistorial.ColumnHeadersHeight = 40;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorial.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvHistorial.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.dgvHistorial.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(230, 233, 237);
            this.dgvHistorial.Location = new System.Drawing.Point(30, 300);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHistorial.RowTemplate.Height = 30;
            this.dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(247, 249, 251);
            this.dgvHistorial.Size = new System.Drawing.Size(740, 340);
            this.dgvHistorial.TabIndex = 4;

            // 
            // lblSinResultados
            // 
            this.lblSinResultados.AutoSize = true;
            this.lblSinResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSinResultados.ForeColor = System.Drawing.Color.Gray;
            this.lblSinResultados.Location = new System.Drawing.Point(30, 300);
            this.lblSinResultados.Name = "lblSinResultados";
            this.lblSinResultados.Size = new System.Drawing.Size(300, 20);
            this.lblSinResultados.TabIndex = 5;
            this.lblSinResultados.Text = "Este huésped no tiene estadías registradas.";
            this.lblSinResultados.Visible = false;

            // 
            // FrmHistorialEstadias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.lblSinResultados);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.lstHuespedesSugeridos);
            this.Controls.Add(this.txtBuscarHuesped);
            this.Controls.Add(this.lblBuscarHuesped);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(800, 670);
            this.Name = "FrmHistorialEstadias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Estadías";

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}