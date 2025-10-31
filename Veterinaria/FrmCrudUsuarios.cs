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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria
{
    public partial class FrmCrudUsuarios : Form
    {

        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        private List<Usuarios> _usuariosActuales;

        public FrmCrudUsuarios()
        {
            InitializeComponent();

            var database = ConexionMongo.ObtenerConexion();
            _usuariosCollection = database.GetCollection<Usuarios>("Usuarios");

            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                _usuariosActuales = _usuariosCollection.Find(_ => true).ToList();
                dgvCrudUsuarios.DataSource = _usuariosActuales;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdmin Citas = new FrmAdmin();
            Citas.Show();
            this.Hide();
        }

        private void FrmCrudUsuarios_Load(object sender, EventArgs e)
        {
            panelUsuarios.Visible = false;
        }

        private void OcultarControlesMenu()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != panelUsuarios)
                    ctrl.Visible = false;
            }
            panelUsuarios.Visible = true;
        }

        private void MostrarControlesMenu()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != panelUsuarios)
                    ctrl.Visible = true;
            }
            panelUsuarios.Visible = false;

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {

            panelUsuarios.Controls.Clear();

            var uc = new UserContNuevoUsu();
            uc.Dock = DockStyle.Fill;

            // Cuando termine la creación del usuario, vuelve al menú y recarga
            uc.OnUsuarioCreado += (s, args) =>
            {
                MostrarControlesMenu();
                CargarUsuarios();
            };

            panelUsuarios.Controls.Add(uc);
            panelUsuarios.BringToFront();
            OcultarControlesMenu();
        }

        private void btnEditarCrud_Click(object sender, EventArgs e)
        {
            if (dgvCrudUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario para editar.");
                return;
            }

            // Obtener el usuario seleccionado
            var usuarioSeleccionado = dgvCrudUsuarios.CurrentRow.DataBoundItem as Usuarios;

            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener la información del usuario seleccionado.");
                return;
            }

            panelUsuarios.Controls.Clear();

            var uc = new UserContEditarUsuario(usuarioSeleccionado);
            uc.Dock = DockStyle.Fill;

            uc.OnUsuarioEditado += (s, args) =>
            {
                MostrarControlesMenu();
                CargarUsuarios();
            };

            panelUsuarios.Controls.Add(uc);
            panelUsuarios.BringToFront();
            OcultarControlesMenu();
        }

        private void PanelCerrarSCrud_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CerrarSesionUsuario_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Seguro que deseas cerrar sesión?",
            "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void btnEliminarCrud_Click(object sender, EventArgs e)
        {
            if (dgvCrudUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var usuarioSeleccionado = dgvCrudUsuarios.CurrentRow.DataBoundItem as Usuarios;
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Error al obtener los datos del usuario.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirmar = MessageBox.Show(
                $"¿Deseas eliminar al usuario {usuarioSeleccionado.NombreUsuario}?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    var resultado = _usuariosCollection.DeleteOne(u => u._id == usuarioSeleccionado._id);

                    if (resultado.DeletedCount > 0)
                    {
                        MessageBox.Show("✅ Usuario eliminado correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargar DataGridView
                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ No se pudo eliminar el usuario.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmCrudUsuarios_Activated(object sender, EventArgs e)
        {
            // Volver a cargar los usuarios al reactivar el formulario
            CargarUsuarios();
        }
    }
}
