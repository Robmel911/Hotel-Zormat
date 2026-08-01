namespace HotelZormat.UI.Formularios
{
    partial class FrmCrearHuesped
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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.ComboBox cboNacionalidad;
        private System.Windows.Forms.Label lblNacionalidadEspecifica;
        private System.Windows.Forms.TextBox txtNacionalidadEspecifica;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.MaskedTextBox txtNumeroDocumento;

        // ---- Controles nuevos, solo decorativos ----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloVentana;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.cboNacionalidad = new System.Windows.Forms.ComboBox();
            this.lblNacionalidadEspecifica = new System.Windows.Forms.Label();
            this.txtNacionalidadEspecifica = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNumeroDocumento = new System.Windows.Forms.MaskedTextBox();

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTituloVentana = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(675, 80);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblTituloVentana);

            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(40, 24);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(220, 30);
            this.lblTituloVentana.TabIndex = 0;
            this.lblTituloVentana.Text = "Registrar Huésped";

            // =========================================================
            // Campos del formulario
            // =========================================================
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblNombre.Location = new System.Drawing.Point(45, 108);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";

            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(270, 104);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(328, 30);
            this.txtNombre.TabIndex = 2;

            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblApellido.Location = new System.Drawing.Point(45, 162);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";

            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellido.Location = new System.Drawing.Point(270, 158);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(328, 30);
            this.txtApellido.TabIndex = 4;

            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTipoDocumento.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTipoDocumento.Location = new System.Drawing.Point(45, 216);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(127, 20);
            this.lblTipoDocumento.TabIndex = 5;
            this.lblTipoDocumento.Text = "Tipo documento:";

            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTipoDocumento.Location = new System.Drawing.Point(270, 212);
            this.cboTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(328, 30);
            this.cboTipoDocumento.TabIndex = 6;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);

            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNumeroDocumento.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblNumeroDocumento.Location = new System.Drawing.Point(45, 270);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(153, 20);
            this.lblNumeroDocumento.TabIndex = 7;
            this.lblNumeroDocumento.Text = "Número documento:";

            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroDocumento.Location = new System.Drawing.Point(270, 264);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(328, 30);
            this.txtNumeroDocumento.TabIndex = 8;

            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNacionalidad.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblNacionalidad.Location = new System.Drawing.Point(45, 324);
            this.lblNacionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(104, 20);
            this.lblNacionalidad.TabIndex = 9;
            this.lblNacionalidad.Text = "Nacionalidad:";

            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacionalidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNacionalidad.Location = new System.Drawing.Point(270, 319);
            this.cboNacionalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(328, 30);
            this.cboNacionalidad.TabIndex = 10;
            this.cboNacionalidad.SelectedIndexChanged += new System.EventHandler(this.cboNacionalidad_SelectedIndexChanged);

            // 
            // lblNacionalidadEspecifica
            // 
            this.lblNacionalidadEspecifica.AutoSize = true;
            this.lblNacionalidadEspecifica.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNacionalidadEspecifica.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblNacionalidadEspecifica.Location = new System.Drawing.Point(45, 378);
            this.lblNacionalidadEspecifica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidadEspecifica.Name = "lblNacionalidadEspecifica";
            this.lblNacionalidadEspecifica.Size = new System.Drawing.Size(91, 20);
            this.lblNacionalidadEspecifica.TabIndex = 11;
            this.lblNacionalidadEspecifica.Text = "Especificar:";

            // 
            // txtNacionalidadEspecifica
            // 
            this.txtNacionalidadEspecifica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidadEspecifica.Enabled = false;
            this.txtNacionalidadEspecifica.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNacionalidadEspecifica.Location = new System.Drawing.Point(270, 373);
            this.txtNacionalidadEspecifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNacionalidadEspecifica.MaxLength = 50;
            this.txtNacionalidadEspecifica.Name = "txtNacionalidadEspecifica";
            this.txtNacionalidadEspecifica.Size = new System.Drawing.Size(328, 30);
            this.txtNacionalidadEspecifica.TabIndex = 12;

            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblTelefono.Location = new System.Drawing.Point(45, 432);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono:";

            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(270, 427);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(328, 30);
            this.txtTelefono.TabIndex = 14;

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.lblEmail.Location = new System.Drawing.Point(45, 485);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";

            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(270, 481);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 30);
            this.txtEmail.TabIndex = 16;

            // =========================================================
            // Botones
            // =========================================================
            // 
            // btnGuardar (accion primaria: azul Zormat)
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(30, 144, 255);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(270, 562);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 46);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // 
            // btnCancelar (accion secundaria: contorno navy)
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(13, 27, 42);
            this.btnCancelar.Location = new System.Drawing.Point(450, 562);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 46);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // 
            // ep
            // 
            this.ep.ContainerControl = this;

            // =========================================================
            // FrmCrearHuesped
            // =========================================================
            // 
            // FrmCrearHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AcceptButton = this.btnGuardar;
            this.CancelButton = this.btnCancelar;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 670);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.cboNacionalidad);
            this.Controls.Add(this.lblNacionalidadEspecifica);
            this.Controls.Add(this.txtNacionalidadEspecifica);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearHuesped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Huésped";
            this.Load += new System.EventHandler(this.FrmCrearHuesped_Load);

            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}