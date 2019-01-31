using System;
using System.Data;
using System.Data.SqlClient;

namespace Manipulación_de_Datos
{
    class Conexión_y_Manipulación_de_BD
    {
        private SqlConnection ConexionConBD;
        private SqlDataAdapter adaptador;
        private string Consulta = "";
        private bool accesoAbase = false;

        private bool AbrirConexion()
        {
            bool abierto = false;

            //para crear la  conexion con la base de datos
            string strConexion = "Data Source=V-PC\\SQLEXPRESS;" + "Initial Catalog=SAEC;Integrated Security=true";
            try
            {
                ConexionConBD = new SqlConnection(strConexion);

                abierto = true;

                ConexionConBD.Open();
            }
            catch (Exception ex)
            {
            }
            return abierto;
        }
        public bool CerrarConexion()
        {
            bool cerrado = false;

            if (ConexionConBD != null)
            {
                try
                {
                    ConexionConBD.Close();
                    cerrado = true;
                }
                catch (Exception ex)
                {
                }
            }
            return cerrado;
        }
        public DataSet listaralumnos()
        {
            accesoAbase = false;

            DataSet Clientes = new DataSet();

            Consulta = "SELECT * FROM ALUMNOS";

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(Clientes, "ALUMNOS");
            }
            return Clientes;
        }
        public DataSet BuscarPorNombre(string nombre)
        {
            accesoAbase = false;
            DataSet Nombres = new DataSet();
            Consulta = "SELECT * FROM ALUMNO WHERE NOMALUMNO = '" + nombre + "'";

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(Nombres, "ALUMNOS");
            }
            return Nombres;
        }

        public bool InsertarCliente(string NOMBRE, string MATRICULA, string GRADO, string GRUPO)
        {
            accesoAbase = false;
            bool insertado = false;

            DataSet insertar = new DataSet();

            Consulta = "INSERT INTO ALUMNOS VALUES ('" + NOMBRE + "','" + MATRICULA + "','" + GRADO + "','" + GRUPO + "')";

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(insertar, "ALUMNOS");

                insertado = true;
            }
            return insertado;
        }

        public bool ActualizarAlumnos(string id, string NOMBRE, string MATRICULA, string GRADO, string GRUPO)
        {
            accesoAbase = false;
            bool actualizado = false;

            DataSet actualizar = new DataSet();

            Consulta = "UPDATE ALUMNOS SET NOMALUMNOS = '" + NOMBRE + "', MATRICULA = '" + MATRICULA + "', GRADO = '" + GRADO + "', GRUPO = '" + GRUPO + "' WHERE ID_ALUMNO = " + id;

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);
                adaptador.Fill(actualizar, "ALUMNOS");

                actualizado = true;
            }
            return actualizado;
        }

        public bool EliminarCliente(string id)
        {
            accesoAbase = false;
            bool eliminado = false;
            DataSet eliminar = new DataSet();

            Consulta = "DELETE FROM ALUMNOS WHERE ID_ALUMNO =" + id;

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(eliminar, "ALUMNOS");

                eliminado = true;
            }
            return eliminado;
        }
        public DataSet ListarRegistros()
        {
            accesoAbase = false;
            DataSet Ventas = new DataSet();

            Consulta = "SELECT * FROM REGISTROS";
            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);
                adaptador.Fill(Ventas, "REGISTROS");
            }
            return Ventas;
        }
        public DataSet BuscarClientesPorId(string id)
        {
            accesoAbase = false;
            DataSet Cliente = new DataSet();

            Consulta = "SELECT NOMALUMNOS, MATRICULA, GRADO, GRUPO FROM ALUMNOS WHERE ID_ALUMNO =" + id;
            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);
                adaptador.Fill(Cliente, "ALUMNOS");
            }
            return Cliente;
        }
        public DataSet BuscarProductoPorId(string id)
        {
            accesoAbase = false;
            DataSet Producto = new DataSet();

            Consulta = "SELECT NOMLIBRO, AÑO, AUTOR FROM PRODUCTOS WHERE ID_LIBRO =" + id;
            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);
                adaptador.Fill(Producto, "LIBROS");
            }
            return Producto;
        }
        public DataSet BuscarVentaProductoPorIdCliente(string idCliente)
        {
            accesoAbase = false;
            DataSet Venta = new DataSet();
            Consulta = "SELECT PRODUCTOS.NOMPRODUCTO, PRODUCTOS.MARCA, PRODUCTOS.COSTO, VENTAS.CANTIDAD " 
                + "FROM VENTAS INNER JOIN PRODUCTOS ON VENTAS.IDPRODUCTO = PRODUCTOS.IDPRODUCTO" 
                + " WHERE VENTAS.IDCLIENTE =" + idCliente;
            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);
                adaptador.Fill(Venta, "REGISTROS");
            }
            
            return Venta;
        }
        public bool EliminarProducto(string id)
        {
            accesoAbase = false;
            bool eliminado = false;
            DataSet eliminar = new DataSet();

            Consulta = "DELETE FROM LIBROS WHERE ID_LIRBO =" + id;

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(eliminar, "LIBROS");

                eliminado = true;
            }
            return eliminado;
        }
        public bool ActualizarProducto(string id, string NOMLIBRO, string AÑO, string AUTOR)
        {
            accesoAbase = false;
            bool actualizado = false;

            DataSet actualizar = new DataSet();

            //LS COMILLAS SIMPLES INDICAN EL VARCHAR
            Consulta = "UPDATE LIBROS SET NOM_LIBRO = '" + NOMLIBRO + "', AÑO= '" + AÑO + "', AUTOR = " + AUTOR + " WHERE ID_LIBRO = " + id;

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);
                adaptador.Fill(actualizar, "LIBROS");

                actualizado = true;
            }
            return actualizado;
        }
        public bool InsertarProducto(string NOMBRE, string AÑO, string AUTOR)
        {
            accesoAbase = false;
            bool insertado = false;

            DataSet insertar = new DataSet();

            Consulta = "INSERT INTO LIRBOS VALUES ('" + NOMBRE + "','" + AÑO + "','" + AUTOR + "')";

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(insertar, "LIBROS");

                insertado = true;
            }
            return insertado;
        }
        public bool RegistrarUsuarios(string usuario, string contraseña, string frase, string nivel)
        {
            accesoAbase = false;
            bool insertado = false;

            DataSet insertar = new DataSet();

            Consulta = "INSERT INTO USUARIOS VALUES ('" + usuario + "','" + contraseña + "','" + frase + "','" + nivel + "')";

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(insertar, "USUARIOS");

                insertado = true;
            }
            return insertado;
        }
        public DataSet listarlibros()
        {
            accesoAbase = false;

            DataSet Clientes = new DataSet();

            Consulta = "SELECT * FROM LIBROS";

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(Clientes, "LIBROS");
            }
            return Clientes;
        }
        public DataSet BuscarPorNombrePro(string nombre)
        {
            accesoAbase = false;
            DataSet Nombres = new DataSet();
            Consulta = "SELECT * FROM LIBROS WHERE NOM_LIBRO = '" + nombre + "'";

            accesoAbase = AbrirConexion();

            if (accesoAbase)
            {
                adaptador = new SqlDataAdapter(Consulta, ConexionConBD);

                adaptador.Fill(Nombres, "LIBROS");
            }
            return Nombres;
        }
 
    }
}


