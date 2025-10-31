using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class UserContEditarUsuario : UserControl
    {
        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        private readonly Usuarios _usuarioOriginal;

        public event EventHandler OnUsuarioEditado;

        public UserContEditarUsuario(Usuarios usuarioSeleccionado)
        {
            InitializeComponent();

            var database = ConexionMongo.ObtenerConexion();
            _usuariosCollection = database.GetCollection<Usuarios>("Usuarios");
            _usuarioOriginal = usuarioSeleccionado;

            // Validaciones
            if (txtTelEditarU != null) txtTelEditarU.KeyPress += OnlyDigits_KeyPress;
            if (txt_idEditar != null) txt_idEditar.KeyPress += OnlyDigits_KeyPress;
            if (txtNombreEditarU != null) txtNombreEditarU.KeyPress += OnlyLetters_KeyPress;
            if (txtApellidoEditarU != null) txtApellidoEditarU.KeyPress += OnlyLetters_KeyPress;

            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            if (_usuarioOriginal == null)
            {
                MessageBox.Show("No se seleccionó ningún usuario para editar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNombreEditarU.Text = _usuarioOriginal.NombreUsuario;
            txtApellidoEditarU.Text = _usuarioOriginal.ApellidoUsuario;
            txt_idEditar.Text = _usuarioOriginal.NumeroDocumento;
            txtTelEditarU.Text = _usuarioOriginal.TelefonoUsuario;
            txtCorreoEditarU.Text = _usuarioOriginal.Correo;            
            ComBoxRolCrudNU.Text = _usuarioOriginal.RolUsuario;
            txtContraEditarU.Text = _usuarioOriginal.Contraseña
            ;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Validaciones
                if (string.IsNullOrWhiteSpace(txtNombreEditarU.Text) ||
                    string.IsNullOrWhiteSpace(txt_idEditar.Text) ||
                    string.IsNullOrWhiteSpace(txtTelEditarU.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreoEditarU.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoEditarU.Text) ||
                    string.IsNullOrWhiteSpace(ComBoxRolCrudNU.Text) ||
                    string.IsNullOrWhiteSpace(txtContraEditarU.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateEmail(txtCorreoEditarU.Text.Trim()))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🚫 Verificar si el número de documento ya existe (excepto si es el mismo usuario)
                var existe = _usuariosCollection.Find(u =>
                    u.NumeroDocumento == txt_idEditar.Text &&
                    u._id != _usuarioOriginal._id
                ).FirstOrDefault();

                if (existe != null)
                {
                    MessageBox.Show("Ya existe otro usuario con ese número de documento.", "Duplicado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Actualizar usuario
                var update = Builders<Usuarios>.Update
                    .Set(u => u.NombreUsuario, txtNombreEditarU.Text)
                    .Set(u => u.NumeroDocumento, txt_idEditar.Text)
                    .Set(u => u.TelefonoUsuario, txtTelEditarU.Text)
                    .Set(u => u.Correo, txtCorreoEditarU.Text)
                    .Set(u => u.ApellidoUsuario, txtApellidoEditarU.Text)
                    .Set(u => u.RolUsuario, ComBoxRolCrudNU.Text)
                    .Set(u => u.Contraseña, txtContraEditarU.Text);

                var result = _usuariosCollection.UpdateOne(u => u._id == _usuarioOriginal._id, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("✅ Usuario actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("⚠️ No se realizaron cambios.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                OnUsuarioEditado?.Invoke(this, EventArgs.Empty);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el usuario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OnUsuarioEditado?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }

        private void EditarUsuarioAdmi_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombreEditarU.Text) ||
                    string.IsNullOrWhiteSpace(txt_idEditar.Text) ||
                    string.IsNullOrWhiteSpace(txtTelEditarU.Text) || 
                    string.IsNullOrWhiteSpace(txtCorreoEditarU.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoEditarU.Text) ||
                    string.IsNullOrWhiteSpace(ComBoxRolCrudNU.Text) ||
                    string.IsNullOrWhiteSpace(txtContraEditarU.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de guardar.",
                        "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateEmail(txtCorreoEditarU.Text.Trim()))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🚫 Validar duplicado de documento
                var duplicado = _usuariosCollection.Find(u =>
                    u.NumeroDocumento == txt_idEditar.Text &&
                    u._id != _usuarioOriginal._id
                ).FirstOrDefault();

                if (duplicado != null)
                {
                    MessageBox.Show("Ya existe otro usuario con ese número de documento.",
                        "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Actualizar usuario
                var update = Builders<Usuarios>.Update
                    .Set(u => u.NombreUsuario, txtNombreEditarU.Text)
                    .Set(u => u.NumeroDocumento, txt_idEditar.Text)
                    .Set(u => u.TelefonoUsuario, txtTelEditarU.Text)
                    .Set(u => u.Correo, txtCorreoEditarU.Text)
                    .Set(u => u.ApellidoUsuario, txtApellidoEditarU.Text)
                    .Set(u => u.RolUsuario, ComBoxRolCrudNU.Text)
                    .Set(u => u.Contraseña, txtContraEditarU.Text);

                var result = _usuariosCollection.UpdateOne(u => u._id == _usuarioOriginal._id, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("✅ Usuario actualizado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("⚠️ No se realizaron cambios.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // 🔄 Refrescar DataGrid
                OnUsuarioEditado?.Invoke(this, EventArgs.Empty);

                // 🔒 Cerrar panel
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el usuario: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirEU_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Deseas cancelar la edición del usuario?",
               "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                OnUsuarioEditado?.Invoke(this, EventArgs.Empty);
                this.Dispose();
            }
        }

        // ======= VALIDATORS =======
        private void OnlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true;
            }
        }

        private bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return email.Contains("@") && email.Contains(".");
        }
    }
}
