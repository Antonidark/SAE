using System;
using System.Windows.Forms;
using Login;

namespace Manipulación_de_Datos
{
    public partial class Login : Form //creacion del login
    {
        public Login()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        Conexión_y_Manipulación_de_BD Closes = new Conexión_y_Manipulación_de_BD();

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = bd.selectstring("SELECT usuario FROM USUARIOS WHERE usuario = '" + TxtUser.Text + "'");
            string contraseña = bd.selectstring("SELECT contraseña FROM USUARIOS WHERE contraseña = '" + TxtPass.Text + "'");

            if (this.TxtUser.TextLength > 0 && this.TxtPass.TextLength > 0)
            {
                if (usuario == TxtUser.Text && contraseña == TxtPass.Text)
                {
                    Datos.Ac = bd.selectstring("SELECT Nivel FROM USUARIOS WHERE usuario = '" + TxtUser.Text + "'");
                    Datos.bienvenido = bd.selectstring("SELECT usuario FROM USUARIOS WHERE usuario = '" + TxtUser.Text + "'");
                    frmMenú menu = new frmMenú();
                    menu.Show();
                    this.Hide();
                    Closes.CerrarConexion();
                } else
                {
                    string mensaje = "El usuario o la contraseña no son correctos";
                    MessageBox.Show(mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Closes.CerrarConexion();
                }
            }
            else
            {
                string mensaje = "No has escrito un usuario o contraseña validos";
                MessageBox.Show(mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Closes.CerrarConexion();
            Application.ExitThread();
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            frmContraseña recuperar = new frmContraseña();
            recuperar.Show();
            this.Hide();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
            string usuario = bd.selectstring("SELECT id_usuario FROM USUARIOS ");
            if (usuario.Length > 0)
                {
                lblregistro.Enabled = false;
                }
                else
                {
                lblregistro.Visible = true;
                lblregistro.Enabled = true;   
            }
        }
        private void lblregistro_Click(object sender, EventArgs e)
        {
            Registrar_Usuario_nuevo registro = new Registrar_Usuario_nuevo();
            this.Hide();
            registro.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = false;
        }

        private void visible_DoubleClick(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
        }
    }
}
