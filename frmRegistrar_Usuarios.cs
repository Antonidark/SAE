using System;
using System.Windows.Forms;

namespace Manipulación_de_Datos
{
    public partial class frmRegistrar_Usuarios : Form
    {
        private Conexión_y_Manipulación_de_BD manipulación = new Conexión_y_Manipulación_de_BD();
        public frmRegistrar_Usuarios()
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
    }
}
