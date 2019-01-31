using System;
using System.Windows.Forms;

namespace Manipulación_de_Datos
{
    public partial class Form1 : Form
    {
        private Conexión_y_Manipulación_de_BD manipulación = new Conexión_y_Manipulación_de_BD();
        public Form1()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            DgvClientes.DataSource = manipulación.listaralumnos();

            DgvClientes.DataMember = "ALUMNOS"; //creacion de la clase alumnos y sus respectivos atributos

            DgvClientes.Columns[0].HeaderText = "ID del ALUMNO";
            DgvClientes.Columns[1].HeaderText = "NOMBRE";
            DgvClientes.Columns[2].HeaderText = "MATRICULA";
            DgvClientes.Columns[3].HeaderText = "GRADO";
            DgvClientes.Columns[4].HeaderText = "GRUPO";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        private void LimpiarCampos() //se creo el metodo limpiar para dejar la tabla de registros en blanco 
        {
            TxtldCliente.Text = "";
            TxtNombre.Text = "";
            TxtTel.Text = "";
            TxtApPat.Text = "";
            TxtApMat.Text = "";
        }
        
        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtldCliente.Text = DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells["IDCLIENTE"].Value.ToString();
            TxtNombre.Text = DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells["NOMCLIENTE"].Value.ToString();
            TxtApPat.Text = DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells["APPAT"].Value.ToString();
            TxtApMat.Text = DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells["APMAT"].Value.ToString();
            TxtTel.Text = DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells["TEL"].Value.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        //se crearon varios metodos, como agregar, limpiar, actualizar, mandar alertas, eliminar, metodos para dar click a los botones

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if ((TxtNombre.Text != "") && (TxtApPat.Text != "") && (TxtApMat.Text
                != "") && (TxtTel.Text != ""))
            {
                try
                {
                    bool ClienteInsertado = manipulación.InsertarCliente(TxtNombre.Text, TxtApPat.Text, TxtApMat.Text, TxtTel.Text);
                    LlenarGrid();

                    MessageBox.Show("El nuevo cliente se ha agregado exitosamente.", "Cliente insertado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch (Exception er)
                {
                    string mensaje = "Inserción fallida. Ocurrió el siguiente error:" + er.ToString();
                    MessageBox.Show(mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos del CLiente que desea Insertar.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if ((TxtNombre.Text != "") && (TxtApPat.Text != "") && (TxtApMat.Text
                 != "") && (TxtTel.Text != ""))
            {
                try
                {
                    bool ClienteActualizado = manipulación.ActualizarAlumnos(TxtldCliente.Text, TxtNombre.Text, TxtApPat.Text, TxtApMat.Text, TxtTel.Text);
                    MessageBox.Show("Los datos del cliente se han actualizado correctamente.", "Actualizando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                }
                catch (Exception er)
                {
                    string mensaje = "Actualización fallida. Ocurrió el siguiente error:" + er.ToString();
                    MessageBox.Show(mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Puede que no haya seleccionado ningun cliente o que falten datos por proporcionar.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if ((TxtNombre.Text != "") && (TxtApPat.Text != "") && (TxtApMat.Text
                           != "") && (TxtTel.Text != ""))
            {
                try
                {
                    bool ClienteEliminado = manipulación.EliminarCliente(TxtldCliente.Text);
                    LlenarGrid();
                    MessageBox.Show("El cliente se ha eliminado exitosamente.", "Cliente eliminado...", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    LimpiarCampos();
                }
                catch (Exception er)
                {
                    string mensaje = "Eliminación fallida. Ocurrió el siguiente error:" + er.ToString();
                    MessageBox.Show(mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar al cliente que desea aliminar dando clic sobre él.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text != "")
            {
                DgvClientes.DataSource = manipulación.BuscarPorNombre(TxtNombre.Text);
                DgvClientes.DataMember = "ALUMNOS";

                DgvClientes.Columns[0].HeaderText = "No. de alumno";
                DgvClientes.Columns[1].HeaderText = "NOMBRE";
                DgvClientes.Columns[2].HeaderText = "MATRICULA";
                DgvClientes.Columns[3].HeaderText = "GRADO";
                DgvClientes.Columns[4].HeaderText = "GRUPO";
            }
            else
            {
                MessageBox.Show("Debe proporcionar el nombre del cliente que desea buscar.", "Faltan datos...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TxtNombre.Focus();
            }
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void TxtApMat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            frmLIBROS form = new frmLIBROS();
            form.Show();
        }

        private void DgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
                
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            frmREGISTROS form3 = new frmREGISTROS();
            form3.Show();
        }
    }
}
