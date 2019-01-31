using System;
using System.Windows.Forms;
using Login;

namespace Manipulación_de_Datos
{
    public partial class frmMenú : Form
    {
        Conexión_y_Manipulación_de_BD closes = new Conexión_y_Manipulación_de_BD();
        public frmMenú()
        {
            InitializeComponent();
            if (Datos.Ac == "")
            {
                clientesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem.Enabled = false;
                archivoToolStripMenuItem.Enabled = false;
                productosToolStripMenuItem.Enabled = false;
            }
            if (Datos.Ac == "Administrador")
            {
            }
            if (Datos.Ac == "Invitado")
            {
                clientesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem.Enabled = false;
                clientesToolStripMenuItem.Visible = false;
                ventasToolStripMenuItem.Visible = false;
            }
        }
        //creacion de metodos del menu principal

        private void listadoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenú menú = new frmMenú();
            frmREGISTROS ventas = new frmREGISTROS();
            menú.Close();
            ventas.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historialDeVentasPorCliienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenú menú = new frmMenú();
            frmLISTAREGISTROPORALUMNO clientes = new frmLISTAREGISTROPORALUMNO();
            menú.Close();
            clientes.Show();
        }
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Login cerrarSesion = new Login();
                cerrarSesion.Show();
                this.Hide();
                this.Close();
            }
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenú menú = new frmMenú();
            Form1 clientes = new Form1();
            menú.Close();
            clientes.Show();
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenú menú = new frmMenú();
            frmLIBROS producto = new frmLIBROS();
            menú.Close();
            producto.Show();
        }

        private void frmMenú_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Datos.bienvenido.ToString();
        }
    }
}
