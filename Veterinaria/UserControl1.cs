using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class UserControl1 : UserControl
    {
        private readonly IMongoCollection<Citas> _citasCollection;
        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        private readonly IMongoCollection<Mascota> _mascotasCollection;

        public event EventHandler OnEdicionTerminada;

        public UserControl1()
        {
            InitializeComponent();

            var db = ConexionMongo.ObtenerConexion();
            _citasCollection = db.GetCollection<Citas>("Citas");
            _usuariosCollection = db.GetCollection<Usuarios>("Usuarios");
            _mascotasCollection = db.GetCollection<Mascota>("Mascota");

            dtpFecha.MinDate = DateTime.Today;
            comboBoxMascotas.Enabled = false;

            CargarUsuarios();
            CargarServicios();

            comboBoxUsuarios.SelectedIndexChanged += comboBoxUsuarios_SelectedIndexChanged;
        }

        private void UserControl1_Load(object sender, EventArgs e) {
            
            }
        

        // ================== CARGAR USUARIOS ==================
        private void CargarUsuarios()
        {
            try
            {
                var usuarios = _usuariosCollection
                    .Find(u => u.RolUsuario != "Administrador")
                    .ToList();

                comboBoxUsuarios.DisplayMember = "NombreUsuario"; // Mostrar nombre
                comboBoxUsuarios.DataSource = usuarios;
                comboBoxUsuarios.SelectedIndex = -1;

                Console.WriteLine("Usuarios cargados:");
                foreach (var u in usuarios)
                    Console.WriteLine($"Nombre: '{u.NombreUsuario}', NúmeroDocumento: '{u.NumeroDocumento}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== CARGAR MASCOTAS DEL USUARIO ==================
        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMascotas.DataSource = null;
            comboBoxMascotas.Enabled = false;

            if (comboBoxUsuarios.SelectedItem == null)
                return;

            try
            {
                Usuarios usuarioSeleccionado = comboBoxUsuarios.SelectedItem as Usuarios;
                if (usuarioSeleccionado == null)
                    return;

                // ---------------- DEPURACIÓN: MOSTRAR TODAS LAS MASCOTAS ----------------
                var todasMascotas = _mascotasCollection.Find(FilterDefinition<Mascota>.Empty).ToList();
                Console.WriteLine("=== TODAS LAS MASCOTAS EN BD ===");
                foreach (var m in todasMascotas)
                {
                    string dueño = m.NumeroDocumentoDueño ?? "(null)";
                    Console.WriteLine($"Mascota: '{m.NombreMascota}', Dueño: '{dueño}' (Tipo: {m.NumeroDocumentoDueño?.GetType()})");
                }
                Console.WriteLine("================================");

                string numeroDocumento = usuarioSeleccionado.NumeroDocumento?.Trim();
                if (string.IsNullOrEmpty(numeroDocumento))
                    return;

                Console.WriteLine($"Buscando mascotas para el número de documento: '{numeroDocumento}'");

                var filter = Builders<Mascota>.Filter.Eq("numeroDocumentoDueño", numeroDocumento);
                var mascotas = _mascotasCollection.Find(filter).ToList();

                Console.WriteLine($"Mascotas encontradas: {mascotas.Count}");

                if (mascotas.Count == 0)
                {
                    MessageBox.Show("Este usuario no tiene mascotas registradas.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxMascotas.DisplayMember = "NombreMascota";
                comboBoxMascotas.ValueMember = "_id";
                comboBoxMascotas.DataSource = mascotas;
                comboBoxMascotas.SelectedIndex = -1;
                comboBoxMascotas.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar mascotas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== CARGAR SERVICIOS ==================
        private void CargarServicios()
        {
            var servicios = new List<string>
            {
                "Consulta General",
                "Vacunación",
                "Desparasitación",
                "Corte de Uñas",
                "Baño y Aseo"
            };

            comboBoxServicio.DataSource = servicios;
            comboBoxServicio.SelectedIndex = -1;
        }

        // ================== BOTÓN CREAR CITA ==================
        private void CrearCitaAdmi_Click(object sender, EventArgs e)
        {
            comboBoxMascotas.DataSource = null;
            comboBoxMascotas.Enabled = false;

            if (comboBoxUsuarios.SelectedItem == null)
                return;

            try
            {
                Usuarios usuarioSeleccionado = comboBoxUsuarios.SelectedItem as Usuarios;
                if (usuarioSeleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el usuario seleccionado.");
                    return;
                }

                string numeroDocumento = usuarioSeleccionado.NumeroDocumento;
                Console.WriteLine($"Buscando mascotas para el número de documento: '{numeroDocumento}'");

                // ================== FILTRO SIMPLE Y FUNCIONAL ==================
                // Comparación exacta (case-insensitive con regex)
                var filter = Builders<Mascota>.Filter.Regex(
                    m => m.NumeroDocumentoDueño,
                    new MongoDB.Bson.BsonRegularExpression($"^{numeroDocumento}$", "i")
                );

                var mascotas = _mascotasCollection.Find(filter).ToList();

                // ================== DEPURACIÓN ==================
                var todasMascotas = _mascotasCollection.Find(FilterDefinition<Mascota>.Empty).ToList();
                Console.WriteLine("=== TODAS LAS MASCOTAS EN BD ===");
                foreach (var m in todasMascotas)
                {
                    Console.WriteLine($"Mascota: '{m.NombreMascota}', Dueño: '{m.NumeroDocumentoDueño}'");
                }
                Console.WriteLine("================================");

                Console.WriteLine($"Mascotas encontradas: {mascotas.Count}");

                if (mascotas.Count == 0)
                {
                    MessageBox.Show("Este usuario no tiene mascotas registradas.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    comboBoxMascotas.DisplayMember = "NombreMascota";
                    comboBoxMascotas.ValueMember = "_id";
                    comboBoxMascotas.DataSource = mascotas;
                    comboBoxMascotas.SelectedIndex = -1;
                    comboBoxMascotas.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar mascotas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== BOTÓN CANCELAR ==================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OnEdicionTerminada?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}
