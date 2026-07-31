namespace HotelZormat.UI.Formularios
{
    partial class FrmAdministrarHabitaciones
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
            this.flpHabitaciones = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // flpHabitaciones
            //
            this.flpHabitaciones.AutoScroll = true;
            this.flpHabitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpHabitaciones.Location = new System.Drawing.Point(0, 100);
            this.flpHabitaciones.Name = "flpHabitaciones";
            this.flpHabitaciones.Size = new System.Drawing.Size(1200, 700);
            this.flpHabitaciones.TabIndex = 0;
            //
            // panel1
            //
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 1;
            //
            // btnAgregar
            //
            this.btnAgregar.Location = new System.Drawing.Point(30, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(200, 25);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 50);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(370, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // FrmAdministrarHabitaciones
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.flpHabitaciones);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdministrarHabitaciones";
            this.Text = "Administrar Habitaciones";
            this.Load += new System.EventHandler(this.FrmAdministrarHabitaciones_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpHabitaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}