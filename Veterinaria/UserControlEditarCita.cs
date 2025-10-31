using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class UserControlEditarCita : UserControl
    {
        private readonly IMongoCollection<Citas> _citasCollection;
        private readonly IMongoCollection<Usuarios> _usuariosCollection;
        private readonly IMongoCollection<Mascota> _mascotasCollection;

        private readonly Citas _citaOriginal;
        public event EventHandler OnEdicionTerminada;

        public UserControlEditarCita(Citas citaSeleccionada)
        {
            InitializeComponent();

            var database = ConexionMongo.ObtenerConexion();
            _citasCollection = database.GetCollection<Citas>("Citas");
            _usuariosCollection = database.GetCollection<Usuarios>("Usuarios");
            _mascotasCollection = database.GetCollection<Mascota>("Mascota");

            _citaOriginal = citaSeleccionada;

            // Config inicial
            dtpFechaEditar.MinDate = DateTime.Today;
            dtpHoraEditar.Format = DateTimePickerFormat.Custom;
            dtpHoraEditar.CustomFormat = "hh:mm tt";
            dtpHoraEditar.ShowUpDown = true;

            // Eventos
            dtpHoraEditar.ValueChanged += DtpHoraEditar_ValueChanged;
            comboBoxUsuariosEditar.SelectedIndexChanged += ComboBoxUsuariosEditar_SelectedIndexChanged;

            CargarUsuarios();
            CargarServicios();
            CargarDatosCita();
        }

        // ================== CARGAR USUARIOS ==================
        private void CargarUsuarios()
        {
            try
            {
                var usuarios = _usuariosCollection
                    .Find(u => u.RolUsuario != "Administrador")
                    .ToList();

                comboBoxUsuariosEditar.DisplayMember = "NombreUsuario";
                comboBoxUsuariosEditar.ValueMember = "NumeroDocumento";
                comboBoxUsuariosEditar.DataSource = usuarios;
                comboBoxUsuariosEditar.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================== CARGAR MASCOTAS ==================
        private void ComboBoxUsuariosEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMascotasEditar.DataSource = null;
            comboBoxMascotasEditar.Enabled = false;

            if (comboBoxUsuariosEditar.SelectedItem == null)
                return;

            try
            {
                var usuario = comboBoxUsuariosEditar.SelectedItem as Usuarios;
                string numeroDocumento = usuario?.NumeroDocumento?.Trim();
                if (string.IsNullOrEmpty(numeroDocumento))
                    return;

                var filter = Builders<Mascota>.Filter.Eq("numeroDocumentoDueño", numeroDocumento);
                var mascotas = _mascotasCollection.Find(filter).ToList();

                comboBoxMascotasEditar.DisplayMember = "NombreMascota";
                comboBoxMascotasEditar.ValueMember = "_id";
                comboBoxMascotasEditar.DataSource = mascotas;
                comboBoxMascotasEditar.Enabled = true;
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
            comboBoxServicioEditar.DataSource = servicios;
            comboBoxServicioEditar.SelectedIndex = -1;
        }

        // ================== CARGAR DATOS DE LA CITA ==================
        private void CargarDatosCita()
        {
            comboBoxUsuariosEditar.Text = _citaOriginal.UsuarioDocumento;
            comboBoxMascotasEditar.Text = _citaOriginal.MascotaNombre;
            comboBoxServicioEditar.Text = _citaOriginal.ServicioCita;
            txtNotasEditar.Text = _citaOriginal.NotasCita;

            if (DateTime.TryParse(_citaOriginal.FechaCita, out DateTime fecha))
                dtpFechaEditar.Value = fecha;
            if (DateTime.TryParse(_citaOriginal.HoraCita, out DateTime hora))
                dtpHoraEditar.Value = hora;
        }

        // ================== INTERVALOS DE 30 MINUTOS ==================
        private void DtpHoraEditar_ValueChanged(object sender, EventArgs e)
        {
            DateTime valor = dtpHoraEditar.Value;
            int minutos = valor.Minute;
            int minutosAjustados = (minutos < 15) ? 0 :
                                   (minutos < 45) ? 30 : 0;

            valor = new DateTime(valor.Year, valor.Month, valor.Day,
                                 valor.Hour, minutosAjustados, 0);

            // Limitar horario de atención
            if (valor.Hour < 8)
                valor = new DateTime(valor.Year, valor.Month, valor.Day, 8, 0, 0);
            else if (valor.Hour > 17 || (valor.Hour == 17 && valor.Minute > 30))
                valor = new DateTime(valor.Year, valor.Month, valor.Day, 17, 30, 0);

            if (dtpHoraEditar.Value != valor)
                dtpHoraEditar.Value = valor;
        }

        // ================== BOTÓN ACTUALIZAR CITA ==================
        private void ActualizarCitaAdmi_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuariosEditar.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un dueño.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxMascotasEditar.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una mascota.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxServicioEditar.Text.Trim()))
            {
                MessageBox.Show("Seleccione un servicio.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaSeleccionada = dtpFechaEditar.Value.Date;
            DateTime horaSeleccionada = dtpHoraEditar.Value;
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
                var usuarioSeleccionado = comboBoxUsuariosEditar.SelectedItem as Usuarios;

                // 🔍 Verificar si ya existe una cita igual (otra distinta de la actual)
                var filterConflicto = Builders<Citas>.Filter.And(
                    Builders<Citas>.Filter.Eq(c => c.MascotaNombre, comboBoxMascotasEditar.Text),
                    Builders<Citas>.Filter.Eq(c => c.FechaCita, fechaSeleccionada.ToString("yyyy-MM-dd")),
                    Builders<Citas>.Filter.Eq(c => c.HoraCita, horaSeleccionada.ToString("hh:mm tt")),
                    Builders<Citas>.Filter.Ne(c => c._id, _citaOriginal._id)
                );

                var citaExistente = _citasCollection.Find(filterConflicto).FirstOrDefault();
                if (citaExistente != null)
                {
                    MessageBox.Show("⚠️ Ya existe una cita para esta mascota en esa fecha y hora.",
                        "Conflicto de horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Actualizar
                var update = Builders<Citas>.Update
                    .Set(c => c.UsuarioDocumento, usuarioSeleccionado.NumeroDocumento)
                    .Set(c => c.MascotaNombre, comboBoxMascotasEditar.Text)
                    .Set(c => c.ServicioCita, comboBoxServicioEditar.Text)
                    .Set(c => c.NotasCita, txtNotasEditar.Text)
                    .Set(c => c.FechaCita, fechaSeleccionada.ToString("yyyy-MM-dd"))
                    .Set(c => c.HoraCita, horaSeleccionada.ToString("hh:mm tt"));

                _citasCollection.UpdateOne(c => c._id == _citaOriginal._id, update);

                MessageBox.Show($"✅ Cita actualizada correctamente para {comboBoxMascotasEditar.Text}\n" +
                    $"{fechaSeleccionada:yyyy-MM-dd} a las {horaSeleccionada:hh:mm tt}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OnEdicionTerminada?.Invoke(this, EventArgs.Empty);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la cita: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UserControlEditarCita_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OnEdicionTerminada?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}
