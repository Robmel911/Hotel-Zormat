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
            ((System.ComponentModel.ISupportInitialize)(this.epCrearUsuario)).BeginInit();
            this.SuspendLayout();

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Text = "Nombre de usuario:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(160, 17);
            this.txtNombre.Size = new System.Drawing.Size(200, 20);

            // lblTipo
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(20, 55);
            this.lblTipo.Text = "Rol:";

            // cboTipoUsuario
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.Location = new System.Drawing.Point(160, 52);
            this.cboTipoUsuario.Size = new System.Drawing.Size(200, 21);

            // chkCambiarContrasena (solo visible/relevante en modo Modificar)
            this.chkCambiarContrasena.AutoSize = true;
            this.chkCambiarContrasena.Location = new System.Drawing.Point(160, 85);
            this.chkCambiarContrasena.Text = "Cambiar contrasena";
            this.chkCambiarContrasena.CheckedChanged += new System.EventHandler(this.chkCambiarContrasena_CheckedChanged);

            // lblContrasena
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(20, 115);
            this.lblContrasena.Text = "Contrasena:";

            // txtContrasena
            this.txtContrasena.Location = new System.Drawing.Point(160, 112);
            this.txtContrasena.Size = new System.Drawing.Size(200, 20);
            this.txtContrasena.UseSystemPasswordChar = true;

            // lblConfirmar
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(20, 150);
            this.lblConfirmar.Text = "Confirmar:";

            // txtConfirmarContrasena
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(160, 147);
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(200, 20);
            this.txtConfirmarContrasena.UseSystemPasswordChar = true;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(160, 190);
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(270, 190);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FrmCrearUsuario
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboTipoUsuario);
            this.Controls.Add(this.chkCambiarContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "FrmCrearUsuario";
            this.Load += new System.EventHandler(this.FrmCrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCrearUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}