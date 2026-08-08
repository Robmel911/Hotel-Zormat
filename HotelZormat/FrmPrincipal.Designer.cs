namespace HotelZormat
{
    partial class FrmPrincipal
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMenuHabitaciones = new System.Windows.Forms.Button();
            this.pnSubmenuHabitaciones = new System.Windows.Forms.Panel();
            this.btnAdministarHabitaciones = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnMenuHuespedes = new System.Windows.Forms.Button();
            this.pnSubmenuHuespedes = new System.Windows.Forms.Panel();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.btnGestionHuespedes = new System.Windows.Forms.Button();
            this.btnMenuReservas = new System.Windows.Forms.Button();
            this.pnSubmenuReservas = new System.Windows.Forms.Panel();
            this.btnGestionReservas = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.pnBarraLateral = new System.Windows.Forms.Panel();
            this.btnEstadias = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnSubMenuInicio = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnSubmenuHabitaciones.SuspendLayout();
            this.pnSubmenuHuespedes.SuspendLayout();
            this.pnSubmenuReservas.SuspendLayout();
            this.pnBarraLateral.SuspendLayout();
            this.pnSubMenuInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::HotelZormat.UI.Properties.Resources.Logo_oscuro_transparente;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(265, 140);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(265, 55);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenuHabitaciones
            // 
            this.btnMenuHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnMenuHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnMenuHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnMenuHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuHabitaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMenuHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnMenuHabitaciones.Location = new System.Drawing.Point(0, 251);
            this.btnMenuHabitaciones.Name = "btnMenuHabitaciones";
            this.btnMenuHabitaciones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuHabitaciones.Size = new System.Drawing.Size(265, 60);
            this.btnMenuHabitaciones.TabIndex = 2;
            this.btnMenuHabitaciones.Text = "Habitaciones";
            this.btnMenuHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHabitaciones.UseVisualStyleBackColor = false;
            this.btnMenuHabitaciones.Click += new System.EventHandler(this.btnMenuHabitaciones_Click);
            // 
            // pnSubmenuHabitaciones
            // 
            this.pnSubmenuHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnSubmenuHabitaciones.Controls.Add(this.btnAdministarHabitaciones);
            this.pnSubmenuHabitaciones.Controls.Add(this.btnGestion);
            this.pnSubmenuHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubmenuHabitaciones.Location = new System.Drawing.Point(0, 311);
            this.pnSubmenuHabitaciones.Name = "pnSubmenuHabitaciones";
            this.pnSubmenuHabitaciones.Size = new System.Drawing.Size(265, 100);
            this.pnSubmenuHabitaciones.TabIndex = 3;
            this.pnSubmenuHabitaciones.Visible = false;
            // 
            // btnAdministarHabitaciones
            // 
            this.btnAdministarHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.btnAdministarHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministarHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnAdministarHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnAdministarHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministarHabitaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdministarHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnAdministarHabitaciones.Location = new System.Drawing.Point(0, 50);
            this.btnAdministarHabitaciones.Name = "btnAdministarHabitaciones";
            this.btnAdministarHabitaciones.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdministarHabitaciones.Size = new System.Drawing.Size(265, 50);
            this.btnAdministarHabitaciones.TabIndex = 1;
            this.btnAdministarHabitaciones.Text = "Administar Habitaciones";
            this.btnAdministarHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministarHabitaciones.UseVisualStyleBackColor = false;
            this.btnAdministarHabitaciones.Click += new System.EventHandler(this.btnAdministrarHabitaciones_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGestion.ForeColor = System.Drawing.Color.White;
            this.btnGestion.Location = new System.Drawing.Point(0, 0);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGestion.Size = new System.Drawing.Size(265, 50);
            this.btnGestion.TabIndex = 0;
            this.btnGestion.Text = "Gestión Habitaciones";
            this.btnGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.UseVisualStyleBackColor = false;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnMenuHuespedes
            // 
            this.btnMenuHuespedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnMenuHuespedes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuHuespedes.FlatAppearance.BorderSize = 0;
            this.btnMenuHuespedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnMenuHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuHuespedes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMenuHuespedes.ForeColor = System.Drawing.Color.White;
            this.btnMenuHuespedes.Location = new System.Drawing.Point(0, 411);
            this.btnMenuHuespedes.Name = "btnMenuHuespedes";
            this.btnMenuHuespedes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuHuespedes.Size = new System.Drawing.Size(265, 60);
            this.btnMenuHuespedes.TabIndex = 4;
            this.btnMenuHuespedes.Text = "Huéspedes";
            this.btnMenuHuespedes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuHuespedes.UseVisualStyleBackColor = false;
            this.btnMenuHuespedes.Click += new System.EventHandler(this.btnMenuHuespedes_Click);
            // 
            // pnSubmenuHuespedes
            // 
            this.pnSubmenuHuespedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnSubmenuHuespedes.Controls.Add(this.btnVerHistorial);
            this.pnSubmenuHuespedes.Controls.Add(this.btnGestionHuespedes);
            this.pnSubmenuHuespedes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubmenuHuespedes.Location = new System.Drawing.Point(0, 471);
            this.pnSubmenuHuespedes.Name = "pnSubmenuHuespedes";
            this.pnSubmenuHuespedes.Size = new System.Drawing.Size(265, 100);
            this.pnSubmenuHuespedes.TabIndex = 5;
            this.pnSubmenuHuespedes.Visible = false;
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.btnVerHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerHistorial.FlatAppearance.BorderSize = 0;
            this.btnVerHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnVerHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHistorial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVerHistorial.ForeColor = System.Drawing.Color.White;
            this.btnVerHistorial.Location = new System.Drawing.Point(0, 50);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVerHistorial.Size = new System.Drawing.Size(265, 50);
            this.btnVerHistorial.TabIndex = 1;
            this.btnVerHistorial.Text = "Historial de visitas";
            this.btnVerHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerHistorial.UseVisualStyleBackColor = false;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnBuscarHuesped_Click);
            // 
            // btnGestionHuespedes
            // 
            this.btnGestionHuespedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.btnGestionHuespedes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionHuespedes.FlatAppearance.BorderSize = 0;
            this.btnGestionHuespedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnGestionHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionHuespedes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGestionHuespedes.ForeColor = System.Drawing.Color.White;
            this.btnGestionHuespedes.Location = new System.Drawing.Point(0, 0);
            this.btnGestionHuespedes.Name = "btnGestionHuespedes";
            this.btnGestionHuespedes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGestionHuespedes.Size = new System.Drawing.Size(265, 50);
            this.btnGestionHuespedes.TabIndex = 0;
            this.btnGestionHuespedes.Text = "Gestión Huéspedes";
            this.btnGestionHuespedes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionHuespedes.UseVisualStyleBackColor = false;
            this.btnGestionHuespedes.Click += new System.EventHandler(this.btnGestionHuespedes_Click);
            // 
            // btnMenuReservas
            // 
            this.btnMenuReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnMenuReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuReservas.FlatAppearance.BorderSize = 0;
            this.btnMenuReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnMenuReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReservas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMenuReservas.ForeColor = System.Drawing.Color.White;
            this.btnMenuReservas.Location = new System.Drawing.Point(0, 571);
            this.btnMenuReservas.Name = "btnMenuReservas";
            this.btnMenuReservas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuReservas.Size = new System.Drawing.Size(265, 60);
            this.btnMenuReservas.TabIndex = 6;
            this.btnMenuReservas.Text = "Reservas";
            this.btnMenuReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReservas.UseVisualStyleBackColor = false;
            this.btnMenuReservas.Click += new System.EventHandler(this.btnMenuReservas_Click);
            // 
            // pnSubmenuReservas
            // 
            this.pnSubmenuReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnSubmenuReservas.Controls.Add(this.btnGestionReservas);
            this.pnSubmenuReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubmenuReservas.Location = new System.Drawing.Point(0, 631);
            this.pnSubmenuReservas.Name = "pnSubmenuReservas";
            this.pnSubmenuReservas.Size = new System.Drawing.Size(265, 56);
            this.pnSubmenuReservas.TabIndex = 7;
            this.pnSubmenuReservas.Visible = false;
            // 
            // btnGestionReservas
            // 
            this.btnGestionReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.btnGestionReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionReservas.FlatAppearance.BorderSize = 0;
            this.btnGestionReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnGestionReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionReservas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGestionReservas.ForeColor = System.Drawing.Color.White;
            this.btnGestionReservas.Location = new System.Drawing.Point(0, 0);
            this.btnGestionReservas.Name = "btnGestionReservas";
            this.btnGestionReservas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGestionReservas.Size = new System.Drawing.Size(265, 50);
            this.btnGestionReservas.TabIndex = 0;
            this.btnGestionReservas.Text = "Gestión Reservas";
            this.btnGestionReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionReservas.UseVisualStyleBackColor = false;
            this.btnGestionReservas.Click += new System.EventHandler(this.btnGestionReservas_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Location = new System.Drawing.Point(0, 687);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFacturas.Size = new System.Drawing.Size(265, 60);
            this.btnFacturas.TabIndex = 8;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnBitacora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBitacora.FlatAppearance.BorderSize = 0;
            this.btnBitacora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBitacora.ForeColor = System.Drawing.Color.White;
            this.btnBitacora.Location = new System.Drawing.Point(0, 909);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBitacora.Size = new System.Drawing.Size(265, 55);
            this.btnBitacora.TabIndex = 9;
            this.btnBitacora.Text = "Bitácora";
            this.btnBitacora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // pnBarraLateral
            // 
            this.pnBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnBarraLateral.Controls.Add(this.btnBitacora);
            this.pnBarraLateral.Controls.Add(this.btnCerrarSesion);
            this.pnBarraLateral.Controls.Add(this.btnUsuarios);
            this.pnBarraLateral.Controls.Add(this.btnEstadias);
            this.pnBarraLateral.Controls.Add(this.btnFacturas);
            this.pnBarraLateral.Controls.Add(this.pnSubmenuReservas);
            this.pnBarraLateral.Controls.Add(this.btnMenuReservas);
            this.pnBarraLateral.Controls.Add(this.pnSubmenuHuespedes);
            this.pnBarraLateral.Controls.Add(this.btnMenuHuespedes);
            this.pnBarraLateral.Controls.Add(this.pnSubmenuHabitaciones);
            this.pnBarraLateral.Controls.Add(this.btnMenuHabitaciones);
            this.pnBarraLateral.Controls.Add(this.pnSubMenuInicio);
            this.pnBarraLateral.Controls.Add(this.btnHome);
            this.pnBarraLateral.Controls.Add(this.pbLogo);
            this.pnBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.pnBarraLateral.Name = "pnBarraLateral";
            this.pnBarraLateral.Size = new System.Drawing.Size(265, 1024);
            this.pnBarraLateral.TabIndex = 10;
            // 
            // btnEstadias
            // 
            this.btnEstadias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnEstadias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadias.FlatAppearance.BorderSize = 0;
            this.btnEstadias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnEstadias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEstadias.ForeColor = System.Drawing.Color.White;
            this.btnEstadias.Location = new System.Drawing.Point(0, 747);
            this.btnEstadias.Name = "btnEstadias";
            this.btnEstadias.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstadias.Size = new System.Drawing.Size(265, 60);
            this.btnEstadias.TabIndex = 10;
            this.btnEstadias.Text = "Estadias";
            this.btnEstadias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadias.UseVisualStyleBackColor = false;
            this.btnEstadias.Click += new System.EventHandler(this.btnEstadias_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(265, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1633, 1024);
            this.pnlContenedor.TabIndex = 11;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 807);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(265, 60);
            this.btnUsuarios.TabIndex = 11;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 964);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(265, 60);
            this.btnCerrarSesion.TabIndex = 12;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnSubMenuInicio
            // 
            this.pnSubMenuInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnSubMenuInicio.Controls.Add(this.btnReportes);
            this.pnSubMenuInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuInicio.Location = new System.Drawing.Point(0, 195);
            this.pnSubMenuInicio.Name = "pnSubMenuInicio";
            this.pnSubMenuInicio.Size = new System.Drawing.Size(265, 56);
            this.pnSubMenuInicio.TabIndex = 8;
            this.pnSubMenuInicio.Visible = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(0, 0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(265, 50);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnBarraLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Zormat - Sistema de Gestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnSubmenuHabitaciones.ResumeLayout(false);
            this.pnSubmenuHuespedes.ResumeLayout(false);
            this.pnSubmenuReservas.ResumeLayout(false);
            this.pnBarraLateral.ResumeLayout(false);
            this.pnSubMenuInicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnHome;

        private System.Windows.Forms.Button btnMenuHabitaciones;
        private System.Windows.Forms.Panel pnSubmenuHabitaciones;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnAdministarHabitaciones;

        private System.Windows.Forms.Button btnMenuHuespedes;
        private System.Windows.Forms.Panel pnSubmenuHuespedes;
        private System.Windows.Forms.Button btnGestionHuespedes;

        private System.Windows.Forms.Button btnMenuReservas;
        private System.Windows.Forms.Panel pnSubmenuReservas;
        private System.Windows.Forms.Button btnGestionReservas;

        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnBitacora;

        private System.Windows.Forms.Panel pnBarraLateral;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnEstadias;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnSubMenuInicio;
        private System.Windows.Forms.Button btnReportes;
    }
}