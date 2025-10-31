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
    public partial class UserContNuevoUsu : UserControl
    {

        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        public event EventHandler OnUsuarioCreado;
        public UserContNuevoUsu()
        {
            InitializeComponent();
            var database = ConexionMongo.ObtenerConexion();
            _usuariosCollection = database.GetCollection<Usuarios>("Usuarios");
        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void CrearUsuarioAdmi_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔹 Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtNombreCrearU.Text) ||
                    string.IsNullOrWhiteSpace(txt_id.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreoCrearU.Text) ||
                    string.IsNullOrWhiteSpace(txtContraCrearU.Text) ||
                    ComBoxRolCrudNU.SelectedIndex == -1)
                {
                    MessageBox.Show("⚠️ Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Validar que el documento no exista
                var existe = _usuariosCollection.Find(u => u.NumeroDocumento == txt_id.Text).FirstOrDefault();
                if (existe != null)
                {
                    MessageBox.Show("⚠️ Ya existe un usuario con ese número de documento.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Crear nuevo usuario
                var nuevoUsuario = new Usuarios
                {
                    NombreUsuario = txtNombreCrearU.Text.Trim(),
                    ApellidoUsuario = txtApellidoCrearU.Text.Trim(),
                    NumeroDocumento = txt_id.Text.Trim(),
                    Correo = txtCorreoCrearU.Text.Trim(),
                    TelefonoUsuario = txtTelCrearU.Text.Trim(),
                    Contraseña = txtContraCrearU.Text.Trim(),
                    RolUsuario = ComBoxRolCrudNU.Text
                };

                _usuariosCollection.InsertOne(nuevoUsuario);

                MessageBox.Show("✅ Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnUsuarioCreado?.Invoke(this, EventArgs.Empty);
                this.Dispose(); // Cierra el control al guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al guardar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirNU_Click(object sender, EventArgs e)
        {
            OnUsuarioCreado?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}
