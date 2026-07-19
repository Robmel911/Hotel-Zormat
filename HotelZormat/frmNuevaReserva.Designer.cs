namespace HotelZormat
{
    partial class frmNuevaReserva
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
            this.cmbTipoHab = new System.Windows.Forms.ComboBox();
            this.txtNoches = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNoches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipoHab
            // 
            this.cmbTipoHab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHab.FormattingEnabled = true;
            this.cmbTipoHab.Location = new System.Drawing.Point(215, 48);
            this.cmbTipoHab.Name = "cmbTipoHab";
            this.cmbTipoHab.Size = new System.Drawing.Size(283, 28);
            this.cmbTipoHab.TabIndex = 0;
            // 
            // txtNoches
            // 
            this.txtNoches.Location = new System.Drawing.Point(215, 137);
            this.txtNoches.Name = "txtNoches";
            this.txtNoches.Size = new System.Drawing.Size(283, 26);
            this.txtNoches.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(70, 55);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Location = new System.Drawing.Point(74, 142);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(63, 20);
            this.lblNoches.TabIndex = 3;
            this.lblNoches.Text = "Noches";
            // 
            // frmNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 221);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNoches);
            this.Controls.Add(this.cmbTipoHab);
            this.Name = "frmNuevaReserva";
            this.Text = "frmNuevaReserva";
            this.Load += new System.EventHandler(this.frmNuevaReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoHab;
        private System.Windows.Forms.TextBox txtNoches;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNoches;
    }
}