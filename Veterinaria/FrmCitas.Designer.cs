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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AgendarCitaUsu = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.PanelCerrarSAd = new System.Windows.Forms.Panel();
            this.CerrarSesionUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LogAdpictBox = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.PanelCerrarSAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogAdpictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.Location = new System.Drawing.Point(872, 12);
            this.dtpFechaHora.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpFechaHora.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHora.TabIndex = 3;
            this.dtpFechaHora.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.groupBox5.Controls.Add(this.AgendarCitaUsu);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.monthCalendar1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtDocumento);
            this.groupBox5.Controls.Add(this.txtApellido);
            this.groupBox5.Controls.Add(this.txtTelefono);
            this.groupBox5.Controls.Add(this.txtCorreo);
            this.groupBox5.Controls.Add(this.btnEditar);
            this.groupBox5.Controls.Add(this.btnCancelar);
            this.groupBox5.Controls.Add(this.btnActualizar);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(44, 384);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox5.Size = new System.Drawing.Size(1023, 505);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // AgendarCitaUsu
            // 
            this.AgendarCitaUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.AgendarCitaUsu.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgendarCitaUsu.ForeColor = System.Drawing.Color.White;
            this.AgendarCitaUsu.Location = new System.Drawing.Point(155, 426);
            this.AgendarCitaUsu.Name = "AgendarCitaUsu";
            this.AgendarCitaUsu.Size = new System.Drawing.Size(711, 43);
            this.AgendarCitaUsu.TabIndex = 36;
            this.AgendarCitaUsu.Text = "Agendar Cita";
            this.AgendarCitaUsu.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "8:00",
            "",
            "8:30",
            "",
            "9:00",
            "",
            "9:30",
            "",
            "10:00",
            "",
            "10:30",
            "",
            "11:00",
            "",
            "11:30",
            "",
            "12:00",
            "",
            "12:30",
            "",
            "13:00",
            "",
            "13:30",
            "",
            "14:00",
            "",
            "14:30",
            "",
            "15:00",
            "",
            "15:30",
            "",
            "16:00",
            "",
            "16:30",
            "",
            "17:00",
            "",
            "17:30",
            "",
            "18:00"});
            this.comboBox3.Location = new System.Drawing.Point(672, 167);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(135, 21);
            this.comboBox3.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(668, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Hora";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "🩺 Consulta General",
            "",
            "💉 Vacunación",
            "",
            "⚠️ Cirugía",
            "",
            "⚠️ Emergencia",
            "",
            "✂️ Groomig"});
            this.comboBox2.Location = new System.Drawing.Point(393, 301);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 21);
            this.comboBox2.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(389, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Servicio";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(393, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(389, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nombre de la mascota";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(672, 241);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(668, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "🐶 Perro",
            "",
            "🐱 Gato",
            "",
            "🦜 Ave",
            "",
            "🐰 Conejo",
            "",
            "🦎 Reptil",
            "",
            "Otro",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(155, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(151, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Especie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(151, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre del Dueño";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Reserva una cita para tu mascota\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(68, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Agendar Nueva Cita";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(44, 73);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(1023, 148);
            this.dgvCitas.TabIndex = 10;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            this.dgvCitas.SelectionChanged += new System.EventHandler(this.dgvCitas_SelectionChanged);
            this.dgvCitas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCitas_MouseClick);
            // 
            // cmbHora
            // 
            this.cmbHora.BackColor = System.Drawing.Color.White;
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(453, 11);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(200, 21);
            this.cmbHora.TabIndex = 16;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.BackColor = System.Drawing.Color.White;
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(667, 11);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(200, 21);
            this.cmbMotivo.TabIndex = 15;
            // 
            // PanelCerrarSAd
            // 
            this.PanelCerrarSAd.BackColor = System.Drawing.Color.White;
            this.PanelCerrarSAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCerrarSAd.Controls.Add(this.CerrarSesionUsuario);
            this.PanelCerrarSAd.Controls.Add(this.label1);
            this.PanelCerrarSAd.Controls.Add(this.label15);
            this.PanelCerrarSAd.Controls.Add(this.LogAdpictBox);
            this.PanelCerrarSAd.Location = new System.Drawing.Point(44, 251);
            this.PanelCerrarSAd.Name = "PanelCerrarSAd";
            this.PanelCerrarSAd.Size = new System.Drawing.Size(1023, 98);
            this.PanelCerrarSAd.TabIndex = 24;
            // 
            // CerrarSesionUsuario
            // 
            this.CerrarSesionUsuario.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_29_081235;
            this.CerrarSesionUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CerrarSesionUsuario.Location = new System.Drawing.Point(884, 16);
            this.CerrarSesionUsuario.Name = "CerrarSesionUsuario";
            this.CerrarSesionUsuario.Size = new System.Drawing.Size(124, 47);
            this.CerrarSesionUsuario.TabIndex = 19;
            this.CerrarSesionUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Portal de Usuario";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(89)))));
            this.label15.Location = new System.Drawing.Point(90, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 33);
            this.label15.TabIndex = 6;
            this.label15.Text = "Veterinaria Patitas";
            // 
            // LogAdpictBox
            // 
            this.LogAdpictBox.BackgroundImage = global::Veterinaria.Properties.Resources.Captura_de_pantalla_2025_10_28_185503;
            this.LogAdpictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogAdpictBox.Location = new System.Drawing.Point(14, 16);
            this.LogAdpictBox.Name = "LogAdpictBox";
            this.LogAdpictBox.Size = new System.Drawing.Size(62, 62);
            this.LogAdpictBox.TabIndex = 0;
            this.LogAdpictBox.TabStop = false;
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
            this.Controls.Add(this.PanelCerrarSAd);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.dtpFechaHora);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.PanelCerrarSAd.ResumeLayout(false);
            this.PanelCerrarSAd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogAdpictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel PanelCerrarSAd;
        private System.Windows.Forms.Button CerrarSesionUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox LogAdpictBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AgendarCitaUsu;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}