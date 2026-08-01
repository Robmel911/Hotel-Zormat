namespace HotelZormat.UI.Formularios
{
    partial class FrmGestionHuespedes
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
            this.components = new System.ComponentModel.Container();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstHuespedes = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(102, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(420, 34);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblBuscar.Location = new System.Drawing.Point(19, 17);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(77, 25);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(532, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 47);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "🔍︎";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstHuespedes
            // 
            this.lstHuespedes.BackColor = System.Drawing.Color.White;
            this.lstHuespedes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHuespedes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHuespedes.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lstHuespedes.FormattingEnabled = true;
            this.lstHuespedes.IntegralHeight = false;
            this.lstHuespedes.ItemHeight = 30;
            this.lstHuespedes.Location = new System.Drawing.Point(40, 84);
            this.lstHuespedes.Name = "lstHuespedes";
            this.lstHuespedes.Size = new System.Drawing.Size(1283, 810);
            this.lstHuespedes.TabIndex = 1;
            this.lstHuespedes.SelectedIndexChanged += new System.EventHandler(this.lstHuespedes_SelectedIndexChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnEditar.Location = new System.Drawing.Point(30, 96);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(220, 50);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(30, 30);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(220, 50);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "+  Nuevo Huésped";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(30, 162);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(220, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1633, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(393, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de Huéspedes";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubtitulo.Location = new System.Drawing.Point(43, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(437, 25);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Busca, crea y administra los huéspedes registrados";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAcciones.Location = new System.Drawing.Point(1353, 90);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(280, 934);
            this.pnlAcciones.TabIndex = 1;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.lstHuespedes);
            this.pnlGrid.Controls.Add(this.pnlBusqueda);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 90);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(40, 20, 30, 40);
            this.pnlGrid.Size = new System.Drawing.Size(1353, 934);
            this.pnlGrid.TabIndex = 2;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.Controls.Add(this.lblBuscar);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(40, 20);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(1283, 64);
            this.pnlBusqueda.TabIndex = 0;
            // 
            // FrmGestionHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1633, 1024);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmGestionHuespedes";
            this.Text = "Gestión de Huéspedes";
            this.Load += new System.EventHandler(this.FrmGestionHuespedes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstHuespedes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;

        // ---- Controles nuevos, solo decorativos/organizativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlBusqueda;
    }
}