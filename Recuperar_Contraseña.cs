using System;
using System.Windows.Forms;

namespace Manipulación_de_Datos
{
    public partial class frmContraseña : Form
    {
        public frmContraseña()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        Conexión_y_Manipulación_de_BD Closes = new Conexión_y_Manipulación_de_BD();

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string usuario = bd.selectstring("SELECT usuario FROM USUARIOS WHERE usuario = '" + TxtUser.Text + "'");
            string contraseña = bd.selectstring("SELECT frase FROM USUARIOS WHERE frase = '" + TxtRespuesta.Text + "'");

                if (this.TxtUser.TextLength > 0 && this.TxtRespuesta.TextLength > 0)
                {
                    if (usuario == TxtUser.Text && contraseña == TxtRespuesta.Text)
                    {
                        string recuperada = bd.selectstring("SELECT contraseña FROM USUARIOS");
                        string mensaje = "Frase correcta su contraseña es: " +  recuperada;
                        MessageBox.Show(mensaje, "Hecho" , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Login inicio = new Login();
                        this.Hide();
                        Closes.CerrarConexion();
                        inicio.Show();
                    }
                    else
                    {
                        string mensaje = "El usuario o la frase de seguridad no son correctos";
                        MessageBox.Show(mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Closes.CerrarConexion();
                    }
                }
                else
                {
                    string mensaje = "Introduce el nombre de usuario y la frase de seguridad primero";
                    MessageBox.Show(mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Closes.CerrarConexion();
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
            this.Hide();
        }
    }
}

