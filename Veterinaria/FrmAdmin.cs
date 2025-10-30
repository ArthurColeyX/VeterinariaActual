using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Veterinaria
{
    public partial class FrmAdmin : Form
    {
        // ================= COLECCIONES DE MONGODB =================
        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        private readonly IMongoCollection<Citas> _citasCollection;

        // ================= VARIABLES AUXILIARES =================
        private List<Usuarios> _usuariosActuales;

        // ================= CONTROLES USADOS =================
        

        public FrmAdmin()
        {
            InitializeComponent();
            
            // ================= CONEXIÓN A MONGODB =================
            var database = ConexionMongo.ObtenerConexion();
            _usuariosCollection = database.GetCollection<Usuarios>("Usuarios");
            _citasCollection = database.GetCollection<Citas>("Citas");

            ConfigurarDataGrid();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            CargarTodosLosUsuarios();
            ActualizarContadoresCitas();
        }

        // ================= DATAGRID =================
        private void ConfigurarDataGrid()
        {
            datagridGestion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridGestion.MultiSelect = false;
            datagridGestion.ReadOnly = true;
            datagridGestion.AllowUserToAddRows = false;
            datagridGestion.AllowUserToDeleteRows = false;
            datagridGestion.RowHeadersVisible = false;
            datagridGestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            datagridGestion.EnableHeadersVisualStyles = false;
            datagridGestion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(59, 130, 246);
            datagridGestion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridGestion.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void CargarUsuarios()
        {
            try
            {
                // 🔍 Obtener todos los usuarios que no sean administradores
                _usuariosActuales = _usuariosCollection
                    .Find(u => u.RolUsuario != "Administrador")
                    .ToList();

                // Mostrar en el DataGridView
                datagridGestion.DataSource = _usuariosActuales;

                // Personalizar las columnas
                ConfigurarColumnasUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al cargar los usuarios:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasUsuarios()
        {
            if (datagridGestion.Columns.Count == 0) return;

            datagridGestion.Columns["_id"].HeaderText = "ID";
            datagridGestion.Columns["NombreUsuario"].HeaderText = "Nombre";
            datagridGestion.Columns["Correo"].HeaderText = "Correo";
            datagridGestion.Columns["NumeroDocumento"].HeaderText = "Documento";
            datagridGestion.Columns["TelefonoUsuario"].HeaderText = "Teléfono";
            datagridGestion.Columns["RolUsuario"].HeaderText = "Rol";

            // Ocultar la contraseña si está en la clase
            if (datagridGestion.Columns.Contains("Contraseña"))
                datagridGestion.Columns["Contraseña"].Visible = false;
        }

        private void CargarTodosLosUsuarios()
        {
            try
            {
                _usuariosActuales = _usuariosCollection
                    .Find(u => u.RolUsuario != "Administrador")
                    .ToList();

                datagridGestion.DataSource = _usuariosActuales;
                ConfigurarColumnasDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasDataGrid()
        {
            if (datagridGestion.Columns.Count > 0)
            {
                datagridGestion.Columns["_id"].HeaderText = "ID";
                datagridGestion.Columns["_id"].ReadOnly = true;
                datagridGestion.Columns["_id"].Width = 100;

                datagridGestion.Columns["NombreUsuario"].HeaderText = "Nombre";
                datagridGestion.Columns["NombreUsuario"].Width = 150;

                datagridGestion.Columns["Correo"].HeaderText = "Correo";
                datagridGestion.Columns["Correo"].Width = 180;

                datagridGestion.Columns["NumeroDocumento"].HeaderText = "Documento";
                datagridGestion.Columns["NumeroDocumento"].Width = 100;

                datagridGestion.Columns["TelefonoUsuario"].HeaderText = "Teléfono";
                datagridGestion.Columns["TelefonoUsuario"].Width = 120;

                datagridGestion.Columns["Contraseña"].Visible = false;
                datagridGestion.Columns["RolUsuario"].HeaderText = "Rol";
                datagridGestion.Columns["RolUsuario"].Width = 100;
            }
        }

        // ================= BÚSQUEDA =================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Ingrese un número de documento para buscar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = _usuariosCollection
                    .Find(u => u.NumeroDocumento == cedula)
                    .FirstOrDefault();

                if (usuario != null)
                {
                    datagridGestion.DataSource = new List<Usuarios> { usuario };
                    ActualizarContadoresUsuarioEspecifico(usuario._id);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario con esa cédula.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTodosLosUsuarios();
                    ActualizarContadoresCitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar usuario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_DoubleClick(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarTodosLosUsuarios();
            ActualizarContadoresCitas();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarTodosLosUsuarios();
            txtBuscar.Clear();
            ActualizarContadoresCitas();

            MessageBox.Show("Mostrando todos los usuarios.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                datagridGestion.BeginEdit(true);
        }

        // ================= CONTADORES =================
        private void ActualizarContadoresCitas()
        {
            try
            {
                var todasLasCitas = _citasCollection.Find(_ => true).ToList();

                int totalCitas = todasLasCitas.Count;
                int pendientes = todasLasCitas.Count(c => c.EstadoCita == "Pendiente");
                int confirmadas = todasLasCitas.Count(c => c.EstadoCita == "Confirmada" || c.EstadoCita == "Reprogramada");
                int completadas = todasLasCitas.Count(c => c.EstadoCita == "Completada");

                lblTotalCitas.Text = $"Total citas: {totalCitas}";
                lblCitasPendientes.Text = $"Pendientes: {pendientes}";
                lblCitasConfirmadas.Text = $"Confirmadas: {confirmadas}";
                lblCitasCompletadas.Text = $"Completadas: {completadas}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar contadores: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarContadoresUsuarioEspecifico(string usuarioId)
        {
            try
            {
                var citasUsuario = _citasCollection.Find(c => c.UsuarioDocumento == usuarioId).ToList();

                int totalCitas = citasUsuario.Count;
                int pendientes = citasUsuario.Count(c => c.EstadoCita == "Pendiente");
                int confirmadas = citasUsuario.Count(c => c.EstadoCita == "Confirmada" || c.EstadoCita == "Reprogramada");
                int completadas = citasUsuario.Count(c => c.EstadoCita   == "Completada");

                lblTotalCitas.Text = $"Total citas: {totalCitas}";
                lblCitasPendientes.Text = $"Pendientes: {pendientes}";
                lblCitasConfirmadas.Text = $"Confirmadas: {confirmadas}";
                lblCitasCompletadas.Text = $"Completadas: {completadas}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar contadores del usuario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridGestion.SelectedRows.Count > 0)
            {
                var usuarioSeleccionado = datagridGestion.SelectedRows[0].DataBoundItem as Usuarios;
                if (usuarioSeleccionado != null)
                    ActualizarContadoresUsuarioEspecifico(usuarioSeleccionado._id);
            }
        }

        private void lblCitasPendientes_Click(object sender, EventArgs e)
        {

        }

        private void panelGestionUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {

        }
    }
}
