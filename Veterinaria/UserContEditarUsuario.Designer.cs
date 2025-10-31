namespace Veterinaria
{
    partial class UserContEditarUsuario
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
            this.btnSalirEU = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditarUsuarioAdmi = new System.Windows.Forms.Button();
            this.txtApellidoEditarU = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.ComBoxRolCrudNU = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContraEditarU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelEditarU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoEditarU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreEditarU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_idEditar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalirEU
            // 
            this.btnSalirEU.ForeColor = System.Drawing.Color.Red;
            this.btnSalirEU.Location = new System.Drawing.Point(422, 26);
            this.btnSalirEU.Name = "btnSalirEU";
            this.btnSalirEU.Size = new System.Drawing.Size(41, 23);
            this.btnSalirEU.TabIndex = 69;
            this.btnSalirEU.Text = "X";
            this.btnSalirEU.UseVisualStyleBackColor = true;
            this.btnSalirEU.Click += new System.EventHandler(this.btnSalirEU_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(44, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Modifica los datos del usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Editar Usuario";
            // 
            // EditarUsuarioAdmi
            // 
            this.EditarUsuarioAdmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(59)))), ((int)(((byte)(245)))));
            this.EditarUsuarioAdmi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarUsuarioAdmi.ForeColor = System.Drawing.Color.White;
            this.EditarUsuarioAdmi.Location = new System.Drawing.Point(57, 420);
            this.EditarUsuarioAdmi.Name = "EditarUsuarioAdmi";
            this.EditarUsuarioAdmi.Size = new System.Drawing.Size(365, 43);
            this.EditarUsuarioAdmi.TabIndex = 70;
            this.EditarUsuarioAdmi.Text = "Actualizar Usuario";
            this.EditarUsuarioAdmi.UseVisualStyleBackColor = false;
            this.EditarUsuarioAdmi.Click += new System.EventHandler(this.EditarUsuarioAdmi_Click);
            // 
            // txtApellidoEditarU
            // 
            this.txtApellidoEditarU.Location = new System.Drawing.Point(257, 145);
            this.txtApellidoEditarU.Name = "txtApellidoEditarU";
            this.txtApellidoEditarU.Size = new System.Drawing.Size(156, 20);
            this.txtApellidoEditarU.TabIndex = 82;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.ForeColor = System.Drawing.Color.Black;
            this.Apellido.Location = new System.Drawing.Point(253, 114);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(66, 19);
            this.Apellido.TabIndex = 81;
            this.Apellido.Text = "Apellido";
            // 
            // ComBoxRolCrudNU
            // 
            this.ComBoxRolCrudNU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComBoxRolCrudNU.FormattingEnabled = true;
            this.ComBoxRolCrudNU.Items.AddRange(new object[] {
            "Cliente",
            "Administrador"});
            this.ComBoxRolCrudNU.Location = new System.Drawing.Point(178, 374);
            this.ComBoxRolCrudNU.Name = "ComBoxRolCrudNU";
            this.ComBoxRolCrudNU.Size = new System.Drawing.Size(121, 21);
            this.ComBoxRolCrudNU.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(174, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 79;
            this.label6.Text = "Rol";
            // 
            // txtContraEditarU
            // 
            this.txtContraEditarU.Location = new System.Drawing.Point(257, 302);
            this.txtContraEditarU.Name = "txtContraEditarU";
            this.txtContraEditarU.Size = new System.Drawing.Size(156, 20);
            this.txtContraEditarU.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(253, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "Contraseña";
            // 
            // txtTelEditarU
            // 
            this.txtTelEditarU.Location = new System.Drawing.Point(48, 302);
            this.txtTelEditarU.Name = "txtTelEditarU";
            this.txtTelEditarU.Size = new System.Drawing.Size(156, 20);
            this.txtTelEditarU.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Teléfono";
            // 
            // txtCorreoEditarU
            // 
            this.txtCorreoEditarU.Location = new System.Drawing.Point(257, 220);
            this.txtCorreoEditarU.Name = "txtCorreoEditarU";
            this.txtCorreoEditarU.Size = new System.Drawing.Size(156, 20);
            this.txtCorreoEditarU.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(253, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 73;
            this.label7.Text = "Email";
            // 
            // txtNombreEditarU
            // 
            this.txtNombreEditarU.Location = new System.Drawing.Point(48, 145);
            this.txtNombreEditarU.Name = "txtNombreEditarU";
            this.txtNombreEditarU.Size = new System.Drawing.Size(156, 20);
            this.txtNombreEditarU.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(44, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 19);
            this.label8.TabIndex = 83;
            this.label8.Text = "Número de documento";
            // 
            // txt_idEditar
            // 
            this.txt_idEditar.Location = new System.Drawing.Point(48, 220);
            this.txt_idEditar.Name = "txt_idEditar";
            this.txt_idEditar.Size = new System.Drawing.Size(156, 20);
            this.txt_idEditar.TabIndex = 84;
            // 
            // UserContEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_idEditar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApellidoEditarU);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.ComBoxRolCrudNU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraEditarU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelEditarU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreoEditarU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreEditarU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditarUsuarioAdmi);
            this.Controls.Add(this.btnSalirEU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserContEditarUsuario";
            this.Size = new System.Drawing.Size(511, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirEU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditarUsuarioAdmi;
        private System.Windows.Forms.TextBox txtApellidoEditarU;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.ComboBox ComBoxRolCrudNU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContraEditarU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelEditarU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoEditarU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreEditarU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_idEditar;
    }
}
