namespace Veterinaria
{
    partial class FrmCrudUsuarios
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEliminarCrud = new System.Windows.Forms.Button();
            this.btnEditarCrud = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCrudUsuarios = new System.Windows.Forms.DataGridView();
            this.PanelCerrarSCrud = new System.Windows.Forms.Panel();
            this.CerrarSesionUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LogAdpictBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrudUsuarios)).BeginInit();
            this.PanelCerrarSCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogAdpictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.btnEliminarCrud);
            this.groupBox5.Controls.Add(this.btnEditarCrud);
            this.groupBox5.Controls.Add(this.btnNuevoUsuario);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.dgvCrudUsuarios);
            this.groupBox5.Location = new System.Drawing.Point(29, 188);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(872, 457);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // btnEliminarCrud
            // 
            this.btnEliminarCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(59)))), ((int)(((byte)(245)))));
            this.btnEliminarCrud.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCrud.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCrud.Location = new System.Drawing.Point(516, 394);
            this.btnEliminarCrud.Name = "btnEliminarCrud";
            this.btnEliminarCrud.Size = new System.Drawing.Size(103, 38);
            this.btnEliminarCrud.TabIndex = 27;
            this.btnEliminarCrud.Text = "Eliminar";
            this.btnEliminarCrud.UseVisualStyleBackColor = false;
            this.btnEliminarCrud.Click += new System.EventHandler(this.btnEliminarCrud_Click);
            // 
            // btnEditarCrud
            // 
            this.btnEditarCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(59)))), ((int)(((byte)(245)))));
            this.btnEditarCrud.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCrud.ForeColor = System.Drawing.Color.White;
            this.btnEditarCrud.Location = new System.Drawing.Point(305, 394);
            this.btnEditarCrud.Name = "btnEditarCrud";
            this.btnEditarCrud.Size = new System.Drawing.Size(108, 38);
            this.btnEditarCrud.TabIndex = 26;
            this.btnEditarCrud.Text = "Editar";
            this.btnEditarCrud.UseVisualStyleBackColor = false;
            this.btnEditarCrud.Click += new System.EventHandler(this.btnEditarCrud_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_30_222418;
            this.btnNuevoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(642, 37);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(163, 44);
            this.btnNuevoUsuario.TabIndex = 25;
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_30_222211;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(57, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(93, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Gestión de Usuarios";
            // 
            // dgvCrudUsuarios
            // 
            this.dgvCrudUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCrudUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrudUsuarios.Location = new System.Drawing.Point(64, 122);
            this.dgvCrudUsuarios.Name = "dgvCrudUsuarios";
            this.dgvCrudUsuarios.Size = new System.Drawing.Size(741, 237);
            this.dgvCrudUsuarios.TabIndex = 12;
            // 
            // PanelCerrarSCrud
            // 
            this.PanelCerrarSCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(59)))), ((int)(((byte)(245)))));
            this.PanelCerrarSCrud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCerrarSCrud.Controls.Add(this.CerrarSesionUsuario);
            this.PanelCerrarSCrud.Controls.Add(this.label1);
            this.PanelCerrarSCrud.Controls.Add(this.label15);
            this.PanelCerrarSCrud.Controls.Add(this.LogAdpictBox);
            this.PanelCerrarSCrud.Location = new System.Drawing.Point(29, 26);
            this.PanelCerrarSCrud.Name = "PanelCerrarSCrud";
            this.PanelCerrarSCrud.Size = new System.Drawing.Size(872, 95);
            this.PanelCerrarSCrud.TabIndex = 27;
            this.PanelCerrarSCrud.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCerrarSCrud_Paint);
            // 
            // CerrarSesionUsuario
            // 
            this.CerrarSesionUsuario.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_30_221028;
            this.CerrarSesionUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CerrarSesionUsuario.Location = new System.Drawing.Point(708, 20);
            this.CerrarSesionUsuario.Name = "CerrarSesionUsuario";
            this.CerrarSesionUsuario.Size = new System.Drawing.Size(144, 35);
            this.CerrarSesionUsuario.TabIndex = 19;
            this.CerrarSesionUsuario.UseVisualStyleBackColor = true;
            this.CerrarSesionUsuario.Click += new System.EventHandler(this.CerrarSesionUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Veterinaria Patitas - Gestión de Usuarios";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(90, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(277, 33);
            this.label15.TabIndex = 6;
            this.label15.Text = "Panel de Administración";
            // 
            // LogAdpictBox
            // 
            this.LogAdpictBox.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_30_220832;
            this.LogAdpictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogAdpictBox.Location = new System.Drawing.Point(14, 16);
            this.LogAdpictBox.Name = "LogAdpictBox";
            this.LogAdpictBox.Size = new System.Drawing.Size(62, 62);
            this.LogAdpictBox.TabIndex = 0;
            this.LogAdpictBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Gestionar Citas";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(418, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Citas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.BackColor = System.Drawing.Color.White;
            this.panelUsuarios.Location = new System.Drawing.Point(249, 127);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(531, 463);
            this.panelUsuarios.TabIndex = 28;
            // 
            // FrmCrudUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.PanelCerrarSCrud);
            this.Name = "FrmCrudUsuarios";
            this.Text = "FrmCrudUsuarios";
            this.Load += new System.EventHandler(this.FrmCrudUsuarios_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrudUsuarios)).EndInit();
            this.PanelCerrarSCrud.ResumeLayout(false);
            this.PanelCerrarSCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogAdpictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEliminarCrud;
        private System.Windows.Forms.Button btnEditarCrud;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCrudUsuarios;
        private System.Windows.Forms.Panel PanelCerrarSCrud;
        private System.Windows.Forms.Button CerrarSesionUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox LogAdpictBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelUsuarios;
    }
}