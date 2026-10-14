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

namespace Proyecto_de_Inventario.Formularios
{
    public partial class frmGestionUsuarios : Form
    {
        // Esta tabla almacenará en memoria los registros reales de SQL Server
        public static DataTable tablaUsuarios = new DataTable();

        // 🟢 NUEVO: Guardará el ID único del usuario seleccionado para Actualizar o Eliminar en la BD
        private int idUsuarioSeleccionado = -1;

        public frmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void frmGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatosDesdeBD();
        }

        // 🟢 NUEVO: Método para traer la lista de usuarios desde la base de datos
        private void CargarDatosDesdeBD()
        {
            try
            {
                // Conectamos mediante tu App.config
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

                // Mapeamos los campos usando alias (AS) para no romper tus controles y columnas existentes
                string consulta = "SELECT id, Usuario, Contrasena AS [Contraseña], Nombre_Completo AS [Nombre Completo], Rol FROM Usuarios";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                        tablaUsuarios.Clear(); // Limpiamos la tabla en memoria
                        adaptador.Fill(tablaUsuarios); // Llenamos con los registros de la BD

                        dgvUsuarios.DataSource = tablaUsuarios; // Enlazamos al control visual

                        // Ocultamos el ID para control interno
                        if (dgvUsuarios.Columns["id"] != null)
                        {
                            dgvUsuarios.Columns["id"].Visible = false;
                        }
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
            // 1. Validamos campos obligatorios
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                string.IsNullOrWhiteSpace(cboRol.Text))
            {
                MessageBox.Show("Por favor, llene los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Insertamos el usuario permanentemente en SQL Server
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;
                string consulta = "INSERT INTO Usuarios (Usuario, Contrasena, Nombre_Completo, Rol) VALUES (@user, @pass, @nombre, @rol)";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@user", txtUsuario.Text.Trim());
                        comando.Parameters.AddWithValue("@pass", txtContrasena.Text.Trim());
                        comando.Parameters.AddWithValue("@nombre", txtNombreCompleto.Text.Trim());
                        comando.Parameters.AddWithValue("@rol", cboRol.Text);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Usuario registrado con éxito en la Base de Datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Recargamos la tabla de inmediato
                CargarDatosDesdeBD();
                LimpiarCajas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar en la Base de Datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCajas()
        {
            idUsuarioSeleccionado = -1; // Resetear el ID seleccionado
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtNombreCompleto.Clear();
            cboRol.SelectedIndex = -1;
            txtUsuario.Focus();
        }

        private void btnExportarExcel_Click_1(object sender, EventArgs e)
        {
            if (dgvUsuarios == null || dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivos de Excel (*.csv)|*.csv";
            guardarArchivo.FileName = "Reporte_Usuarios.csv";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter escritor = new System.IO.StreamWriter(guardarArchivo.FileName, false, System.Text.Encoding.UTF8))
                    {
                        escritor.WriteLine("sep=;");
                        string[] columnas = new string[dgvUsuarios.Columns.Count];
                        for (int i = 0; i < dgvUsuarios.Columns.Count; i++) columnas[i] = dgvUsuarios.Columns[i].HeaderText;
                        escritor.WriteLine(string.Join(";", columnas));

                        foreach (DataGridViewRow fila in dgvUsuarios.Rows)
                        {
                            if (fila.IsNewRow) continue;
                            string[] celdas = new string[dgvUsuarios.Columns.Count];
                            for (int i = 0; i < dgvUsuarios.Columns.Count; i++)
                            {
                                celdas[i] = fila.Cells[i].Value != null ? fila.Cells[i].Value.ToString().Replace("\r", "").Replace("\n", "") : "";
                            }
                            escritor.WriteLine(string.Join(";", celdas));
                        }
                    }
                    MessageBox.Show("¡Reporte guardado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
            {
                dgvUsuarios.DataSource = tablaUsuarios;
                return;
            }

            // Filtrado rápido en memoria usando DataView sobre la tabla sincronizada
            DataView dv = new DataView(tablaUsuarios);
            dv.RowFilter = string.Format("Usuario LIKE '%{0}%'", txtBuscarUsuario.Text.Trim());

            dgvUsuarios.DataSource = dv;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista haciendo clic en el selector izquierdo de la fila.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el usuario seleccionado de la Base de Datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    // Eliminamos físicamente de SQL Server usando el ID guardado al hacer clic
                    string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;
                    string consulta = "DELETE FROM Usuarios WHERE id = @id";

                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@id", idUsuarioSeleccionado);

                            conexion.Open();
                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("¡Usuario eliminado correctamente de la Base de Datos!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarDatosDesdeBD();
                    LimpiarCajas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvUsuarios.SelectedRows[0];

                // Guardamos el ID del usuario seleccionado para actualizar o eliminar en SQL Server
                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);

                txtUsuario.Text = fila.Cells["Usuario"].Value?.ToString();
                txtContrasena.Text = fila.Cells["Contraseña"].Value?.ToString();
                txtNombreCompleto.Text = fila.Cells["Nombre Completo"].Value?.ToString();
                cboRol.Text = fila.Cells["Rol"].Value?.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == -1)
            {
                MessageBox.Show("Seleccione primero un usuario de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Actualizamos físicamente en la Base de Datos
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;
                string consulta = "UPDATE Usuarios SET Usuario = @user, Contrasena = @pass, Nombre_Completo = @nombre, Rol = @rol WHERE id = @id";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", idUsuarioSeleccionado);
                        comando.Parameters.AddWithValue("@user", txtUsuario.Text.Trim());
                        comando.Parameters.AddWithValue("@pass", txtContrasena.Text.Trim());
                        comando.Parameters.AddWithValue("@nombre", txtNombreCompleto.Text.Trim());
                        comando.Parameters.AddWithValue("@rol", cboRol.Text);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("¡Usuario actualizado con éxito en la Base de Datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatosDesdeBD();
                LimpiarCajas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}