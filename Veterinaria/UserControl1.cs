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
    public partial class UserControl1 : UserControl
    {

        private readonly IMongoCollection<Citas> _citasCollection;
        private readonly IMongoCollection<Usuarios> _usuariosCollection;

        public UserControl1()
        {
            InitializeComponent();
            var db = ConexionMongo.ObtenerConexion();
            _citasCollection = db.GetCollection<Citas>("Citas");
            _usuariosCollection = db.GetCollection<Usuarios>("Usuarios");

            CargarUsuarios();
        }
        

            private void CargarUsuarios()
        {
            try
            {
                var usuarios = _usuariosCollection
                    .Find(u => u.RolUsuario != "Administrador")
                    .ToList();

                comboBoxUsuarios.DisplayMember = "NombreUsuario";
                comboBoxUsuarios.ValueMember = "_id";
                comboBoxUsuarios.DataSource = usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarServicios()
        {
            // Aquí puedes cargar los servicios disponibles en el comboBox2
            // Por ejemplo, podrías tener una lista fija o cargar desde la base de datos
            var servicios = new List<string>
            {
                "Consulta General",
                "Vacunación",
                "Desparasitación",
                "Corte de Uñas",
                "Baño y Aseo"
            };
            comboBox2.DataSource = servicios;
        }
        
        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedValue == null ||
                string.IsNullOrEmpty(textBox2.Text.Trim()) ||
                string.IsNullOrEmpty(comboBox2.Text.Trim()))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Citas nuevaCita = new Citas
                {
                    UsuarioDocumento = comboBoxUsuarios.SelectedValue.ToString(),
                    MascotaNombre = textBox2.Text.Trim(),
                    FechaCita = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    HoraCita = dateTimePicker1.Value.ToString("hh:mm tt"),
                    ServicioCita = comboBox2.SelectedItem.ToString(),                    
                    NotasCita = txtNotas.Text.Trim(),
                    FechaCreacion = DateTime.Now
                };

                _citasCollection.InsertOne(nuevaCita);

                MessageBox.Show("✅ Cita registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                textBox2.Clear();
                comboBox2.SelectedIndex = 0;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker1.Value = DateTime.Now;
                comboBox2.SelectedIndex = 0;
                txtNotas.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la cita: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }

    }


