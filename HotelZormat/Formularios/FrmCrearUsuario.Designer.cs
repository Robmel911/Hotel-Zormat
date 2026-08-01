namespace HotelZormat.UI.Formularios
{
    partial class FrmCrearUsuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // ---- Controles originales (mismos nombres, para no romper el codebehind) ----
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.CheckBox chkCambiarContrasena;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider epCrearUsuario;

        // ---- Controles nuevos, solo decorativos ----
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblTituloVentana;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.chkCambiarContrasena = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.epCrearUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epCrearUsuario)).BeginInit();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblNombre.Location = new System.Drawing.Point(30, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(192, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre de Usuario:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(30, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 34);
            this.txtNombre.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTipo.Location = new System.Drawing.Point(30, 142);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(46, 25);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Rol:";
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTipoUsuario.Location = new System.Drawing.Point(30, 168);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(320, 36);
            this.cboTipoUsuario.TabIndex = 4;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblContrasena.Location = new System.Drawing.Point(30, 242);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(118, 25);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContrasena.Location = new System.Drawing.Point(30, 268);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(320, 34);
            this.txtContrasena.TabIndex = 7;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblConfirmar.Location = new System.Drawing.Point(30, 308);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(214, 25);
            this.lblConfirmar.TabIndex = 8;
            this.lblConfirmar.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(30, 334);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(320, 34);
            this.txtConfirmarContrasena.TabIndex = 9;
            this.txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // chkCambiarContrasena
            // 
            this.chkCambiarContrasena.AutoSize = true;
            this.chkCambiarContrasena.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkCambiarContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.chkCambiarContrasena.Location = new System.Drawing.Point(30, 212);
            this.chkCambiarContrasena.Name = "chkCambiarContrasena";
            this.chkCambiarContrasena.Size = new System.Drawing.Size(207, 29);
            this.chkCambiarContrasena.TabIndex = 5;
            this.chkCambiarContrasena.Text = "Cambiar contraseña";
            this.chkCambiarContrasena.CheckedChanged += new System.EventHandler(this.chkCambiarContrasena_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(30, 388);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 46);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnCancelar.Location = new System.Drawing.Point(200, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 46);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // epCrearUsuario
            // 
            this.epCrearUsuario.ContainerControl = this;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.lblTituloVentana);
            this.panelCard.Controls.Add(this.lblNombre);
            this.panelCard.Controls.Add(this.txtNombre);
            this.panelCard.Controls.Add(this.lblTipo);
            this.panelCard.Controls.Add(this.cboTipoUsuario);
            this.panelCard.Controls.Add(this.chkCambiarContrasena);
            this.panelCard.Controls.Add(this.lblContrasena);
            this.panelCard.Controls.Add(this.txtContrasena);
            this.panelCard.Controls.Add(this.lblConfirmar);
            this.panelCard.Controls.Add(this.txtConfirmarContrasena);
            this.panelCard.Controls.Add(this.btnGuardar);
            this.panelCard.Controls.Add(this.btnCancelar);
            this.panelCard.Location = new System.Drawing.Point(40, 30);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(380, 450);
            this.panelCard.TabIndex = 0;
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblTituloVentana.Location = new System.Drawing.Point(0, 24);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(380, 32);
            this.lblTituloVentana.TabIndex = 0;
            this.lblTituloVentana.Text = "Crear Usuario";
            this.lblTituloVentana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCrearUsuario
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(460, 510);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.FrmCrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCrearUsuario)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}