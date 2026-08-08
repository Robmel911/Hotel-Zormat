namespace HotelZormat.UI.Formularios
{
    partial class FrmInfoHabitacion
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
        private System.Windows.Forms.Label lblTituloNumero;
        private System.Windows.Forms.Label lblEtiquetaTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEtiquetaPiso;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblEtiquetaCapacidad;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblEtiquetaTarifa;
        private System.Windows.Forms.Label lblTarifaBase;
        private System.Windows.Forms.Label lblEtiquetaEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCerrar;

        // ---- Controles nuevos, solo decorativos ----
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel pnlAcentoTitulo;
        private System.Windows.Forms.Panel pnlEstadoBadge;

        private void InitializeComponent()
        {
            this.lblTituloNumero = new System.Windows.Forms.Label();
            this.lblEtiquetaTipo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEtiquetaPiso = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblEtiquetaCapacidad = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblEtiquetaTarifa = new System.Windows.Forms.Label();
            this.lblTarifaBase = new System.Windows.Forms.Label();
            this.lblEtiquetaEstado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelCard = new System.Windows.Forms.Panel();
            this.pnlAcentoTitulo = new System.Windows.Forms.Panel();
            this.pnlEstadoBadge = new System.Windows.Forms.Panel();
            this.panelCard.SuspendLayout();
            this.pnlEstadoBadge.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloNumero
            // 
            this.lblTituloNumero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloNumero.Location = new System.Drawing.Point(0, 0);
            this.lblTituloNumero.Name = "lblTituloNumero";
            this.lblTituloNumero.Size = new System.Drawing.Size(320, 85);
            this.lblTituloNumero.TabIndex = 0;
            this.lblTituloNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEtiquetaTipo
            // 
            this.lblEtiquetaTipo.AutoSize = true;
            this.lblEtiquetaTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEtiquetaTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblEtiquetaTipo.Location = new System.Drawing.Point(30, 122);
            this.lblEtiquetaTipo.Name = "lblEtiquetaTipo";
            this.lblEtiquetaTipo.Size = new System.Drawing.Size(57, 25);
            this.lblEtiquetaTipo.TabIndex = 2;
            this.lblEtiquetaTipo.Text = "Tipo:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTipo.Location = new System.Drawing.Point(150, 122);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 25);
            this.lblTipo.TabIndex = 3;
            // 
            // lblEtiquetaPiso
            // 
            this.lblEtiquetaPiso.AutoSize = true;
            this.lblEtiquetaPiso.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEtiquetaPiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblEtiquetaPiso.Location = new System.Drawing.Point(30, 164);
            this.lblEtiquetaPiso.Name = "lblEtiquetaPiso";
            this.lblEtiquetaPiso.Size = new System.Drawing.Size(54, 25);
            this.lblEtiquetaPiso.TabIndex = 4;
            this.lblEtiquetaPiso.Text = "Piso:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPiso.Location = new System.Drawing.Point(150, 164);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(0, 25);
            this.lblPiso.TabIndex = 5;
            // 
            // lblEtiquetaCapacidad
            // 
            this.lblEtiquetaCapacidad.AutoSize = true;
            this.lblEtiquetaCapacidad.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEtiquetaCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblEtiquetaCapacidad.Location = new System.Drawing.Point(30, 206);
            this.lblEtiquetaCapacidad.Name = "lblEtiquetaCapacidad";
            this.lblEtiquetaCapacidad.Size = new System.Drawing.Size(109, 25);
            this.lblEtiquetaCapacidad.TabIndex = 6;
            this.lblEtiquetaCapacidad.Text = "Capacidad:";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCapacidad.Location = new System.Drawing.Point(150, 206);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(0, 25);
            this.lblCapacidad.TabIndex = 7;
            // 
            // lblEtiquetaTarifa
            // 
            this.lblEtiquetaTarifa.AutoSize = true;
            this.lblEtiquetaTarifa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEtiquetaTarifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblEtiquetaTarifa.Location = new System.Drawing.Point(30, 248);
            this.lblEtiquetaTarifa.Name = "lblEtiquetaTarifa";
            this.lblEtiquetaTarifa.Size = new System.Drawing.Size(111, 25);
            this.lblEtiquetaTarifa.TabIndex = 8;
            this.lblEtiquetaTarifa.Text = "Tarifa Base:";
            // 
            // lblTarifaBase
            // 
            this.lblTarifaBase.AutoSize = true;
            this.lblTarifaBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTarifaBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.lblTarifaBase.Location = new System.Drawing.Point(150, 244);
            this.lblTarifaBase.Name = "lblTarifaBase";
            this.lblTarifaBase.Size = new System.Drawing.Size(0, 32);
            this.lblTarifaBase.TabIndex = 9;
            // 
            // lblEtiquetaEstado
            // 
            this.lblEtiquetaEstado.AutoSize = true;
            this.lblEtiquetaEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEtiquetaEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblEtiquetaEstado.Location = new System.Drawing.Point(30, 298);
            this.lblEtiquetaEstado.Name = "lblEtiquetaEstado";
            this.lblEtiquetaEstado.Size = new System.Drawing.Size(76, 25);
            this.lblEtiquetaEstado.TabIndex = 10;
            this.lblEtiquetaEstado.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblEstado.Location = new System.Drawing.Point(0, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(140, 34);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(85, 352);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 46);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.lblTituloNumero);
            this.panelCard.Controls.Add(this.pnlAcentoTitulo);
            this.panelCard.Controls.Add(this.lblEtiquetaTipo);
            this.panelCard.Controls.Add(this.lblTipo);
            this.panelCard.Controls.Add(this.lblEtiquetaPiso);
            this.panelCard.Controls.Add(this.lblPiso);
            this.panelCard.Controls.Add(this.lblEtiquetaCapacidad);
            this.panelCard.Controls.Add(this.lblCapacidad);
            this.panelCard.Controls.Add(this.lblEtiquetaTarifa);
            this.panelCard.Controls.Add(this.lblTarifaBase);
            this.panelCard.Controls.Add(this.lblEtiquetaEstado);
            this.panelCard.Controls.Add(this.pnlEstadoBadge);
            this.panelCard.Controls.Add(this.btnCerrar);
            this.panelCard.Location = new System.Drawing.Point(30, 30);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(320, 420);
            this.panelCard.TabIndex = 0;
            // 
            // pnlAcentoTitulo
            // 
            this.pnlAcentoTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pnlAcentoTitulo.Location = new System.Drawing.Point(8, 88);
            this.pnlAcentoTitulo.Name = "pnlAcentoTitulo";
            this.pnlAcentoTitulo.Size = new System.Drawing.Size(300, 4);
            this.pnlAcentoTitulo.TabIndex = 1;
            // 
            // pnlEstadoBadge
            // 
            this.pnlEstadoBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.pnlEstadoBadge.Controls.Add(this.lblEstado);
            this.pnlEstadoBadge.Location = new System.Drawing.Point(150, 290);
            this.pnlEstadoBadge.Name = "pnlEstadoBadge";
            this.pnlEstadoBadge.Size = new System.Drawing.Size(140, 34);
            this.pnlEstadoBadge.TabIndex = 10;
            // 
            // FrmInfoHabitacion
            // 
            this.AcceptButton = this.btnCerrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(380, 480);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInfoHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de Habitación";
            this.Load += new System.EventHandler(this.FrmInfoHabitacion_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.pnlEstadoBadge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}