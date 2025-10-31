using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Veterinaria
{
    public partial class UserControleditar_mascota : UserControl
    {
        private Mascota _mascota;
        private readonly IMongoCollection<Mascota> _mascotaCollection;

        // Evento que notifica que la mascota fue actualizada
        public event EventHandler MascotaActualizada;

        public UserControleditar_mascota()
        {
            InitializeComponent();
            // Asociar evento de cierre del label 'btn_cerar' para ocultar el panel contenedor
            btn_cerar.Click += Btn_cerar_Click;

            var db = ConexionMongo.ObtenerConexion();
            if (db != null)
            {
                _mascotaCollection = db.GetCollection<Mascota>("Mascota");
            }
        }

        // Nuevo constructor que recibe la mascota a editar
        public UserControleditar_mascota(Mascota mascota) : this()
        {
            LoadMascota(mascota);
        }

        // Carga los datos de la mascota en los controles del user control
        public void LoadMascota(Mascota mascota)
        {
            if (mascota == null)
                return;

            _mascota = mascota;

            // Rellenar campos (asegurarse que los nombres coinciden con los del Designer)
            txt_nombre_mascota.Text = mascota.NombreMascota ?? string.Empty;
            // Usar Text para evitar problemas si los items no coinciden exactamente
            comboBoxespecie.Text = mascota.Especie ?? string.Empty;
            textBox3.Text = mascota.Raza ?? string.Empty; // Raza
            textBox4.Text = mascota.Edad.ToString(); // Edad
            txt_peso.Text = mascota.Peso.ToString(); // Peso
            comboBoxsexo.Text = mascota.Sexo ?? string.Empty;
        }

        private void Btn_cerar_Click(object sender, EventArgs e)
        {
            // Intentar ocultar el panel contenedor (panelRegMascota) si existe
            var parent = this.Parent;
            if (parent != null)
            {
                parent.Visible = false;
                parent.Controls.Remove(this);
            }
            else
            {
                this.Visible = false;
            }
        }

        private void btn_registar_mascota_Click(object sender, EventArgs e)
        {
            // Reutilizamos el botón de registrar para realizar la actualización
            if (_mascota == null)
            {
                MessageBox.Show("No hay mascota cargada para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_mascotaCollection == null)
            {
                MessageBox.Show("No hay conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txt_nombre_mascota.Text.Trim();
            string especie = comboBoxespecie.Text.Trim();
            string sexo = comboBoxsexo.Text.Trim();
            string raza = textBox3.Text.Trim();
            string edadText = textBox4.Text.Trim();
            string pesoText = txt_peso.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(especie) || string.IsNullOrEmpty(raza) || string.IsNullOrEmpty(edadText) || string.IsNullOrEmpty(sexo))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(edadText, out int edad))
            {
                MessageBox.Show("Edad inválida. Ingrese un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double peso = 0;
            if (!string.IsNullOrEmpty(pesoText))
            {
                if (!double.TryParse(pesoText, out peso) &&
                    !double.TryParse(pesoText, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out peso))
                {
                    MessageBox.Show("Peso inválido. Ingrese un número (use \".\" o \",\" según su configuración).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                // Actualizar objeto
                _mascota.NombreMascota = nombre;
                _mascota.Especie = especie;
                _mascota.Raza = raza;
                _mascota.Edad = edad;
                _mascota.Sexo = sexo;
                _mascota.Peso = peso;

                // Reemplazar en la colección
                var filter = Builders<Mascota>.Filter.Eq(m => m._id, _mascota._id);
                var result = _mascotaCollection.ReplaceOne(filter, _mascota);

                if (result.IsAcknowledged)
                {
                    MessageBox.Show("Mascota actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Notificar al contenedor para recargar
                    MascotaActualizada?.Invoke(this, EventArgs.Empty);

                    // Cerrar/ocultar el panel contenedor
                    var parent = this.Parent;
                    if (parent != null)
                    {
                        parent.Visible = false;
                        parent.Controls.Remove(this);
                    }
                    else
                    {
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la mascota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la mascota: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
