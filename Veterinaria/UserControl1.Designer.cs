namespace Veterinaria
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxServicio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CrearCitaAdmi = new System.Windows.Forms.Button();
            this.comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.Notas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBoxMascotas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nueva Cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(34, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Completa los datos para agendar una cita";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(277, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Nombre de la mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nombre del Dueño";
            // 
            // comboBoxServicio
            // 
            this.comboBoxServicio.FormattingEnabled = true;
            this.comboBoxServicio.Items.AddRange(new object[] {
            "🩺 Consulta General",
            "",
            "💉 Vacunación",
            "",
            "⚠️ Cirugía",
            "",
            "⚠️ Emergencia",
            "",
            "✂️ Groomig"});
            this.comboBoxServicio.Location = new System.Drawing.Point(50, 300);
            this.comboBoxServicio.Name = "comboBoxServicio";
            this.comboBoxServicio.Size = new System.Drawing.Size(135, 21);
            this.comboBoxServicio.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(46, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Servicio";
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00"});
            this.comboBoxHora.Location = new System.Drawing.Point(50, 421);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(135, 21);
            this.comboBoxHora.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(46, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(277, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fecha";
            // 
            // CrearCitaAdmi
            // 
            this.CrearCitaAdmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.CrearCitaAdmi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearCitaAdmi.ForeColor = System.Drawing.Color.White;
            this.CrearCitaAdmi.Location = new System.Drawing.Point(75, 521);
            this.CrearCitaAdmi.Name = "CrearCitaAdmi";
            this.CrearCitaAdmi.Size = new System.Drawing.Size(365, 43);
            this.CrearCitaAdmi.TabIndex = 43;
            this.CrearCitaAdmi.Text = "Crear Cita";
            this.CrearCitaAdmi.UseVisualStyleBackColor = false;
            this.CrearCitaAdmi.Click += new System.EventHandler(this.CrearCitaAdmi_Click);
            // 
            // comboBoxUsuarios
            // 
            this.comboBoxUsuarios.FormattingEnabled = true;
            this.comboBoxUsuarios.Items.AddRange(new object[] {
            "🩺 Consulta General",
            "",
            "💉 Vacunación",
            "",
            "⚠️ Cirugía",
            "",
            "⚠️ Emergencia",
            "",
            "✂️ Groomig"});
            this.comboBoxUsuarios.Location = new System.Drawing.Point(50, 182);
            this.comboBoxUsuarios.Name = "comboBoxUsuarios";
            this.comboBoxUsuarios.Size = new System.Drawing.Size(135, 21);
            this.comboBoxUsuarios.TabIndex = 44;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(281, 301);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 45;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(285, 419);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(159, 20);
            this.txtNotas.TabIndex = 47;
            // 
            // Notas
            // 
            this.Notas.AutoSize = true;
            this.Notas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notas.ForeColor = System.Drawing.Color.Black;
            this.Notas.Location = new System.Drawing.Point(281, 387);
            this.Notas.Name = "Notas";
            this.Notas.Size = new System.Drawing.Size(49, 19);
            this.Notas.TabIndex = 46;
            this.Notas.Text = "Notas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(443, 28);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 35);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboBoxMascotas
            // 
            this.comboBoxMascotas.FormattingEnabled = true;
            this.comboBoxMascotas.Items.AddRange(new object[] {
            "🩺 Consulta General",
            "",
            "💉 Vacunación",
            "",
            "⚠️ Cirugía",
            "",
            "⚠️ Emergencia",
            "",
            "✂️ Groomig"});
            this.comboBoxMascotas.Location = new System.Drawing.Point(281, 182);
            this.comboBoxMascotas.Name = "comboBoxMascotas";
            this.comboBoxMascotas.Size = new System.Drawing.Size(135, 21);
            this.comboBoxMascotas.TabIndex = 49;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxMascotas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.Notas);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.comboBoxUsuarios);
            this.Controls.Add(this.CrearCitaAdmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxServicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(565, 624);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxServicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CrearCitaAdmi;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label Notas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox comboBoxMascotas;
    }
}
