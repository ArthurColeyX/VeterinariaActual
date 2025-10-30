using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class FrmRecuperarClave : Form
    {
        private readonly QueryUsuario _query;
        private string codigoGenerado = "";

        public FrmRecuperarClave()
        { 
            InitializeComponent();
            _query = new QueryUsuario();
        }

        private void FrmRecuperarClave_Load(object sender, EventArgs e)
        {
            // Deshabilitamos los campos que no se usan al inicio
            txtCodigo.Enabled = false;
            txtNuevaContra.Enabled = false;
            btnValidarCodigo.Enabled = false;
            btnCambiarContra.Enabled = false;
        }

        private void btnEnviarCodigo_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Por favor ingresa tu correo.");
                return;
            }

            var usuario = _query.ObtenerUsuario(correo);

            if (usuario == null)
            {
                MessageBox.Show("No se encontró un usuario con ese correo.");
                return;
            }

            try
            {
                // Generar código aleatorio
                Random rand = new Random();
                codigoGenerado = rand.Next(100000, 999999).ToString();

                // Configura los datos del remitente
                string remitente = "estoesparaia73@gmail.com";
                string clave = "drntyagienfdkgfe"; // de Gmail o Outlook

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(remitente, "Soporte Agenda Médica");
                mail.To.Add(correo);
                mail.Subject = "Código de recuperación de contraseña";
                mail.Body = $"Hola {usuario.NombreUsuario},\n\nTu código de recuperación es: {codigoGenerado}\n\nSi no solicitaste este cambio, ignora este mensaje.";
                mail.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(remitente, clave);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                MessageBox.Show("Se envió un código a tu correo.");

                // Activamos los controles para la siguiente fase
                txtCodigo.Enabled = true;
                btnValidarCodigo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }

        private void btnValidarCodigo_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == codigoGenerado)
            {
                MessageBox.Show("Código validado correctamente.");
                txtNuevaContra.Enabled = true;
                btnCambiarContra.Enabled = true;
            }
            else
            {
                MessageBox.Show("Código incorrecto.");
            }
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string nuevaContra = txtNuevaContra.Text.Trim();

            if (string.IsNullOrEmpty(nuevaContra))
            {
                MessageBox.Show("Ingrese una nueva contraseña.");
                return;
            }

            bool actualizado = _query.ActualizarContraseña(correo, nuevaContra);

            if (actualizado)
            {
                MessageBox.Show("Contraseña actualizada con éxito.");
                Form1 login = new Form1();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la contraseña.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Hide();
        }
    }
}
