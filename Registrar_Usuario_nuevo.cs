using System;
using System.Windows.Forms;

namespace Manipulación_de_Datos
{
    public partial class Registrar_Usuario_nuevo : Form
    {
        private Conexión_y_Manipulación_de_BD manipulación = new Conexión_y_Manipulación_de_BD();
        public Registrar_Usuario_nuevo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Txtnombre.Text != "") && (TxtPass.Text != "") && (TxtFrase.Text
                       != "") && (CMBPrivilegios.SelectedItem != ""))
            {
                try
                {
                    bool ProductoInsertado = manipulación.RegistrarUsuarios(Txtnombre.Text, TxtPass.Text, TxtFrase.Text, CMBPrivilegios.Text);
                    MessageBox.Show("El nuevo Usuario se ha guardado correcatmente.", "Guardando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login inicio = new Login();
                    inicio.Show();
                    this.Hide();
                }
                catch (Exception er)
                {
                    string mensaje = "Hubo un error al guardar. El error es el siguiente:" + er.ToString();
                    MessageBox.Show(mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por guardar.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Registrar_Usuario_nuevo_Load(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
            TxtFrase.UseSystemPasswordChar = true;
        }

        private void visible_Click(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = false;
        }
        private void visible_DoubleClick(object sender, EventArgs e)
        {
            TxtPass.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TxtFrase.UseSystemPasswordChar = false;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            TxtFrase.UseSystemPasswordChar = true;
        }
    }
}
