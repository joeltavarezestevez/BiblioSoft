using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiblioSoft
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        string sql = "SELECT Libros.Libro_Codigo_Entrada AS Código, Libros.Libro_Titulo AS Titulo, "
        + " Libros.Libro_Ubicacion AS Ubicación, Libros.Libro_Estado AS Estado, Autores.Autor_Nombre AS Autor,"
        + " Editoras.Editora_Nombre AS Editora, Libros.Libro_Fecha_Compra AS "
        + " [Fecha de Compra], Libros.Libro_Fecha_Registro AS [Fecha Registro] FROM Libros INNER JOIN Autores ON Libros.Autor_Id = Autores.Id "
        + "INNER JOIN Editoras ON Libros.Editora_Id = Editoras.Id";

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

        private void frmInicio_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
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
                frm.codigoLibro = dgvLibros[0, dgvLibros.SelectedCells[0].RowIndex].Value.ToString();
                frm.Show();
            }
        }
    }
}
