namespace HotelZormat.UI.Formularios
{
    partial class FrmAdministrarHabitaciones
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
        private System.Windows.Forms.FlowLayoutPanel flpHabitaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;

        // ---- Controles nuevos, solo decorativos/organizativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblBadgeAdmin;
        private System.Windows.Forms.Panel pnlDividerToolbar;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flpHabitaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBadgeAdmin = new System.Windows.Forms.Label();
            this.pnlDividerToolbar = new System.Windows.Forms.Panel();

            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
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
            this.lblTitulo.Size = new System.Drawing.Size(320, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Administrar Habitaciones";

            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(43, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(340, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Agrega, modifica o elimina habitaciones del hotel";

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
            // panel1 (barra de herramientas: Agregar / Modificar / Eliminar)
            // =========================================================
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.pnlDividerToolbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1633, 90);
            this.panel1.TabIndex = 1;

            // 
            // btnAgregar (accion primaria: azul Zormat)
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(40, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(200, 44);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "+  Agregar Habitación";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // 
            // btnModificar (accion secundaria: contorno navy)
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnModificar.Location = new System.Drawing.Point(260, 23);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(200, 44);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);

            // 
            // btnEliminar (accion destructiva: rojo)
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(220, 68, 68);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 45, 45);
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(480, 23);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 44);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // 
            // pnlDividerToolbar
            // 
            this.pnlDividerToolbar.BackColor = System.Drawing.Color.FromArgb(225, 228, 232);
            this.pnlDividerToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDividerToolbar.Location = new System.Drawing.Point(0, 88);
            this.pnlDividerToolbar.Name = "pnlDividerToolbar";
            this.pnlDividerToolbar.Size = new System.Drawing.Size(1633, 2);
            this.pnlDividerToolbar.TabIndex = 3;

            // =========================================================
            // flpHabitaciones (tablero de tarjetas - NO tocar logica de contenido)
            // =========================================================
            // 
            // flpHabitaciones
            // 
            this.flpHabitaciones.AutoScroll = true;
            this.flpHabitaciones.BackColor = System.Drawing.Color.FromArgb(247, 249, 251);
            this.flpHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHabitaciones.Location = new System.Drawing.Point(0, 180);
            this.flpHabitaciones.Name = "flpHabitaciones";
            this.flpHabitaciones.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.flpHabitaciones.Size = new System.Drawing.Size(1633, 844);
            this.flpHabitaciones.TabIndex = 2;

            // =========================================================
            // FrmAdministrarHabitaciones
            // =========================================================
            // 
            // FrmAdministrarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 1024);
            // Orden importante: flpHabitaciones primero (Fill), luego panel1 (Top), luego pnlHeader (Top).
            this.Controls.Add(this.flpHabitaciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmAdministrarHabitaciones";
            this.Text = "Administrar Habitaciones";
            this.Load += new System.EventHandler(this.FrmAdministrarHabitaciones_Load);

            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}