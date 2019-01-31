using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulación_de_Datos
{
    public partial class frmLIBROS : Form
    {
        private Conexión_y_Manipulación_de_BD manipulación = new Conexión_y_Manipulación_de_BD();
        public frmLIBROS()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            DgvProductos.DataSource = manipulación.listarlibros();

            DgvProductos.DataMember = "LIBROS";// creaion de la clase libros 

            DgvProductos.Columns[0].HeaderText = "ID del libro";
            DgvProductos.Columns[1].HeaderText = "Nombre del libro";
            DgvProductos.Columns[2].HeaderText = "Año";
            DgvProductos.Columns[3].HeaderText = "Autor";
        }
        private void BtnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LlenarGrid();
           
        }
        //se cran metodos de limpiar, liminar, actualizar, buscar, alrtas.
        private void LimpiarCampos()
        {
            TxtIdProducto.Text = "";
            TxtNomProducto.Text = "";
            TxtMarca.Text = "";
            TxtCosto.Text = "";
        }
        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtIdProducto.Text = DgvProductos.Rows[DgvProductos.CurrentRow.Index].Cells["ID_LIBRO"].Value.ToString();
            TxtNomProducto.Text = DgvProductos.Rows[DgvProductos.CurrentRow.Index].Cells["NOMLIBRO"].Value.ToString();
            TxtMarca.Text = DgvProductos.Rows[DgvProductos.CurrentRow.Index].Cells["AÑO"].Value.ToString();
            TxtCosto.Text = DgvProductos.Rows[DgvProductos.CurrentRow.Index].Cells["AUTOR"].Value.ToString();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if ((TxtNomProducto.Text != "") && (TxtMarca.Text != "") && (TxtCosto.Text
              != ""))
            {
                try
                {
                    bool ProductoInsertado = manipulación.InsertarProducto(TxtNomProducto.Text, TxtMarca.Text, TxtCosto.Text);
                    LlenarGrid();

                    MessageBox.Show("El nuevo producto se ha agregado exitosamente.", "Producto insertado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Faltan datos del Producto que desea Insertar.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if ((TxtNomProducto.Text != "") && (TxtMarca.Text != "") && (TxtCosto.Text
                != ""))
            {
                try
                {
                    bool ProductoActualizado = manipulación.ActualizarProducto(TxtIdProducto.Text, TxtNomProducto.Text, TxtMarca.Text, TxtCosto.Text);
                    MessageBox.Show("Los datos del Producto se han actualizado correctamente.", "Actualizando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Puede que no haya seleccionado ningun Producto o que falten datos por proporcionar.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if ((TxtNomProducto.Text != "") && (TxtMarca.Text != "") && (TxtCosto.Text
                          != ""))
            {
                try
                {
                    bool ProductoEliminado = manipulación.EliminarProducto(TxtIdProducto.Text);
                    LlenarGrid();
                    MessageBox.Show("El Producto se ha eliminado exitosamente.", "Cliente eliminado...", MessageBoxButtons.OK, MessageBoxIcon.Information
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
                MessageBox.Show("Primero debe seleccionar el Producto que desea eliminar dando clic sobre él.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtNomProducto.Text != "")
            {
                DgvProductos.DataSource = manipulación.BuscarPorNombrePro(TxtNomProducto.Text);
                DgvProductos.DataMember = "PRODUCTOS";

                DgvProductos.Columns[0].HeaderText = "ID de los Productos";
                DgvProductos.Columns[1].HeaderText = "Nombre de los Productos";
                DgvProductos.Columns[2].HeaderText = "Marca";
            }
            else
            {
                MessageBox.Show("Debe proporcionar el nombre del Producto que desea buscar.", "Faltan datos...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TxtNomProducto.Focus();
            }
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
