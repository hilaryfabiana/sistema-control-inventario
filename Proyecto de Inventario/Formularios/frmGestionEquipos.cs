using System.Data.SqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_Inventario
{
    public partial class frmGestionEquipos : Form
    {
        
        DataTable tablaMemoria = new DataTable();

        public frmGestionEquipos()
        {
            InitializeComponent();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmGestionEquipos_Load(object sender, EventArgs e)
        {
            CargarDatosDesdeBD();
        }

        
        private void CargarDatosDesdeBD()
        {
            try
            {
                
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

                
                string consulta = "SELECT Codigo AS [Código Patrimonial], Tipo AS [Tipo de Bien], Marca, Modelo, Ubicacion AS [Ubicación], Estado FROM Gestion_de_Equipos";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                        
                        tablaMemoria.Clear();

                        
                        adaptador.Fill(tablaMemoria);

                        
                        dgvEquipos.DataSource = tablaMemoria;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con SQL Server: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ponga el código del equipo.");
                return;
            }

            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;
                string consulta = "INSERT INTO Gestion_de_Equipos (Codigo, Tipo, Marca, Modelo, Ubicacion, Estado) VALUES (@cod, @tipo, @marca, @mod, @ubi, @est)";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        
                        comando.Parameters.AddWithValue("@cod", txtCodigo.Text.Trim());
                        comando.Parameters.AddWithValue("@tipo", cboTipo.Text);
                        comando.Parameters.AddWithValue("@marca", txtMarca.Text.Trim());
                        comando.Parameters.AddWithValue("@mod", txtModelo.Text.Trim());
                        comando.Parameters.AddWithValue("@ubi", cboUbicacion.Text);
                        comando.Parameters.AddWithValue("@est", cboEstado.Text);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Equipo guardado en la Base de Datos!", "Éxito");

                
                CargarDatosDesdeBD();
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Clear();
                txtMarca.Clear();
                txtModelo.Clear();

                
                if (cboTipo.Items.Count > 0) cboTipo.SelectedIndex = 0;
                if (cboUbicacion.Items.Count > 0) cboUbicacion.SelectedIndex = 0;
                if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;

                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar los campos: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Ingrese el Código del equipo que desea actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    return;
                }

                
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;
                string consulta = "UPDATE Gestion_de_Equipos SET Tipo = @tipo, Marca = @marca, Modelo = @mod, Ubicacion = @ubi, Estado = @est WHERE Codigo = @cod";

                bool encontrado = false;

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@cod", txtCodigo.Text.Trim());
                        comando.Parameters.AddWithValue("@tipo", cboTipo.Text);
                        comando.Parameters.AddWithValue("@marca", txtMarca.Text.Trim());
                        comando.Parameters.AddWithValue("@mod", txtModelo.Text.Trim());
                        comando.Parameters.AddWithValue("@ubi", cboUbicacion.Text);
                        comando.Parameters.AddWithValue("@est", cboEstado.Text);

                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            encontrado = true;
                        }
                    }
                }

                if (encontrado)
                {
                    MessageBox.Show("Datos del equipo actualizados correctamente en la Base de Datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    CargarDatosDesdeBD();
                    btnLimpiar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún equipo con ese código en la Base de Datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvEquipos.Rows[e.RowIndex];

                    
                    txtCodigo.Text = fila.Cells["Código Patrimonial"].Value?.ToString();
                    cboTipo.Text = fila.Cells["Tipo de Bien"].Value?.ToString();
                    txtMarca.Text = fila.Cells["Marca"].Value?.ToString();
                    txtModelo.Text = fila.Cells["Modelo"].Value?.ToString();
                    cboUbicacion.Text = fila.Cells["Ubicación"].Value?.ToString();
                    cboEstado.Text = fila.Cells["Estado"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el registro: " + ex.Message, "Error Visual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoABuscar = "";

            if (!string.IsNullOrWhiteSpace(txtBuscarCodigo.Text))
            {
                codigoABuscar = txtBuscarCodigo.Text.Trim();
            }
            else if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                codigoABuscar = txtCodigo.Text.Trim();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Código Patrimonial en la caja de búsqueda rápida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscarCodigo.Focus();
                return;
            }

            bool encontrado = false;

            
            for (int i = 0; i < tablaMemoria.Rows.Count; i++)
            {
                DataRow fila = tablaMemoria.Rows[i];

                if (fila["Código Patrimonial"].ToString().Equals(codigoABuscar, StringComparison.OrdinalIgnoreCase))
                {
                    txtCodigo.Text = fila["Código Patrimonial"].ToString();
                    cboTipo.Text = fila["Tipo de Bien"].ToString();
                    txtMarca.Text = fila["Marca"].ToString();
                    txtModelo.Text = fila["Modelo"].ToString();
                    cboUbicacion.Text = fila["Ubicación"].ToString();
                    cboEstado.Text = fila["Estado"].ToString();

                    
                    dgvEquipos.ClearSelection();
                    dgvEquipos.Rows[i].Selected = true;
                    dgvEquipos.FirstDisplayedScrollingRowIndex = i;
                    dgvEquipos.CurrentCell = dgvEquipos.Rows[i].Cells[0];

                    MessageBox.Show("¡Equipo encontrado y seleccionado en la tabla!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("El Código Patrimonial '" + codigoABuscar + "' no se encuentra registrado.", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataView vistaFiltro = new DataView(tablaMemoria);
                List<string> condiciones = new List<string>();

                if (cboFiltroUbicacion.SelectedIndex > 0 && !string.IsNullOrEmpty(cboFiltroUbicacion.Text))
                {
                    condiciones.Add("Ubicación = '" + cboFiltroUbicacion.Text + "'");
                }

                if (cboFiltroEstado.SelectedIndex > 0 && !string.IsNullOrEmpty(cboFiltroEstado.Text))
                {
                    condiciones.Add("Estado = '" + cboFiltroEstado.Text + "'");
                }

                if (condiciones.Count > 0)
                {
                    vistaFiltro.RowFilter = string.Join(" AND ", condiciones);
                }
                else
                {
                    vistaFiltro.RowFilter = "";
                }

                dgvEquipos.DataSource = vistaFiltro;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el filtro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
           
            if (dgvEquipos == null || dgvEquipos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos en el inventario para poder exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivos de Excel (*.csv)|*.csv";
            guardarArchivo.Title = "Guardar Inventario de Equipos";
            guardarArchivo.FileName = "Inventario_Equipos_IESTP_Argentina.csv";
            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter escritor = new System.IO.StreamWriter(guardarArchivo.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // Línea mágica para Excel
                        escritor.WriteLine("sep=;");
                        // 3. Escribimos los títulos de las columnas obteniéndolos del DataGridView
                        string[] nombresColumnas = new string[dgvEquipos.Columns.Count];
                        for (int i = 0; i < dgvEquipos.Columns.Count; i++)
                        {
                            nombresColumnas[i] = dgvEquipos.Columns[i].HeaderText;
                        }
                        escritor.WriteLine(string.Join(";", nombresColumnas));
                        // 4. Recorremos fila por fila ÚNICAMENTE las filas visibles en tu DataGridView
                        foreach (DataGridViewRow fila in dgvEquipos.Rows)
                        {
                            if (fila.IsNewRow) continue; // Omitimos la fila en blanco del final si está activa
                            string[] celdas = new string[dgvEquipos.Columns.Count];
                            for (int i = 0; i < dgvEquipos.Columns.Count; i++)
                            {
                                celdas[i] = fila.Cells[i].Value != null ?
                                    fila.Cells[i].Value.ToString().Replace("\r", "").Replace("\n", "") : "";
                            }
                            escritor.WriteLine(string.Join(";", celdas));
                        }
                    }
                    MessageBox.Show("¡El inventario filtrado se exportó correctamente! Ya puedes abrirlo con Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra el formulario de gestión de equipos, regresando al Menú Principal
            this.Close();
        }
    }
}