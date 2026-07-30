namespace HotelZormat.UI.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.epLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCard = new System.Windows.Forms.Panel();
            this.pbLogoLogin = new System.Windows.Forms.PictureBox();
            this.lblNombreHotel = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epLogin)).BeginInit();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // epLogin
            // 
            this.epLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLogin.ContainerControl = this;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.pbLogoLogin);
            this.panelCard.Controls.Add(this.lblNombreHotel);
            this.panelCard.Controls.Add(this.lblSlogan);
            this.panelCard.Controls.Add(this.lblUsuario);
            this.panelCard.Controls.Add(this.txtUsuario);
            this.panelCard.Controls.Add(this.lblContrasena);
            this.panelCard.Controls.Add(this.txtContrasena);
            this.panelCard.Controls.Add(this.btnLogin);
            this.panelCard.Location = new System.Drawing.Point(40, 40);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(340, 470);
            this.panelCard.TabIndex = 0;
            // 
            // pbLogoLogin
            // 
            this.pbLogoLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoLogin.Image = global::HotelZormat.Properties.Resources.Logo_Solo_Edificio;
            this.pbLogoLogin.Location = new System.Drawing.Point(71, 15);
            this.pbLogoLogin.Name = "pbLogoLogin";
            this.pbLogoLogin.Size = new System.Drawing.Size(194, 143);
            this.pbLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoLogin.TabIndex = 0;
            this.pbLogoLogin.TabStop = false;
            // 
            // lblNombreHotel
            // 
            this.lblNombreHotel.AutoSize = true;
            this.lblNombreHotel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblNombreHotel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblNombreHotel.Location = new System.Drawing.Point(41, 149);
            this.lblNombreHotel.Name = "lblNombreHotel";
            this.lblNombreHotel.Size = new System.Drawing.Size(258, 41);
            this.lblNombreHotel.TabIndex = 1;
            this.lblNombreHotel.Text = "HOTEL ARRECIFE";
            this.lblNombreHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.ForeColor = System.Drawing.Color.Gray;
            this.lblSlogan.Location = new System.Drawing.Point(0, 190);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(340, 20);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Diseño y esencia caribeña";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblUsuario.Location = new System.Drawing.Point(30, 230);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(280, 18);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(30, 251);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(280, 34);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblContrasena
            // 
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.lblContrasena.Location = new System.Drawing.Point(30, 294);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(280, 18);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContrasena.Location = new System.Drawing.Point(30, 315);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '●';
            this.txtContrasena.Size = new System.Drawing.Size(280, 34);
            this.txtContrasena.TabIndex = 6;
            this.txtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasena_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(30, 375);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(280, 44);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(420, 550);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Arrecife - Iniciar Sesión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epLogin)).EndInit();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epLogin;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox pbLogoLogin;
        private System.Windows.Forms.Label lblNombreHotel;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnLogin;
    }
}