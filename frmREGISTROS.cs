using System;
using System.Data;
using System.Windows.Forms;

namespace Manipulación_de_Datos
{
    public partial class frmREGISTROS : Form
    {
        private Conexión_y_Manipulación_de_BD manipulación = new Conexión_y_Manipulación_de_BD();
        public frmREGISTROS()
        {
            InitializeComponent();
        }
        private void LlenarGrid()
        {
            DgvVentas.DataSource = manipulación.ListarRegistros();

            DgvVentas.DataMember = "REGISTROS";

            DgvVentas.Columns[0].HeaderText = "No. DE REGISTRO";
            DgvVentas.Columns[1].HeaderText = "ID_LIBRO";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void DgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet dsCliente = new DataSet();

            DataSet dsProducto = new DataSet();
          

            string idCliente = DgvVentas.Rows[DgvVentas.CurrentRow.Index].Cells["ID_ALUMNO"].Value.ToString();
            string idProducto = DgvVentas.Rows[DgvVentas.CurrentRow.Index].Cells["ID_LIBRO"].Value.ToString();
            

            try
            {
                dsCliente = manipulación.BuscarClientesPorId(idCliente);
                dsProducto = manipulación.BuscarProductoPorId(idProducto);

                txtNomCliente.Text = dsCliente.Tables[0].Rows[0]["NOMALUMNO"].ToString();
                txtApPatCliente.Text = dsCliente.Tables[0].Rows[0]["MATRICULA"].ToString();
                txtApMatCliente.Text = dsCliente.Tables[0].Rows[0]["GRADO"].ToString();

                txtNomProducto.Text = dsProducto.Tables[0].Rows[0]["NOMLIBRO"].ToString();
                txtMarcaProducto.Text = dsProducto.Tables[0].Rows[0]["AÑO"].ToString();
                txtCostoProducto.Text = dsProducto.Tables[0].Rows[0]["AUTOR"].ToString();


            }
            catch (Exception er)
            {
                MessageBox.Show("No se encontró ningún cliente y/o producto con los ID proporcionados.", "Error de búsqueda...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
