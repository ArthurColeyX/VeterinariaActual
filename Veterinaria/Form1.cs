using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Veterinaria
{
    public partial class Form1 : Form
    {
        private readonly IMongoCollection<Usuarios> _usuariosCollection;

        public Form1()
        {
            InitializeComponent();

            var database = ConexionMongo.ObtenerConexion();
            _usuariosCollection = database.GetCollection<Usuarios>("Usuarios");

        }

        private void Form1_Load(object sender, EventArgs e)
        { 

            try
            {
                var db = ConexionMongo.ObtenerConexion();
                //MessageBox.Show("Conectado a MongoDB: " + db.DatabaseNamespace.DatabaseName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void lblRecuperar_Click(object sender, EventArgs e)
        {
            Panel_Ingresar.Visible = false;
            panel_recuperar.Visible = true;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quiere salir?", " Salir ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

   

        private void lblRegistroPRecuperar_Click(object sender, EventArgs e)
        {
            Panel_Registro.Visible = true;
            panel_recuperar.Visible = false;
        }

        private void lblIngresarPRecuperar_Click(object sender, EventArgs e)
        {
            Panel_Ingresar.Visible = true;
            panel_recuperar.Visible = false;
        }

        private void lblRecuperar2_Click(object sender, EventArgs e)
        {
            panel_recuperar.Visible = true;
            Panel_Registro.Visible = false;
        }

        private void lblRegistro2_Click(object sender, EventArgs e)
        {

        }

        private void lblRecuperar_Click_1(object sender, EventArgs e)
        {
            panel_recuperar.Visible = true;
            Panel_Ingresar.Visible = false;
        }

        private void lblIngresar2_Click(object sender, EventArgs e)
        {
            Panel_Ingresar.Visible = true;
            Panel_Registro.Visible = false;
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            Panel_Registro.Visible = true;
            Panel_Ingresar.Visible = false;
        }

        private void lblRecuperarPRecuperar_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarsesion_Click_1(object sender, EventArgs e)
        {
            string documento = txtIngresarusuario.Text.Trim();
            string contraseña = txtcontraseñaingresar.Text.Trim();

            if (string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = _usuariosCollection
                    .Find(u => u.NumeroDocumento == documento && u.Contraseña == contraseña)
                    .FirstOrDefault();

                if (usuario != null)
                {
                    // Si el rol es ADMIN
                    if (usuario.RolUsuario == "Administrador")
                    {
                        MessageBox.Show("Inicio de sesión exitoso como Administrador.", "Bienvenido",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmAdmin admin = new FrmAdmin();
                        admin.Show();
                        this.Hide();
                    }
                    // Si el rol es CLIENTE
                    else if (usuario.RolUsuario == "Cliente")
                    {
                        MessageBox.Show($"Bienvenido, {usuario.NombreUsuario}.", "Inicio de sesión exitoso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmCitas citas = new FrmCitas(usuario); // le pasamos el usuario logueado
                        citas.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Rol de usuario no reconocido.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Documento o contraseña incorrectos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el inicio de sesión: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txt_email.Text.Trim();
            string documento = txt_id.Text.Trim();
            string telefono = txtTel.Text.Trim();
            string contraseña = txtContra.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) ||
                string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(telefono) ||
                string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Verificar si el correo ya está registrado
                var existe = _usuariosCollection.Find(u => u.Correo == correo).Any();
                if (existe)
                {
                    MessageBox.Show("Ya existe una cuenta con ese correo.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear nuevo usuario
                Usuarios nuevoUsuario = new Usuarios
                {
                 
                    NombreUsuario = nombre,
                    Correo = correo,
                    NumeroDocumento = documento,
                    TelefonoUsuario = telefono,
                    Contraseña = contraseña,
                    RolUsuario = "Cliente",
                    
                };

                _usuariosCollection.InsertOne(nuevoUsuario);

                MessageBox.Show("Usuario registrado con éxito. Ahora puede iniciar sesión.",
                    "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                txtNombre.Clear();
                txtApellido.Clear();
                txt_email.Clear();
                txt_id.Clear();
                txtTel.Clear();
                txtContra.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

