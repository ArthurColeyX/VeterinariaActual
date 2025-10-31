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

            // Si tu UserControl recibe parámetros, agrégalos aquí
            var uc = new UserControl1();
            uc.Dock = DockStyle.Fill;

            // Suscribirse al evento del control para regresar al menú
            uc.OnEdicionTerminada += (s, args) => MostrarControlesMenu();

            panelCrearCita.Controls.Add(uc);
            panelCrearCita.BringToFront();

            // Oculta el resto del menú mientras el UserControl está activo
            OcultarControlesMenu();
        }

        // ==========================================================
        // 🔹 RESTO DE TU CÓDIGO ORIGINAL (no se modifica)
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
    }
}
