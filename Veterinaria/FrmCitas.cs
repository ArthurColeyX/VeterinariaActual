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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria
{
    public partial class FrmCitas : Form
    {
 

        // Horario de atención (puedes ajustarlo)
        private readonly TimeSpan _horaInicio = new TimeSpan(6, 0, 0); // 6:00 AM
        private readonly TimeSpan _horaFin = new TimeSpan(18, 0, 0);   // 6:00 PM
        private readonly TimeSpan _intervalo = new TimeSpan(0, 30, 0);  // 30 minuros

        private readonly Usuarios _usuarioActual; // Usuario logueado

        // AGREGAR variable para controlar cita seleccionada
        private string _citaSeleccionadaId = null;

        public FrmCitas(Usuarios usuario)
        {
            try
            {
                InitializeComponent();

                var database = ConexionMongo.ObtenerConexion();

                _usuarioActual = usuario;

                ConfigurarDataGrid();
                

                data_grid_mascotas.SelectionChanged += dgvCitas_SelectionChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el formulario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ConfigurarDataGrid()
        {
            // 🔒 Bloquear edición y redimensión:
            data_grid_mascotas.ReadOnly = true;                        // Solo lectura
            data_grid_mascotas.AllowUserToAddRows = false;             // No permitir agregar filas manualmente
            data_grid_mascotas.AllowUserToDeleteRows = false;          // No permitir eliminar desde el grid
            data_grid_mascotas.AllowUserToResizeRows = false;          // No permitir cambiar el alto de filas
            data_grid_mascotas.AllowUserToResizeColumns = false;       // No permitir cambiar ancho de columnas
            data_grid_mascotas.AllowUserToOrderColumns = false;        // No permitir mover columnas
            data_grid_mascotas.MultiSelect = false;                    // Solo una fila seleccionada
            data_grid_mascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección por fila completa
            data_grid_mascotas.RowHeadersVisible = false;              // Oculta el borde izquierdo de numeración
            data_grid_mascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajuste automático de columnas

            // === Configuración general ===
            data_grid_mascotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid_mascotas.MultiSelect = false;
            data_grid_mascotas.ReadOnly = true;
            data_grid_mascotas.AllowUserToAddRows = false;
            data_grid_mascotas.AllowUserToDeleteRows = false;
            data_grid_mascotas.RowHeadersVisible = false;
            data_grid_mascotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid_mascotas.BorderStyle = BorderStyle.None;
            data_grid_mascotas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            data_grid_mascotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_grid_mascotas.BackgroundColor = Color.White;

            // === Encabezados de columna ===
            data_grid_mascotas.EnableHeadersVisualStyles = false;
            data_grid_mascotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(58, 134, 255); // azul moderno
            data_grid_mascotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            data_grid_mascotas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            data_grid_mascotas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_grid_mascotas.ColumnHeadersHeight = 35;

            // === Filas ===
            data_grid_mascotas.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250); // gris muy claro
            data_grid_mascotas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 240, 255); // tono azulado suave
            data_grid_mascotas.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            data_grid_mascotas.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            data_grid_mascotas.DefaultCellStyle.Padding = new Padding(5, 2, 5, 2);

            // === Efectos al seleccionar ===
            data_grid_mascotas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(58, 134, 255); // mismo azul del encabezado
            data_grid_mascotas.DefaultCellStyle.SelectionForeColor = Color.White;

            // === Ajustes de filas ===
            data_grid_mascotas.RowTemplate.Height = 30;
            data_grid_mascotas.GridColor = Color.FromArgb(220, 225, 230); // líneas sutiles
            data_grid_mascotas.ScrollBars = ScrollBars.Both;

            // === Estilo al pasar el mouse ===
            data_grid_mascotas.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    data_grid_mascotas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(225, 235, 255);
            };

            data_grid_mascotas.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0)
                    data_grid_mascotas.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                        e.RowIndex % 2 == 0 ? Color.FromArgb(245, 247, 250) : Color.FromArgb(235, 240, 255);
            };
        }


        //private void ValidarFinDeSemana(object sender, EventArgs e)
        //{
        //    DateTime fechaSeleccionada = dtpFechaHora.Value;

        //    if (fechaSeleccionada.DayOfWeek == DayOfWeek.Saturday)
        //    {
        //        dtpFechaHora.Value = fechaSeleccionada.AddDays(2); // Lunes
        //        MessageBox.Show("Las citas no están disponibles los sábados. Se ha seleccionado el lunes.",
        //                      "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else if (fechaSeleccionada.DayOfWeek == DayOfWeek.Sunday)
        //    {
        //        dtpFechaHora.Value = fechaSeleccionada.AddDays(1); // Lunes
        //        MessageBox.Show("Las citas no están disponibles los domingos. Se ha seleccionado el lunes.",
        //                      "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void ActualizarEstadoBotones()
        //{
        //    try
        //    {
        //        bool hayCitaSeleccionada = !string.IsNullOrEmpty(_citaSeleccionadaId);
        //        bool hayHorariosDisponibles = cmbHora.Items.Count > 0 && cmbHora.Enabled;

        //        btnEditar.Enabled = hayCitaSeleccionada;
        //        btnCancelar.Enabled = hayCitaSeleccionada;
        //        btnActualizar.Enabled = hayCitaSeleccionada && hayHorariosDisponibles;
        //        btnConfirmar.Enabled = !hayCitaSeleccionada && hayHorariosDisponibles;

        //        // Cambiar colores para mejor feedback visual
        //        btnConfirmar.BackColor = btnConfirmar.Enabled ? Color.MediumSeaGreen : Color.LightGray;
        //        btnCancelar.BackColor = btnCancelar.Enabled ? Color.LightCoral : Color.LightGray;
        //        btnEditar.BackColor = btnEditar.Enabled ? Color.Khaki : Color.LightGray;
        //        btnActualizar.BackColor = btnActualizar.Enabled ? Color.CornflowerBlue : Color.LightGray;
        //    }
        //    catch (Exception ex)
        //    {
        //        // En caso de error, deshabilitar todos los botones
        //        btnEditar.Enabled = false;
        //        btnCancelar.Enabled = false;
        //        btnActualizar.Enabled = false;
        //        btnConfirmar.Enabled = false;
        //    }
        //}

        //public void CargarCitasUsuario(string usuarioId)
        //{
        //    try
        //    {


        //        // VERIFICAR SI LA LISTA ESTÁ VACÍA

        //        {
        //            // Limpiar el DataGridView y mostrar mensaje
        //            dgvCitas.DataSource = null;
        //            dgvCitas.Rows.Clear();

        //            // Agregar una fila indicando que no hay citas
        //            dgvCitas.Columns.Clear();
        //            dgvCitas.Columns.Add("Mensaje", "Información");
        //            dgvCitas.Rows.Add("No tienes citas programadas");

        //            dgvCitas.Columns["Mensaje"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        //            // Limpiar selección
        //            dgvCitas.ClearSelection();
        //            _citaSeleccionadaId = null;
        //            ActualizarEstadoBotones();
        //            return;
        //        }



        //        // Personalizar encabezados SOLO si hay datos
        //        if (dgvCitas.Columns.Count > 0)
        //        {
        //            dgvCitas.Columns["_id"].Visible = false;
        //            dgvCitas.Columns["Motivo"].HeaderText = "Motivo";
        //            dgvCitas.Columns["Fecha"].HeaderText = "Fecha";
        //            dgvCitas.Columns["Hora"].HeaderText = "Hora";
        //            dgvCitas.Columns["Estado"].HeaderText = "Estado";
        //            dgvCitas.Columns["UsuarioId"].Visible = false;
        //            dgvCitas.Columns["CreadoEn"].Visible = false;
        //        }

        //        dgvCitas.ClearSelection();
        //        _citaSeleccionadaId = null;
        //        ActualizarEstadoBotones();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar citas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void DeshabilitarCamposPersonales()
        //{
        //    txtDocumento.Enabled = false;
        //    txtNombre.Enabled = false;
        //    txtApellido.Enabled = false;
        //    txtTelefono.Enabled = false;
        //    txtCorreo.Enabled = false;
        //}

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    // Si selecciona fecha anterior a hoy, corregir automáticamente
        //    if (dtpFechaHora.Value < DateTime.Today)
        //    {
        //        MessageBox.Show("No puede seleccionar fechas pasadas. Se ha seleccionado hoy.",
        //                      "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        dtpFechaHora.Value = DateTime.Today;
        //        return;
        //    }

        //    CargarHorasDisponibles(dtpFechaHora.Value);

        //}

        private void CargarHorasDisponibles(DateTime fecha)
        {
           
        }


        private void FrmCitas_Load(object sender, EventArgs e)
        {

           
            
        }

       

      
     

        private void dgvCitas_MouseClick(object sender, MouseEventArgs e)
        {
            data_grid_mascotas.DefaultCellStyle.SelectionBackColor = Color.MediumPurple; // Fondo al seleccionar
            data_grid_mascotas.DefaultCellStyle.SelectionForeColor = Color.White;        // Texto al seleccionar

        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            if (data_grid_mascotas.Columns.Contains("_id") && data_grid_mascotas.SelectedRows.Count > 0)
            {
                 var fila = data_grid_mascotas.SelectedRows[0];
                _citaSeleccionadaId = fila.Cells["_id"].Value?.ToString();
            }
            else
            {
                _citaSeleccionadaId = null;
            }

           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControlMascota mascotas = new UserControlMascota(_usuarioActual);
            // Suscribir para ocultar el panel cuando la mascota sea registrada
            mascotas.MascotaRegistrada += (s, ev) =>
            {
                // Ejecutar en el hilo de UI
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() => panelRegMascota.Visible = false));
                }
                else
                {
                    panelRegMascota.Visible = false;
                }
            };
            
            panelRegMascota.Controls.Add(mascotas);
            panelRegMascota.Visible = true;
        }
    }
}
