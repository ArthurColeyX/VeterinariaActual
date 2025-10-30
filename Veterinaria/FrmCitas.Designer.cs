namespace Veterinaria
{
    partial class FrmCitas
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
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.PanelCerrarSAd = new System.Windows.Forms.Panel();
            this.CerrarSesionUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LogAdpictBox = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.PanelCerrarSAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogAdpictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(31, 514);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(1023, 148);
            this.dgvCitas.TabIndex = 10;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            this.dgvCitas.SelectionChanged += new System.EventHandler(this.dgvCitas_SelectionChanged);
            this.dgvCitas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCitas_MouseClick);
            // 
            // PanelCerrarSAd
            // 
            this.PanelCerrarSAd.BackColor = System.Drawing.Color.White;
            this.PanelCerrarSAd.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_30_094555;
            this.PanelCerrarSAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCerrarSAd.Controls.Add(this.CerrarSesionUsuario);
            this.PanelCerrarSAd.Controls.Add(this.label1);
            this.PanelCerrarSAd.Controls.Add(this.label15);
            this.PanelCerrarSAd.Controls.Add(this.LogAdpictBox);
            this.PanelCerrarSAd.Location = new System.Drawing.Point(0, 0);
            this.PanelCerrarSAd.Name = "PanelCerrarSAd";
            this.PanelCerrarSAd.Size = new System.Drawing.Size(1128, 92);
            this.PanelCerrarSAd.TabIndex = 24;
            // 
            // CerrarSesionUsuario
            // 
            this.CerrarSesionUsuario.BackColor = System.Drawing.Color.Transparent;
            this.CerrarSesionUsuario.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_30_101949;
            this.CerrarSesionUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarSesionUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesionUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CerrarSesionUsuario.Location = new System.Drawing.Point(947, 15);
            this.CerrarSesionUsuario.Name = "CerrarSesionUsuario";
            this.CerrarSesionUsuario.Size = new System.Drawing.Size(175, 51);
            this.CerrarSesionUsuario.TabIndex = 19;
            this.CerrarSesionUsuario.Text = "         Cerrar Sesion";
            this.CerrarSesionUsuario.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(82, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "El mejor cuidado para tu mejor amigo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(80, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 29);
            this.label15.TabIndex = 6;
            this.label15.Text = "Veterinaria Patitas";
            // 
            // LogAdpictBox
            // 
            this.LogAdpictBox.BackColor = System.Drawing.Color.Transparent;
            this.LogAdpictBox.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_30_100714;
            this.LogAdpictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogAdpictBox.Location = new System.Drawing.Point(9, 13);
            this.LogAdpictBox.Name = "LogAdpictBox";
            this.LogAdpictBox.Size = new System.Drawing.Size(62, 62);
            this.LogAdpictBox.TabIndex = 0;
            this.LogAdpictBox.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(0, 0);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(0, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_30_130553;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(87, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 295);
            this.panel1.TabIndex = 25;
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_064842;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1127, 948);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCerrarSAd);
            this.Controls.Add(this.dgvCitas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.PanelCerrarSAd.ResumeLayout(false);
            this.PanelCerrarSAd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogAdpictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Panel PanelCerrarSAd;
        private System.Windows.Forms.Button CerrarSesionUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox LogAdpictBox;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel1;
    }
}