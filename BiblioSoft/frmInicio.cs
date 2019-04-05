using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BiblioSoft
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        string sql = "SELECT Id as ID, Libro_Codigo_Entrada AS Código, Libro_Titulo AS Titulo, "
        + " Libro_Ubicacion AS Ubicación, Libro_Estado AS Estado, Autor_Nombre AS Autor,"
        + " Editora_Nombre AS Editora, Libro_Fecha_Compra AS "
        + " [Fecha de Compra], Libro_Fecha_Registro AS [Fecha Registro] FROM Libros";

        ConexionSQL conexion = new ConexionSQL();

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void llenarDataGridView()
        {
            conexion.consultar(sql, "libros");
            dgvLibros.DataSource = conexion.ds.Tables["libros"];
            dgvLibros.Refresh();
        }

        private int BuscarCantidades(String query)
        {
            int Cantidad = 0;
            try
            {
                //Para extraer los datos del registro seleccionado en la base de datos
                SqlDataReader LectorProductos;

                //Abrimos la conexion hacia la BD
                conexion.conexion.Open();
                //Creamos una instruccion o comando SQL
                SqlCommand Comando = new SqlCommand();
                //Le asignamos la conexion actual
                Comando.Connection = conexion.conexion;
                //Enviamos el parametro o la consulta que se desea realizar en SQL
                Comando.CommandText = query;
                //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
                LectorProductos = Comando.ExecuteReader();
                //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
                if (LectorProductos.Read() == true)
                {
                    //Asignando el valor de cada campo al objeto correspondiente
                    Cantidad = LectorProductos.GetInt32(0);
                }
                //Borramos el lector que almacena el registro, para poder utilizarlo nuevamente
                LectorProductos.Close();

                return Cantidad;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return 0;
            }
            finally
            {
                conexion.conexion.Close();
            }
        }
        
        private void frmInicio_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
            lblLibrosTotal.Text = BuscarCantidades("Select Count(*) From Libros").ToString();
            lblLibrosPrestados.Text = BuscarCantidades("Select Count(*) From Libros where Libro_Estado = 'PRESTADO'").ToString();
            lblLibrosRetirados.Text = BuscarCantidades("Select Count(*) From Libros where Libro_Estado = 'RETIRADO'").ToString();
            lblLibrosDisponibles.Text = BuscarCantidades("Select Count(*) From Libros where Libro_Estado = 'DISPONIBLE'").ToString();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            String textoBusqueda = txtBusqueda.Text.Trim();

            String searchFields = "Código Like '%" + textoBusqueda + "%' OR Titulo Like '%" + textoBusqueda + "%'"
            + "OR Ubicación Like '%" + textoBusqueda + "%' OR Estado Like '%" + textoBusqueda + "%'"
            + "OR Autor Like '%" + textoBusqueda + "%' OR Editora Like '%" + textoBusqueda + "%'";

            (dgvLibros.DataSource as DataTable).DefaultView.RowFilter = string.Format(searchFields);
        }

        private void dgvLibros_DoubleClick(object sender, EventArgs e)
        {
            if (dgvLibros.Rows.Count > 0)
            {
                frmViewLibro frm = new frmViewLibro();
                frm.IdLibro = int.Parse(dgvLibros[0, dgvLibros.SelectedCells[0].RowIndex].Value.ToString());
                frm.Show();
            }
        }
    }
}
