namespace HotelZormat
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnModificarHabitaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(31, 158);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(97, 40);
            this.btnBitacora.TabIndex = 1;
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Location = new System.Drawing.Point(31, 225);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(116, 71);
            this.btnGestion.TabIndex = 2;
            this.btnGestion.Text = "Gestion Habitaciones";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnModificarHabitaciones
            // 
            this.btnModificarHabitaciones.Location = new System.Drawing.Point(31, 311);
            this.btnModificarHabitaciones.Name = "btnModificarHabitaciones";
            this.btnModificarHabitaciones.Size = new System.Drawing.Size(116, 71);
            this.btnModificarHabitaciones.TabIndex = 3;
            this.btnModificarHabitaciones.Text = "Modificar Habitaciones";
            this.btnModificarHabitaciones.UseVisualStyleBackColor = true;
            this.btnModificarHabitaciones.Click += new System.EventHandler(this.btnModificarHabitaciones_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificarHabitaciones);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.btnBitacora);
            this.Controls.Add(this.button1);
            this.Name = "FrmPrincipal";
            this.Text = "Hotel Zormat - SIstema de Gestion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnModificarHabitaciones;
    }
}