using MongoDB.Bson;
using MongoDB.Bson.IO;
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

            // Config inicial
            dtpFecha.MinDate = DateTime.Today;
            comboBoxMascotas.Enabled = false;

            // === DTP HORA ===
            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.CustomFormat = "hh:mm tt";
            dtpHora.ShowUpDown = true;
            dtpHora.Value = DateTime.Today.AddHours(8); // 8:00 a.m.

            // 👇 Eventos para avanzar 30 minutos
            dtpHora.KeyDown += DtpHora_KeyDown;
            dtpHora.MouseWheel += DtpHora_MouseWheel;

            CargarUsuarios();
            CargarServicios();

            comboBoxUsuarios.SelectedIndexChanged += comboBoxUsuarios_SelectedIndexChanged;
        }

        private void UserControl1_Load(object sender, EventArgs e) { }

        // ================== CARGAR USUARIOS ==================
        private void CargarUsuarios()
        {
            try
            {
                var usuarios = _usuariosCollection
                    .Find(u => u.RolUsuario != "Administrador")
                    .ToList();

                comboBoxUsuarios.DisplayMember = "NombreUsuario";
                comboBoxUsuarios.DataSource = usuarios;
                comboBoxUsuarios.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== CARGAR MASCOTAS ==================
        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMascotas.DataSource = null;
            comboBoxMascotas.Enabled = false;

            if (comboBoxUsuarios.SelectedItem == null)
                return;

            try
            {
                Usuarios usuario = comboBoxUsuarios.SelectedItem as Usuarios;
                string numeroDocumento = usuario?.NumeroDocumento?.Trim();
                if (string.IsNullOrEmpty(numeroDocumento))
                    return;

                var filter = Builders<Mascota>.Filter.Eq("numeroDocumentoDueño", numeroDocumento);
                var mascotas = _mascotasCollection.Find(filter).ToList();

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
            if (comboBoxUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un dueño.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxMascotas.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una mascota.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxServicio.Text.Trim()))
            {
                MessageBox.Show("Seleccione un servicio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaSeleccionada = dtpFecha.Value.Date;
            DateTime horaSeleccionada = dtpHora.Value;
            DateTime fechaHoraCita = fechaSeleccionada.Add(horaSeleccionada.TimeOfDay);
            DateTime ahora = DateTime.Now;

            if (horaSeleccionada.Hour < 8 || horaSeleccionada.Hour >= 18)
            {
                MessageBox.Show("El horario permitido es de 8:00 a.m. a 6:00 p.m.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fechaSeleccionada == ahora.Date && fechaHoraCita < ahora)
            {
                MessageBox.Show("No puede seleccionar una hora pasada para hoy.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Usuarios usuarioSeleccionado = comboBoxUsuarios.SelectedItem as Usuarios;

                // 🔒 VALIDACIÓN: verificar si ya existe una cita con esa mascota, fecha y hora
                var filter = Builders<Citas>.Filter.And(
                    Builders<Citas>.Filter.Eq(c => c.MascotaNombre, comboBoxMascotas.Text),
                    Builders<Citas>.Filter.Eq(c => c.FechaCita, fechaSeleccionada.ToString("yyyy-MM-dd")),
                    Builders<Citas>.Filter.Eq(c => c.HoraCita, horaSeleccionada.ToString("hh:mm tt"))
                );

                var citaExistente = _citasCollection.Find(filter).FirstOrDefault();
                if (citaExistente != null)
                {
                    MessageBox.Show("Ya existe una cita para esta mascota en la fecha y hora seleccionadas.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Crear cita
                Citas nuevaCita = new Citas
                {
                    UsuarioDocumento = usuarioSeleccionado.NumeroDocumento,
                    MascotaNombre = comboBoxMascotas.Text,
                    FechaCita = fechaSeleccionada.ToString("yyyy-MM-dd"),
                    HoraCita = horaSeleccionada.ToString("hh:mm tt"),
                    ServicioCita = comboBoxServicio.SelectedItem.ToString(),
                    NotasCita = txtNotas.Text.Trim(),
                    FechaCreacion = DateTime.Now
                };

                _citasCollection.InsertOne(nuevaCita);

                MessageBox.Show($"✅ Cita registrada correctamente para {nuevaCita.MascotaNombre}\n" +
                    $"{nuevaCita.FechaCita} a las {nuevaCita.HoraCita}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboBoxUsuarios.SelectedIndex = -1;
                comboBoxMascotas.DataSource = null;
                comboBoxMascotas.Enabled = false;
                comboBoxServicio.SelectedIndex = -1;
                dtpFecha.Value = DateTime.Now;
                dtpHora.Value = DateTime.Today.AddHours(8);
                txtNotas.Clear();

                OnEdicionTerminada?.Invoke(this, EventArgs.Empty);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la cita: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== CONTROL DE INTERVALOS ==================
        private void DtpHora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                CambiarIntervalo(30);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                CambiarIntervalo(-30);
                e.Handled = true;
            }
        }

        private void DtpHora_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                CambiarIntervalo(30);
            else
                CambiarIntervalo(-30);
        }

        private void CambiarIntervalo(int minutos)
        {
            DateTime nuevaHora = dtpHora.Value.AddMinutes(minutos);

            // Restringir horario de 8:00 AM a 6:00 PM
            if (nuevaHora.Hour < 8)
                nuevaHora = new DateTime(nuevaHora.Year, nuevaHora.Month, nuevaHora.Day, 8, 0, 0);
            else if (nuevaHora.Hour > 17 || (nuevaHora.Hour == 17 && nuevaHora.Minute > 30))
                nuevaHora = new DateTime(nuevaHora.Year, nuevaHora.Month, nuevaHora.Day, 17, 30, 0);

            dtpHora.Value = nuevaHora;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OnEdicionTerminada?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}
