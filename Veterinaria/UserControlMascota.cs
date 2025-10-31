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
    public partial class UserControlMascota : UserControl
    {
        private readonly Usuarios _usuarioLogueado;
        private readonly IMongoCollection<Mascota> _mascotaCollection;

        // Evento que se dispara cuando una mascota se registra correctamente
        public event EventHandler MascotaRegistrada;

        public UserControlMascota()
        {
            InitializeComponent();

            // Mantener constructor por defecto para el diseñador
            var db = ConexionMongo.ObtenerConexion();
            if (db != null)
            {
                _mascotaCollection = db.GetCollection<Mascota>("Mascota");
            }
        }

        // Nuevo constructor que recibe el usuario logueado
        public UserControlMascota(Usuarios usuario) : this()
        {
            _usuarioLogueado = usuario;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_registar_mascota_Click(object sender, EventArgs e)
        {
            if (_mascotaCollection == null)
            {
                MessageBox.Show("No hay conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_usuarioLogueado == null)
            {
                MessageBox.Show("No se encontró el usuario logueado. Inicie sesión de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txt_nombre_mascota.Text.Trim();
            string especie = comboBoxespecie.Text.Trim();
            string raza = textBox3.Text.Trim();
            string edadText = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(especie) || string.IsNullOrEmpty(raza) || string.IsNullOrEmpty(edadText))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(edadText, out int edad))
            {
                MessageBox.Show("Edad inválida. Ingrese un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Mascota nueva = new Mascota
                {
                    NumeroDocumentoDueño = _usuarioLogueado.NumeroDocumento,
                    NombreMascota = nombre,
                    Especie = especie,
                    Raza = raza,
                    Edad = edad,
                    Sexo = null,
                    Peso = 0
                };

                _mascotaCollection.InsertOne(nueva);

                MessageBox.Show("Mascota registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                txt_nombre_mascota.Clear();
                comboBoxespecie.SelectedIndex = -1;
                textBox3.Clear();
                textBox4.Clear();

                // Disparar evento para que el formulario padre oculte el panel
                MascotaRegistrada?.Invoke(this, EventArgs.Empty);

                // Opcional: eliminar control
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la mascota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
