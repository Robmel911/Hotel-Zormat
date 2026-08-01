namespace HotelZormat.UI.Formularios
{
    partial class FrmBitacora
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
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        // ---- Controles nuevos, solo decorativos/organizativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblBadgeAdmin;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Panel pnlDividerFiltros;
        private System.Windows.Forms.Panel pnlContenido;

        private void InitializeComponent()
        {
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBadgeAdmin = new System.Windows.Forms.Label();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.pnlDividerFiltros = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // pnlHeader
            // =========================================================
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1633, 90);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblBadgeAdmin);

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bitácora de Auditoría";

            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(43, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(320, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Registro de acciones críticas del sistema";

            // 
            // lblBadgeAdmin (indicador de acceso restringido)
            // 
            this.lblBadgeAdmin.AutoSize = true;
            this.lblBadgeAdmin.BackColor = System.Drawing.Color.FromArgb(220, 68, 68);
            this.lblBadgeAdmin.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblBadgeAdmin.ForeColor = System.Drawing.Color.White;
            this.lblBadgeAdmin.Location = new System.Drawing.Point(1453, 34);
            this.lblBadgeAdmin.Name = "lblBadgeAdmin";
            this.lblBadgeAdmin.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblBadgeAdmin.Size = new System.Drawing.Size(160, 24);
            this.lblBadgeAdmin.TabIndex = 2;
            this.lblBadgeAdmin.Text = "SOLO ADMINISTRADOR";

            // =========================================================
            // pnlFiltros
            // =========================================================
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 90);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1633, 110);
            this.pnlFiltros.TabIndex = 1;
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.button1);
            this.pnlFiltros.Controls.Add(this.button2);
            this.pnlFiltros.Controls.Add(this.pnlDividerFiltros);

            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblDesde.Location = new System.Drawing.Point(40, 38);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(58, 20);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";

            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(105, 33);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(180, 27);
            this.dtpDesde.TabIndex = 1;

            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblHasta.Location = new System.Drawing.Point(320, 38);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(54, 20);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";

            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(382, 33);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(180, 27);
            this.dtpHasta.TabIndex = 3;

            // 
            // button1 (Ver Todo: contorno navy)
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.button1.Location = new System.Drawing.Point(610, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Todo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVerTodo_Click);

            // 
            // button2 (Filtrar: azul Zormat)
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(785, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnFiltrar_Click);

            // 
            // pnlDividerFiltros
            // 
            this.pnlDividerFiltros.BackColor = System.Drawing.Color.FromArgb(225, 228, 232);
            this.pnlDividerFiltros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDividerFiltros.Location = new System.Drawing.Point(0, 108);
            this.pnlDividerFiltros.Name = "pnlDividerFiltros";
            this.pnlDividerFiltros.Size = new System.Drawing.Size(1633, 2);
            this.pnlDividerFiltros.TabIndex = 6;

            // =========================================================
            // pnlContenido
            // =========================================================
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.White;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 200);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(40, 25, 40, 40);
            this.pnlContenido.Size = new System.Drawing.Size(1633, 824);
            this.pnlContenido.TabIndex = 2;
            this.pnlContenido.Controls.Add(this.dgvBitacora);

            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToResizeColumns = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.BackgroundColor = System.Drawing.Color.White;
            this.dgvBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvBitacora.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.dgvBitacora.ColumnHeadersHeight = 42;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBitacora.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvBitacora.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.dgvBitacora.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacora.EnableHeadersVisualStyles = false;
            this.dgvBitacora.GridColor = System.Drawing.Color.FromArgb(230, 233, 237);
            this.dgvBitacora.Location = new System.Drawing.Point(40, 25);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBitacora.RowTemplate.Height = 32;
            this.dgvBitacora.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(247, 249, 251);
            this.dgvBitacora.Size = new System.Drawing.Size(1553, 759);
            this.dgvBitacora.TabIndex = 0;

            // =========================================================
            // FrmBitacora
            // =========================================================
            // 
            // FrmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 1024);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmBitacora";
            this.Text = "Bitácora de Auditoría";
            this.Load += new System.EventHandler(this.FrmBitacora_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}