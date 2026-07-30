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
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 38);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(270, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(328, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(45, 92);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(270, 88);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(328, 26);
            this.txtApellido.TabIndex = 3;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(45, 146);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(127, 20);
            this.lblTipoDocumento.TabIndex = 4;
            this.lblTipoDocumento.Text = "Tipo documento:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.Location = new System.Drawing.Point(270, 142);
            this.cboTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(328, 28);
            this.cboTipoDocumento.TabIndex = 5;
            this.cboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cboTipoDocumento_SelectedIndexChanged);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(45, 200);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(153, 20);
            this.lblNumeroDocumento.TabIndex = 6;
            this.lblNumeroDocumento.Text = "Numero documento:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(45, 254);
            this.lblNacionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(104, 20);
            this.lblNacionalidad.TabIndex = 8;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacionalidad.Location = new System.Drawing.Point(270, 249);
            this.cboNacionalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(328, 28);
            this.cboNacionalidad.TabIndex = 9;
            this.cboNacionalidad.SelectedIndexChanged += new System.EventHandler(this.cboNacionalidad_SelectedIndexChanged);
            // 
            // lblNacionalidadEspecifica
            // 
            this.lblNacionalidadEspecifica.AutoSize = true;
            this.lblNacionalidadEspecifica.Location = new System.Drawing.Point(45, 308);
            this.lblNacionalidadEspecifica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacionalidadEspecifica.Name = "lblNacionalidadEspecifica";
            this.lblNacionalidadEspecifica.Size = new System.Drawing.Size(91, 20);
            this.lblNacionalidadEspecifica.TabIndex = 10;
            this.lblNacionalidadEspecifica.Text = "Especificar:";
            // 
            // txtNacionalidadEspecifica
            // 
            this.txtNacionalidadEspecifica.Enabled = false;
            this.txtNacionalidadEspecifica.Location = new System.Drawing.Point(270, 303);
            this.txtNacionalidadEspecifica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNacionalidadEspecifica.MaxLength = 50;
            this.txtNacionalidadEspecifica.Name = "txtNacionalidadEspecifica";
            this.txtNacionalidadEspecifica.Size = new System.Drawing.Size(328, 26);
            this.txtNacionalidadEspecifica.TabIndex = 11;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(45, 362);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(75, 20);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(270, 357);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(328, 26);
            this.txtTelefono.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(45, 415);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(270, 411);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(270, 492);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 46);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(450, 492);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 46);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(270, 194);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(328, 26);
            this.txtNumeroDocumento.TabIndex = 18;
            // 
            // FrmCrearHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 600);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearHuesped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Huesped";
            this.Load += new System.EventHandler(this.FrmCrearHuesped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

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
    }
}