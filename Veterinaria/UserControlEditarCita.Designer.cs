namespace Veterinaria
{
    partial class UserControlEditarCita
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
            this.ActualizarCitaAdmi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotasEditar = new System.Windows.Forms.TextBox();
            this.Notas = new System.Windows.Forms.Label();
            this.dtpFechaEditar = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUsuariosEditar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxServicioEditar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHoraEditar = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMascotasEditar = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActualizarCitaAdmi
            // 
            this.ActualizarCitaAdmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.ActualizarCitaAdmi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarCitaAdmi.ForeColor = System.Drawing.Color.White;
            this.ActualizarCitaAdmi.Location = new System.Drawing.Point(78, 491);
            this.ActualizarCitaAdmi.Name = "ActualizarCitaAdmi";
            this.ActualizarCitaAdmi.Size = new System.Drawing.Size(365, 43);
            this.ActualizarCitaAdmi.TabIndex = 58;
            this.ActualizarCitaAdmi.Text = "Actualizar Cita";
            this.ActualizarCitaAdmi.UseVisualStyleBackColor = false;
            this.ActualizarCitaAdmi.Click += new System.EventHandler(this.ActualizarCitaAdmi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(44, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Modifica los datos de la cita";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Editar Cita";
            // 
            // txtNotasEditar
            // 
            this.txtNotasEditar.Location = new System.Drawing.Point(284, 417);
            this.txtNotasEditar.Name = "txtNotasEditar";
            this.txtNotasEditar.Size = new System.Drawing.Size(159, 20);
            this.txtNotasEditar.TabIndex = 68;
            // 
            // Notas
            // 
            this.Notas.AutoSize = true;
            this.Notas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notas.ForeColor = System.Drawing.Color.Black;
            this.Notas.Location = new System.Drawing.Point(280, 385);
            this.Notas.Name = "Notas";
            this.Notas.Size = new System.Drawing.Size(49, 19);
            this.Notas.TabIndex = 67;
            this.Notas.Text = "Notas";
            // 
            // dtpFechaEditar
            // 
            this.dtpFechaEditar.Location = new System.Drawing.Point(280, 299);
            this.dtpFechaEditar.Name = "dtpFechaEditar";
            this.dtpFechaEditar.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEditar.TabIndex = 66;
            // 
            // comboBoxUsuariosEditar
            // 
            this.comboBoxUsuariosEditar.FormattingEnabled = true;
            this.comboBoxUsuariosEditar.Items.AddRange(new object[] {
            "🩺 Consulta General",
            "",
            "💉 Vacunación",
            "",
            "⚠️ Cirugía",
            "",
            "⚠️ Emergencia",
            "",
            "✂️ Groomig"});
            this.comboBoxUsuariosEditar.Location = new System.Drawing.Point(49, 180);
            this.comboBoxUsuariosEditar.Name = "comboBoxUsuariosEditar";
            this.comboBoxUsuariosEditar.Size = new System.Drawing.Size(135, 21);
            this.comboBoxUsuariosEditar.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(276, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Fecha";
            // 
            // comboBoxServicioEditar
            // 
            this.comboBoxServicioEditar.FormattingEnabled = true;
            this.comboBoxServicioEditar.Items.AddRange(new object[] {
            "🩺 Consulta General",
            "",
            "💉 Vacunación",
            "",
            "⚠️ Cirugía",
            "",
            "⚠️ Emergencia",
            "",
            "✂️ Groomig"});
            this.comboBoxServicioEditar.Location = new System.Drawing.Point(49, 298);
            this.comboBoxServicioEditar.Name = "comboBoxServicioEditar";
            this.comboBoxServicioEditar.Size = new System.Drawing.Size(135, 21);
            this.comboBoxServicioEditar.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(276, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "Nombre de la mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 59;
            this.label4.Text = "Nombre del Dueño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Servicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(45, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Hora";
            // 
            // dtpHoraEditar
            // 
            this.dtpHoraEditar.CustomFormat = "hh:mm tt";
            this.dtpHoraEditar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEditar.Location = new System.Drawing.Point(48, 417);
            this.dtpHoraEditar.Name = "dtpHoraEditar";
            this.dtpHoraEditar.ShowUpDown = true;
            this.dtpHoraEditar.Size = new System.Drawing.Size(200, 20);
            this.dtpHoraEditar.TabIndex = 71;
            // 
            // comboBoxMascotasEditar
            // 
            this.comboBoxMascotasEditar.FormattingEnabled = true;
            this.comboBoxMascotasEditar.Items.AddRange(new object[] {
            "🩺 Consulta General",
            "",
            "💉 Vacunación",
            "",
            "⚠️ Cirugía",
            "",
            "⚠️ Emergencia",
            "",
            "✂️ Groomig"});
            this.comboBoxMascotasEditar.Location = new System.Drawing.Point(280, 180);
            this.comboBoxMascotasEditar.Name = "comboBoxMascotasEditar";
            this.comboBoxMascotasEditar.Size = new System.Drawing.Size(159, 21);
            this.comboBoxMascotasEditar.TabIndex = 72;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(440, 45);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 35);
            this.btnCancelar.TabIndex = 73;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UserControlEditarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.comboBoxMascotasEditar);
            this.Controls.Add(this.dtpHoraEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotasEditar);
            this.Controls.Add(this.Notas);
            this.Controls.Add(this.dtpFechaEditar);
            this.Controls.Add(this.comboBoxUsuariosEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxServicioEditar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActualizarCitaAdmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserControlEditarCita";
            this.Size = new System.Drawing.Size(561, 611);
            this.Load += new System.EventHandler(this.UserControlEditarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActualizarCitaAdmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotasEditar;
        private System.Windows.Forms.Label Notas;
        private System.Windows.Forms.DateTimePicker dtpFechaEditar;
        private System.Windows.Forms.ComboBox comboBoxUsuariosEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxServicioEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHoraEditar;
        private System.Windows.Forms.ComboBox comboBoxMascotasEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
