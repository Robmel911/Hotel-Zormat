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

        // ---- Controles originales (mismos nombres, para no romper el codebehind) ----
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvEstadias;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnVerHistrorial;

        // ---- Controles nuevos, solo decorativos/organizativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlToolbarGrid;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvEstadias = new System.Windows.Forms.DataGridView();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnVerHistrorial = new System.Windows.Forms.Button();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlToolbarGrid = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadias)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlToolbarGrid.SuspendLayout();
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

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Estadías";

            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(43, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(380, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Servicios, transferencias e historial de huéspedes";

            // =========================================================
            // pnlAcciones (columna derecha)
            // =========================================================
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(247, 249, 251);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAcciones.Location = new System.Drawing.Point(1353, 90);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(280, 934);
            this.pnlAcciones.TabIndex = 1;
            this.pnlAcciones.Controls.Add(this.btnAgregarServicio);
            this.pnlAcciones.Controls.Add(this.btnTransferir);
            this.pnlAcciones.Controls.Add(this.btnVerHistrorial);

            // 
            // btnAgregarServicio (accion primaria: azul Zormat)
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnAgregarServicio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarServicio.Location = new System.Drawing.Point(30, 30);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(220, 52);
            this.btnAgregarServicio.TabIndex = 0;
            this.btnAgregarServicio.Text = "+  Agregar Servicio";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);

            // 
            // btnTransferir (accion secundaria: contorno navy)
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.White;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnTransferir.FlatAppearance.BorderSize = 2;
            this.btnTransferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            this.btnTransferir.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnTransferir.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnTransferir.Location = new System.Drawing.Point(30, 96);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(220, 52);
            this.btnTransferir.TabIndex = 1;
            this.btnTransferir.Text = "Transferir Habitación";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);

            // 
            // btnVerHistrorial (informativo: navy solido)
            // 
            this.btnVerHistrorial.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnVerHistrorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHistrorial.FlatAppearance.BorderSize = 0;
            this.btnVerHistrorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnVerHistrorial.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerHistrorial.ForeColor = System.Drawing.Color.White;
            this.btnVerHistrorial.Location = new System.Drawing.Point(30, 162);
            this.btnVerHistrorial.Name = "btnVerHistrorial";
            this.btnVerHistrorial.Size = new System.Drawing.Size(220, 56);
            this.btnVerHistrorial.TabIndex = 2;
            this.btnVerHistrorial.Text = "Ver Historial de Huéspedes";
            this.btnVerHistrorial.UseVisualStyleBackColor = false;
            this.btnVerHistrorial.Click += new System.EventHandler(this.btnVerHistrorial_Click);

            // =========================================================
            // pnlGrid (toolbar + tabla)
            // =========================================================
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 90);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(40, 20, 30, 40);
            this.pnlGrid.Size = new System.Drawing.Size(1353, 934);
            this.pnlGrid.TabIndex = 2;
            this.pnlGrid.Controls.Add(this.dgvEstadias);
            this.pnlGrid.Controls.Add(this.pnlToolbarGrid);

            // 
            // pnlToolbarGrid (contiene el boton de actualizar, alineado a la derecha)
            // 
            this.pnlToolbarGrid.BackColor = System.Drawing.Color.White;
            this.pnlToolbarGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbarGrid.Location = new System.Drawing.Point(40, 20);
            this.pnlToolbarGrid.Name = "pnlToolbarGrid";
            this.pnlToolbarGrid.Size = new System.Drawing.Size(1283, 60);
            this.pnlToolbarGrid.TabIndex = 0;
            this.pnlToolbarGrid.Controls.Add(this.btnActualizar);

            // 
            // btnActualizar (boton pequeño, contorno navy, alineado a la derecha)
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnActualizar.Location = new System.Drawing.Point(1113, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(170, 42);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "⟳  Actualizar Lista";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // 
            // dgvEstadias
            // 
            this.dgvEstadias.AllowUserToAddRows = false;
            this.dgvEstadias.AllowUserToDeleteRows = false;
            this.dgvEstadias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstadias.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstadias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstadias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEstadias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstadias.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.dgvEstadias.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEstadias.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvEstadias.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.dgvEstadias.ColumnHeadersHeight = 42;
            this.dgvEstadias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEstadias.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvEstadias.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.dgvEstadias.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEstadias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstadias.EnableHeadersVisualStyles = false;
            this.dgvEstadias.GridColor = System.Drawing.Color.FromArgb(230, 233, 237);
            this.dgvEstadias.Location = new System.Drawing.Point(40, 80);
            this.dgvEstadias.Name = "dgvEstadias";
            this.dgvEstadias.ReadOnly = true;
            this.dgvEstadias.RowHeadersVisible = false;
            this.dgvEstadias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEstadias.RowTemplate.Height = 32;
            this.dgvEstadias.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(247, 249, 251);
            this.dgvEstadias.Size = new System.Drawing.Size(1283, 814);
            this.dgvEstadias.TabIndex = 1;

            // =========================================================
            // FrmGestionEstadias
            // =========================================================
            // 
            // FrmGestionEstadias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 1024);
            // Orden importante: pnlGrid primero (Fill), luego pnlAcciones (Right), luego pnlHeader (Top).
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmGestionEstadias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Estadías";
            this.Load += new System.EventHandler(this.FrmGestionEstadias_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadias)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlToolbarGrid.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}