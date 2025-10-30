namespace Veterinaria
{
    partial class FrmAdmin
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
            this.label12 = new System.Windows.Forms.Label();
            this.PanelCerrarSAd = new System.Windows.Forms.Panel();
            this.CerrarSesionAdmi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LogAdpictBox = new System.Windows.Forms.PictureBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.imagenFiltro = new System.Windows.Forms.PictureBox();
            this.comboBoxCitas = new System.Windows.Forms.ComboBox();
            this.BtnVerReportes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGestionUsuarios = new System.Windows.Forms.Panel();
            this.datagridGestion = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTotalCitas = new System.Windows.Forms.Label();
            this.lblCitasPendientes = new System.Windows.Forms.Label();
            this.lblCitasCompletadas = new System.Windows.Forms.Label();
            this.lblCitasConfirmadas = new System.Windows.Forms.Label();
            this.btnEditarCita = new System.Windows.Forms.Button();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.PanelCerrarSAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogAdpictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGestionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.label12.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(43, -54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Gestión de Citas 👨‍👨‍👧‍👦‍❤️‍";
            // 
            // PanelCerrarSAd
            // 
            this.PanelCerrarSAd.BackColor = System.Drawing.Color.White;
            this.PanelCerrarSAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCerrarSAd.Controls.Add(this.CerrarSesionAdmi);
            this.PanelCerrarSAd.Controls.Add(this.label1);
            this.PanelCerrarSAd.Controls.Add(this.label15);
            this.PanelCerrarSAd.Controls.Add(this.LogAdpictBox);
            this.PanelCerrarSAd.Location = new System.Drawing.Point(54, 51);
            this.PanelCerrarSAd.Name = "PanelCerrarSAd";
            this.PanelCerrarSAd.Size = new System.Drawing.Size(775, 98);
            this.PanelCerrarSAd.TabIndex = 22;
            // 
            // CerrarSesionAdmi
            // 
            this.CerrarSesionAdmi.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_081235;
            this.CerrarSesionAdmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CerrarSesionAdmi.Location = new System.Drawing.Point(627, 24);
            this.CerrarSesionAdmi.Name = "CerrarSesionAdmi";
            this.CerrarSesionAdmi.Size = new System.Drawing.Size(138, 47);
            this.CerrarSesionAdmi.TabIndex = 19;
            this.CerrarSesionAdmi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Panel de Administración";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(93)))), ((int)(((byte)(227)))));
            this.label15.Location = new System.Drawing.Point(90, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 33);
            this.label15.TabIndex = 6;
            this.label15.Text = "Veterinaria Patitas";
            // 
            // LogAdpictBox
            // 
            this.LogAdpictBox.BackColor = System.Drawing.Color.Transparent;
            this.LogAdpictBox.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_080808;
            this.LogAdpictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogAdpictBox.Location = new System.Drawing.Point(14, 16);
            this.LogAdpictBox.Name = "LogAdpictBox";
            this.LogAdpictBox.Size = new System.Drawing.Size(62, 62);
            this.LogAdpictBox.TabIndex = 0;
            this.LogAdpictBox.TabStop = false;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(674, 80);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(90, 28);
            this.btnMostrarTodos.TabIndex = 51;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_0835331;
            this.btnNuevaCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevaCita.Location = new System.Drawing.Point(640, 29);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(137, 44);
            this.btnNuevaCita.TabIndex = 41;
            this.btnNuevaCita.UseVisualStyleBackColor = true;
            this.btnNuevaCita.Click += new System.EventHandler(this.btnNuevaCita_Click);
            // 
            // imagenFiltro
            // 
            this.imagenFiltro.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_083218;
            this.imagenFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagenFiltro.Location = new System.Drawing.Point(470, 36);
            this.imagenFiltro.Name = "imagenFiltro";
            this.imagenFiltro.Size = new System.Drawing.Size(39, 30);
            this.imagenFiltro.TabIndex = 40;
            this.imagenFiltro.TabStop = false;
            // 
            // comboBoxCitas
            // 
            this.comboBoxCitas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCitas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCitas.FormattingEnabled = true;
            this.comboBoxCitas.Items.AddRange(new object[] {
            "Todas las citas",
            "Agendadas",
            "Confirmadas",
            "Completadas",
            "Canceladas"});
            this.comboBoxCitas.Location = new System.Drawing.Point(510, 39);
            this.comboBoxCitas.Name = "comboBoxCitas";
            this.comboBoxCitas.Size = new System.Drawing.Size(122, 26);
            this.comboBoxCitas.TabIndex = 39;
            // 
            // BtnVerReportes
            // 
            this.BtnVerReportes.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_0837501;
            this.BtnVerReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVerReportes.Location = new System.Drawing.Point(321, 32);
            this.BtnVerReportes.Name = "BtnVerReportes";
            this.BtnVerReportes.Size = new System.Drawing.Size(145, 38);
            this.BtnVerReportes.TabIndex = 38;
            this.BtnVerReportes.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_082135;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(31, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(76, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Gestión de Citas";
            // 
            // panelGestionUsuarios
            // 
            this.panelGestionUsuarios.Controls.Add(this.btnEliminarCita);
            this.panelGestionUsuarios.Controls.Add(this.btnEditarCita);
            this.panelGestionUsuarios.Controls.Add(this.lblCitasConfirmadas);
            this.panelGestionUsuarios.Controls.Add(this.lblCitasCompletadas);
            this.panelGestionUsuarios.Controls.Add(this.lblCitasPendientes);
            this.panelGestionUsuarios.Controls.Add(this.lblTotalCitas);
            this.panelGestionUsuarios.Controls.Add(this.txtBuscar);
            this.panelGestionUsuarios.Controls.Add(this.datagridGestion);
            this.panelGestionUsuarios.Controls.Add(this.btnMostrarTodos);
            this.panelGestionUsuarios.Controls.Add(this.btnNuevaCita);
            this.panelGestionUsuarios.Controls.Add(this.imagenFiltro);
            this.panelGestionUsuarios.Controls.Add(this.comboBoxCitas);
            this.panelGestionUsuarios.Controls.Add(this.BtnVerReportes);
            this.panelGestionUsuarios.Controls.Add(this.pictureBox1);
            this.panelGestionUsuarios.Controls.Add(this.label2);
            this.panelGestionUsuarios.Location = new System.Drawing.Point(43, 181);
            this.panelGestionUsuarios.Name = "panelGestionUsuarios";
            this.panelGestionUsuarios.Size = new System.Drawing.Size(814, 451);
            this.panelGestionUsuarios.TabIndex = 52;
            this.panelGestionUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGestionUsuarios_Paint);
            // 
            // datagridGestion
            // 
            this.datagridGestion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.datagridGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridGestion.Location = new System.Drawing.Point(59, 139);
            this.datagridGestion.Name = "datagridGestion";
            this.datagridGestion.Size = new System.Drawing.Size(704, 253);
            this.datagridGestion.TabIndex = 52;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(361, 85);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(307, 20);
            this.txtBuscar.TabIndex = 53;
            // 
            // lblTotalCitas
            // 
            this.lblTotalCitas.AutoSize = true;
            this.lblTotalCitas.Location = new System.Drawing.Point(36, 110);
            this.lblTotalCitas.Name = "lblTotalCitas";
            this.lblTotalCitas.Size = new System.Drawing.Size(35, 13);
            this.lblTotalCitas.TabIndex = 54;
            this.lblTotalCitas.Text = "label3";
            // 
            // lblCitasPendientes
            // 
            this.lblCitasPendientes.AutoSize = true;
            this.lblCitasPendientes.Location = new System.Drawing.Point(89, 110);
            this.lblCitasPendientes.Name = "lblCitasPendientes";
            this.lblCitasPendientes.Size = new System.Drawing.Size(35, 13);
            this.lblCitasPendientes.TabIndex = 55;
            this.lblCitasPendientes.Text = "label4";
            this.lblCitasPendientes.Click += new System.EventHandler(this.lblCitasPendientes_Click);
            // 
            // lblCitasCompletadas
            // 
            this.lblCitasCompletadas.AutoSize = true;
            this.lblCitasCompletadas.Location = new System.Drawing.Point(148, 110);
            this.lblCitasCompletadas.Name = "lblCitasCompletadas";
            this.lblCitasCompletadas.Size = new System.Drawing.Size(35, 13);
            this.lblCitasCompletadas.TabIndex = 56;
            this.lblCitasCompletadas.Text = "label5";
            // 
            // lblCitasConfirmadas
            // 
            this.lblCitasConfirmadas.AutoSize = true;
            this.lblCitasConfirmadas.Location = new System.Drawing.Point(204, 110);
            this.lblCitasConfirmadas.Name = "lblCitasConfirmadas";
            this.lblCitasConfirmadas.Size = new System.Drawing.Size(35, 13);
            this.lblCitasConfirmadas.TabIndex = 57;
            this.lblCitasConfirmadas.Text = "label6";
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnEditarCita.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCita.ForeColor = System.Drawing.Color.White;
            this.btnEditarCita.Location = new System.Drawing.Point(187, 405);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(131, 33);
            this.btnEditarCita.TabIndex = 58;
            this.btnEditarCita.Text = "Editar Cita";
            this.btnEditarCita.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnEliminarCita.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCita.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCita.Location = new System.Drawing.Point(488, 405);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(131, 33);
            this.btnEliminarCita.TabIndex = 59;
            this.btnEliminarCita.Text = "Eliminar Cita";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_0648421;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panelGestionUsuarios);
            this.Controls.Add(this.PanelCerrarSAd);
            this.Controls.Add(this.label12);
            this.DoubleBuffered = true;
            this.Name = "FrmAdmin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.PanelCerrarSAd.ResumeLayout(false);
            this.PanelCerrarSAd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogAdpictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGestionUsuarios.ResumeLayout(false);
            this.panelGestionUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel PanelCerrarSAd;
        private System.Windows.Forms.PictureBox LogAdpictBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CerrarSesionAdmi;

        // Removed designer declarations for controls created in FrmAdmin.cs to avoid duplicates
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.PictureBox imagenFiltro;
        private System.Windows.Forms.ComboBox comboBoxCitas;
        private System.Windows.Forms.Button BtnVerReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGestionUsuarios;
        private System.Windows.Forms.DataGridView datagridGestion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblCitasConfirmadas;
        private System.Windows.Forms.Label lblCitasCompletadas;
        private System.Windows.Forms.Label lblCitasPendientes;
        private System.Windows.Forms.Label lblTotalCitas;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Button btnEditarCita;
    }
}