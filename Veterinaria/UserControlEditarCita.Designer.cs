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
            this.CalendarioFechaEC = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.ComBoxHoraEC = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComBoxServicioEC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComBoxEspecieEC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBoxNomMascotEC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBoxNomDueñoEC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActualizarCitaAdmi
            // 
            this.ActualizarCitaAdmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(54)))), ((int)(((byte)(167)))));
            this.ActualizarCitaAdmi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualizarCitaAdmi.ForeColor = System.Drawing.Color.White;
            this.ActualizarCitaAdmi.Location = new System.Drawing.Point(103, 658);
            this.ActualizarCitaAdmi.Name = "ActualizarCitaAdmi";
            this.ActualizarCitaAdmi.Size = new System.Drawing.Size(365, 43);
            this.ActualizarCitaAdmi.TabIndex = 58;
            this.ActualizarCitaAdmi.Text = "Actualizar Cita";
            this.ActualizarCitaAdmi.UseVisualStyleBackColor = false;
            // 
            // CalendarioFechaEC
            // 
            this.CalendarioFechaEC.Location = new System.Drawing.Point(291, 462);
            this.CalendarioFechaEC.Name = "CalendarioFechaEC";
            this.CalendarioFechaEC.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(287, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha";
            // 
            // ComBoxHoraEC
            // 
            this.ComBoxHoraEC.FormattingEnabled = true;
            this.ComBoxHoraEC.Items.AddRange(new object[] {
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
            this.ComBoxHoraEC.Location = new System.Drawing.Point(60, 468);
            this.ComBoxHoraEC.Name = "ComBoxHoraEC";
            this.ComBoxHoraEC.Size = new System.Drawing.Size(135, 21);
            this.ComBoxHoraEC.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(56, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "Hora";
            // 
            // ComBoxServicioEC
            // 
            this.ComBoxServicioEC.FormattingEnabled = true;
            this.ComBoxServicioEC.Items.AddRange(new object[] {
            "🩺 Consulta General",
            "",
            "💉 Vacunación",
            "",
            "⚠️ Cirugía",
            "",
            "⚠️ Emergencia",
            "",
            "✂️ Groomig"});
            this.ComBoxServicioEC.Location = new System.Drawing.Point(291, 341);
            this.ComBoxServicioEC.Name = "ComBoxServicioEC";
            this.ComBoxServicioEC.Size = new System.Drawing.Size(135, 21);
            this.ComBoxServicioEC.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(287, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 52;
            this.label8.Text = "Servicio";
            // 
            // ComBoxEspecieEC
            // 
            this.ComBoxEspecieEC.FormattingEnabled = true;
            this.ComBoxEspecieEC.Items.AddRange(new object[] {
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
            this.ComBoxEspecieEC.Location = new System.Drawing.Point(60, 341);
            this.ComBoxEspecieEC.Name = "ComBoxEspecieEC";
            this.ComBoxEspecieEC.Size = new System.Drawing.Size(135, 21);
            this.ComBoxEspecieEC.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(56, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Especie";
            // 
            // TBoxNomMascotEC
            // 
            this.TBoxNomMascotEC.Location = new System.Drawing.Point(291, 200);
            this.TBoxNomMascotEC.Name = "TBoxNomMascotEC";
            this.TBoxNomMascotEC.Size = new System.Drawing.Size(159, 20);
            this.TBoxNomMascotEC.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(287, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nombre de la mascota";
            // 
            // TBoxNomDueñoEC
            // 
            this.TBoxNomDueñoEC.Location = new System.Drawing.Point(60, 200);
            this.TBoxNomDueñoEC.Name = "TBoxNomDueñoEC";
            this.TBoxNomDueñoEC.Size = new System.Drawing.Size(135, 20);
            this.TBoxNomDueñoEC.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nombre del Dueño";
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
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Editar Cita";
            // 
            // UserControlEditarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActualizarCitaAdmi);
            this.Controls.Add(this.CalendarioFechaEC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComBoxHoraEC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComBoxServicioEC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ComBoxEspecieEC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxNomMascotEC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBoxNomDueñoEC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserControlEditarCita";
            this.Size = new System.Drawing.Size(632, 732);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActualizarCitaAdmi;
        private System.Windows.Forms.MonthCalendar CalendarioFechaEC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComBoxHoraEC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComBoxServicioEC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComBoxEspecieEC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBoxNomMascotEC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBoxNomDueñoEC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
