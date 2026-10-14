using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Proyecto_de_Inventario.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // 1. Validación de que no dejen los campos en blanco
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Obtenemos la conexión de tu App.config
                string cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;

                // 3. Consulta para buscar coincidencia de Usuario y Contraseña
                string consulta = "SELECT Nombre_Completo, Rol FROM Usuarios WHERE Usuario = @user AND Contrasena = @pass";

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        // Evitamos inyección de código SQL mediante parámetros parametrizados
                        comando.Parameters.AddWithValue("@user", txtUsuario.Text.Trim());
                        comando.Parameters.AddWithValue("@pass", txtContraseña.Text.Trim());

                        conexion.Open();
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            // 4. Si el lector encuentra una coincidencia en la Base de Datos
                            if (lector.Read())
                            {
                                string nombreUsuario = lector["Nombre_Completo"].ToString();
                                string rolUsuario = lector["Rol"].ToString();

                                MessageBox.Show("¡Bienvenido al sistema, " + nombreUsuario + " (" + rolUsuario + ")!",
                                                "Acceso Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Abre el Menú Principal y oculta el Login
                                frmMenuPrincipal menu = new frmMenuPrincipal();
                                menu.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Si las credenciales no coinciden
                                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtContraseña.Clear();
                                txtUsuario.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la Base de Datos: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}