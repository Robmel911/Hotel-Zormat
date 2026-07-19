namespace HotelZormat
{
    partial class Prueba
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
            this.components = new System.ComponentModel.Container();
            this.btnGestor = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnGestor
            // 
            this.btnGestor.Location = new System.Drawing.Point(261, 161);
            this.btnGestor.Name = "btnGestor";
            this.btnGestor.Size = new System.Drawing.Size(295, 157);
            this.btnGestor.TabIndex = 0;
            this.btnGestor.Text = "Entrar a gestor ";
            this.btnGestor.UseVisualStyleBackColor = true;
            this.btnGestor.Click += new System.EventHandler(this.button1_Click);
            // 
            // tiempo
            // 
            this.tiempo.Enabled = true;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestor);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestor;
        private System.Windows.Forms.Timer tiempo;
    }
}