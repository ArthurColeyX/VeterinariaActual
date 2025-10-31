using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class FrmAdmin : Form
    {
        // ================= COLECCIONES DE MONGODB =================
        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        private readonly IMongoCollection<Citas> _citasCollection;



        private List<Citas> _citasActuales;

        public Panel PanelCerrarSAdPublic => PanelCerrarSAd;
        public Panel PanelGestionUsuariosPublic => panelGestionUsuarios;

        // ================= VARIABLES AUXILIARES =================
        private List<Usuarios> _usuariosActuales;

        // ==========================================================
        public FrmAdmin()
        {
            InitializeComponent();

            var database = ConexionMongo.ObtenerConexion();
            _usuariosCollection = database.GetCollection<Usuarios>("Usuarios");
            _citasCollection = database.GetCollection<Citas>("Citas");

            ConfigurarDataGrid();

        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            panelCrearCita.Visible = false;
            CargarTodosLosUsuarios();
            CargarCitas(); // 👈 mostrar citas al cargar
            ActualizarContadoresCitas();
        }

        // ==========================================================
        // 🔹 MÉTODOS PARA OCULTAR Y MOSTRAR EL MENÚ
        private void OcultarControlesMenu()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != panelCrearCita)
                    ctrl.Visible = false;
            }
            panelCrearCita.Visible = true;
        }

        private void MostrarControlesMenu()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != panelCrearCita)
                    ctrl.Visible = true;
            }
            panelCrearCita.Visible = false;
        }

        // ==========================================================
        // 🔹 BOTÓN NUEVA CITA (abre el UserControl dentro del panel)
        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            panelCrearCita.Controls.Clear();

            var uc = new UserControl1();
            uc.Dock = DockStyle.Fill;

            uc.OnEdicionTerminada += (s, args) =>
            {
                MostrarControlesMenu();
                CargarCitas();
            };

            panelCrearCita.Controls.Add(uc);
            panelCrearCita.BringToFront();
            OcultarControlesMenu();
        }

        // ==========================================================
        // 🔹 CONFIGURACIÓN DEL DATAGRID DE USUARIOS
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
                datagridGestion.Columns["NombreUsuario"].HeaderText = "Nombre";
                datagridGestion.Columns["Correo"].HeaderText = "Correo";
                datagridGestion.Columns["NumeroDocumento"].HeaderText = "Documento";
                datagridGestion.Columns["TelefonoUsuario"].HeaderText = "Teléfono";
                datagridGestion.Columns["Contraseña"].Visible = false;
                datagridGestion.Columns["RolUsuario"].HeaderText = "Rol";
            }
        }

        // ==========================================================
        // 🔹 CARGAR CITAS EN EL DATAGRID DE CITAS
        private void CargarCitas()
        {
            try
            {
                var listaCitas = _citasCollection.Find(_ => true).ToList();
                datagridGestion.DataSource = listaCitas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar citas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // 🔹 CONTADORES DE CITAS
        private void ActualizarContadoresCitas()
        {
            try
            {
                var todasLasCitas = _citasCollection.Find(_ => true).ToList();

                int totalCitas = todasLasCitas.Count;
                int pendientes = todasLasCitas.Count(c => c.EstadoCita == "Pendiente");
                int confirmadas = todasLasCitas.Count(c => c.EstadoCita == "Confirmada" || c.EstadoCita == "Reprogramada");
                int completadas = todasLasCitas.Count(c => c.EstadoCita == "Completada");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar contadores: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // 🔹 BOTÓN EDITAR CITA (abre el UserControlEditarCita)
        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            if (datagridGestion.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cita para editar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var citaSeleccionada = datagridGestion.CurrentRow.DataBoundItem as Citas;
            if (citaSeleccionada == null)
            {
                MessageBox.Show("Error al obtener los datos de la cita.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear instancia del UserControl
            UserControlEditarCita controlEditar = new UserControlEditarCita(citaSeleccionada);
            controlEditar.Dock = DockStyle.Fill;

            // Evento cuando se termina la edición
            controlEditar.OnEdicionTerminada += (s, args) =>
            {
                panelCrearCita.Controls.Clear();
                CargarCitas(); // refrescar citas
                MostrarControlesMenu();
            };

            // Mostrar en el panel
            panelCrearCita.Controls.Clear();
            panelCrearCita.Controls.Add(controlEditar);
            controlEditar.BringToFront();

            // Ocultar menú
            OcultarControlesMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCrudUsuarios CrudUsuarios = new FrmCrudUsuarios();
            CrudUsuarios.Show();
            this.Hide();
        }

        private void comboBoxFiltroCitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Verifica que haya conexión y colección
                if (_citasCollection == null)
                {
                    MessageBox.Show("La colección de citas no está inicializada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cargar todas las citas desde la base de datos
                var todasLasCitas = _citasCollection.Find(_ => true).ToList();

                if (todasLasCitas == null || todasLasCitas.Count == 0)
                {
                    datagridGestion.DataSource = null;
                    MessageBox.Show("No hay citas registradas actualmente.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener el valor seleccionado
                string filtroSeleccionado = comboBoxFiltroCitas.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(filtroSeleccionado))
                    return;

                List<Citas> citasFiltradas = new List<Citas>();

                // Aplicar filtro según la selección
                switch (filtroSeleccionado)
                {
                    case "Todas las citas":
                        citasFiltradas = todasLasCitas;
                        break;

                    case "Pendientes":
                        citasFiltradas = todasLasCitas
                            .Where(c => c.EstadoCita == "Pendiente")
                            .ToList();
                        break;

                    case "Confirmadas":
                        citasFiltradas = todasLasCitas
                            .Where(c => c.EstadoCita == "Confirmada")
                            .ToList();
                        break;

                    case "Completadas":
                        citasFiltradas = todasLasCitas
                            .Where(c => c.EstadoCita == "Completada")
                            .ToList();
                        break;

                    case "Canceladas":
                        citasFiltradas = todasLasCitas
                            .Where(c => c.EstadoCita == "Cancelada")
                            .ToList();
                        break;

                    default:
                        citasFiltradas = todasLasCitas;
                        break;
                }

                // Mostrar en el DataGrid
                datagridGestion.DataSource = citasFiltradas;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar las citas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagridGestion.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una cita para eliminar.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var citaSeleccionada = datagridGestion.CurrentRow.DataBoundItem as Citas;
                if (citaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo obtener la cita seleccionada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmar eliminación
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro de eliminar la cita de '{citaSeleccionada.MascotaNombre}' " +
                    $"programada para el {citaSeleccionada.FechaCita} a las {citaSeleccionada.HoraCita}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.No)
                    return;

                // Eliminar cita en MongoDB
                var resultado = _citasCollection.DeleteOne(c => c._id == citaSeleccionada._id);

                if (resultado.DeletedCount > 0)
                {
                    MessageBox.Show("🗑️ Cita eliminada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 🔄 Recargar citas y actualizar contador
                    CargarCitas();
                    ActualizarContadoresCitas();

                    // Si tienes el filtro activo, lo aplicamos de nuevo
                    if (comboBoxFiltroCitas.SelectedItem != null)
                    {
                        comboBoxFiltroCitas_SelectedIndexChanged(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("⚠️ No se pudo eliminar la cita (puede que ya no exista).",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la cita: {ex.Message}", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void CerrarSesionAdmi_Click(object sender, EventArgs e)
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
    }
}
