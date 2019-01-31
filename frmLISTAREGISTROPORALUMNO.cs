using System;
using System.Windows.Forms;

namespace Manipulación_de_Datos
{
    public partial class frmLISTAREGISTROPORALUMNO : Form
    {
        private Conexión_y_Manipulación_de_BD manipulación = new Conexión_y_Manipulación_de_BD();
        public frmLISTAREGISTROPORALUMNO()
        {
            InitializeComponent();
        }
        private void LlenarGridClientes()
        {
            DgvClientes.DataSource = manipulación.listaralumnos();

            DgvClientes.DataMember = "ALUMNOS"; //creacion de la clase alumnos 

            DgvClientes.Columns[0].HeaderText = "No. DE ALUMNO";
            DgvClientes.Columns[1].HeaderText = "Nombre del alumno";
            DgvClientes.Columns[2].HeaderText = "MATRICULA";
            DgvClientes.Columns[3].HeaderText = "GRADO";
            DgvClientes.Columns[3].HeaderText = "GRUPO";
        }
        private void frmVentasPorCliente_Load(object sender, EventArgs e)
        {
            LlenarGridClientes();
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvVentasProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idCliente = DgvClientes.Rows[DgvClientes.CurrentRow.Index].Cells["ID_ALUMNO"].Value.ToString();

            DgvVentasProductos.DataSource = manipulación.BuscarVentaProductoPorIdCliente(idCliente);
            DgvVentasProductos.DataMember = "REGISTROS";

            DgvVentasProductos.Columns[0].HeaderText = "Nombre del libro";
            DgvVentasProductos.Columns[1].HeaderText = "AÑO";
            DgvVentasProductos.Columns[2].HeaderText = "AUTOR";
           
        }
    }
}
