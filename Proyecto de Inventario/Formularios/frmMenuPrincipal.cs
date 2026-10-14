using Proyecto_de_Inventario.Formularios;
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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormularioEnPanel(object formHijo)
        {
            // Limpiamos TODO lo que haya dentro del panel contenedor para evitar acumulaciones
            this.pnlContenedor.Controls.Clear();
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;

            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Abre tu pantalla de equipos dentro del panel central
            AbrirFormularioEnPanel(new frmGestionEquipos());

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Proyecto_de_Inventario.Formularios.frmPrestamosDevoluciones());
        }

        private void btnUsuariosRoles_Click(object sender, EventArgs e)
        {
            // Cargamos la ventana limpia dentro del panel central de tu menú
            AbrirFormularioEnPanel(new Proyecto_de_Inventario.Formularios.frmGestionUsuarios());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }  
    
}
