using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_de_Inventario.Formularios
{
    public partial class frmPrestamosDevoluciones : Form
    {
        // Creamos la tabla virtual en la memoria de la computadora
        DataTable tablaPrestamos = new DataTable();

        public frmPrestamosDevoluciones()
        {
            InitializeComponent();
        }

        private void frmPrestamosDevoluciones_Load(object sender, EventArgs e)
        {
            // Cargamos los datos reales desde la base de datos
            CargarDatosDesdeBD();

            // Sincroniza el control con la hora real de la computadora al iniciar
            dtpHora.Value = DateTime.Now;
        }

        // 🟢 NUEVO: Método para traer el historial de préstamos desde SQL Server
        private void CargarDatosDesdeBD()
        {
            try
            {
                // Obtenemos la conexión de tu App.config
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

                // Consulta usando alias (AS) para que coincida exactamente con tus nombres de columnas actuales
                string query = "SELECT id, codigo_equipo AS [Código Equipo], docente_alumno AS [Solicitante], tipo_operacion AS [Tipo Operación], estado AS [Estado], fecha AS [Fecha], CONVERT(VARCHAR(8), hora, 108) AS [Hora] FROM Prestamos_y_Devoluciones";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                        tablaPrestamos.Clear(); // Limpiamos la tabla en memoria
                        adaptador.Fill(tablaPrestamos); // Llenamos la tabla en memoria con los datos de SQL Server

                        dgvPrestamos.DataSource = tablaPrestamos; // Mostramos en el DataGridView

                        // Ocultamos la columna 'id' para no mostrarla al usuario, pero conservarla para control interno
                        if (dgvPrestamos.Columns["id"] != null)
                        {
                            dgvPrestamos.Columns["id"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de préstamos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            // Validamos que no dejen campos vacíos
            if (string.IsNullOrWhiteSpace(txtCodigoEquipo.Text) || string.IsNullOrWhiteSpace(txtSolicitante.Text) || string.IsNullOrWhiteSpace(cboOperacion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos para registrar el movimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Guardamos el registro de forma permanente en la base de datos SQL Server
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;
                string query = "INSERT INTO Prestamos_y_Devoluciones (codigo_equipo, docente_alumno, tipo_operacion, estado, fecha, hora) VALUES (@cod, @solicitante, @operacion, @estado, @fecha, @hora)";


                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // CORREGIDO: Los nombres de los parámetros ahora coinciden exactamente con el query string
                        comando.Parameters.AddWithValue("@cod", txtCodigoEquipo.Text.Trim());
                        comando.Parameters.AddWithValue("@solicitante", txtSolicitante.Text.Trim());
                        comando.Parameters.AddWithValue("@operacion", cboOperacion.Text);
                        comando.Parameters.AddWithValue("@estado", textEstado.Text.Trim());

                        // Mandamos la fecha y hora directamente como objetos
                        comando.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                        comando.Parameters.AddWithValue("@hora", dtpHora.Value.TimeOfDay);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Movimiento registrado con éxito en la Base de Datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 2. Volvemos a leer de la BD para refrescar la lista y la tabla de búsquedas
                CargarDatosDesdeBD();

                // 3. Limpiamos los campos
                btnLimpiarMovimiento_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el movimiento en la Base de Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarMovimiento_Click(object sender, EventArgs e)
        {
            // Limpia las cajas de texto y restablece los combos
            txtCodigoEquipo.Clear();
            txtSolicitante.Clear();

            if (cboOperacion.Items.Count > 0)
                cboOperacion.SelectedIndex = -1; // Deselecciona el combo

            dtpFecha.Value = DateTime.Now; // Regresa la fecha a la de hoy
            txtCodigoEquipo.Focus(); // Pone el cursor al inicio
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            // 1. Validamos que el usuario haya escrito algo para buscar
            if (string.IsNullOrWhiteSpace(txtBuscarSolicitante.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del Solicitante a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarSolicitante.Focus();
                return;
            }

            string nombreABuscar = txtBuscarSolicitante.Text.Trim();
            bool encontrado = false;

            // Recorremos tablaPrestamos (que ahora tiene cargados los registros oficiales de SQL Server)
            for (int i = 0; i < tablaPrestamos.Rows.Count; i++)
            {
                DataRow fila = tablaPrestamos.Rows[i];

                // Comparamos el nombre en la columna "Solicitante"
                if (fila["Solicitante"].ToString().Contains(nombreABuscar))
                {
                    // A) Rellenamos las cajas de la izquierda
                    txtCodigoEquipo.Text = fila["Código Equipo"].ToString();
                    txtSolicitante.Text = fila["Solicitante"].ToString();
                    cboOperacion.Text = fila["Tipo Operación"].ToString();
                    dtpFecha.Text = fila["Fecha"].ToString();

                    // B) ¡MAGIA VISUAL!: Seleccionamos y enfocamos la fila en la pantalla
                    dgvPrestamos.ClearSelection();
                    dgvPrestamos.Rows[i].Selected = true;
                    dgvPrestamos.FirstDisplayedScrollingRowIndex = i;
                    //  Código corregido: apunta a la primera columna visible (índice 1)
                    dgvPrestamos.CurrentCell = dgvPrestamos.Rows[i].Cells[1];

                    MessageBox.Show("¡Historial de movimiento encontrado y seleccionado en la tabla!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    encontrado = true;
                    break; // Salimos del bucle
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontraron registros de préstamos para: " + nombreABuscar, "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            // 1. Validamos usando dgvPrestamos
            if (dgvPrestamos == null || dgvPrestamos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos de préstamos para poder exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivos de Excel (*.csv)|*.csv";
            guardarArchivo.Title = "Guardar Reporte de Préstamos";
            guardarArchivo.FileName = "Reporte_Prestamos_y_Devoluciones.csv";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter escritor = new System.IO.StreamWriter(guardarArchivo.FileName, false, System.Text.Encoding.UTF8))
                    {
                        escritor.WriteLine("sep=;");

                        // 2. Obtener encabezados
                        string[] nombresColumnas = new string[dgvPrestamos.Columns.Count];
                        for (int i = 0; i < dgvPrestamos.Columns.Count; i++)
                        {
                            nombresColumnas[i] = dgvPrestamos.Columns[i].HeaderText;
                        }
                        escritor.WriteLine(string.Join(";", nombresColumnas));

                        // 3. Recorrer las filas guardadas en dgvPrestamos
                        foreach (DataGridViewRow fila in dgvPrestamos.Rows)
                        {
                            if (fila.IsNewRow) continue;

                            string[] celdas = new string[dgvPrestamos.Columns.Count];
                            for (int i = 0; i < dgvPrestamos.Columns.Count; i++)
                            {
                                celdas[i] = fila.Cells[i].Value != null ? fila.Cells[i].Value.ToString().Replace("\r", "").Replace("\n", "") : "";
                            }
                            escritor.WriteLine(string.Join(";", celdas));
                        }
                    }
                    MessageBox.Show("¡El reporte de préstamos se exportó correctamente en columnas!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpHora.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtSolicitante_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoEquipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}