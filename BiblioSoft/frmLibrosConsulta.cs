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
    public partial class frmLibrosConsulta : Form
    {
        public frmLibrosConsulta()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmLibros l = new frmLibros();
            l.Show();
        }

        string sql = "SELECT Id, Libro_Codigo_Entrada AS Código, Libro_Titulo AS Titulo, "
        + " Libro_Ubicacion AS Ubicación, Libro_Estado AS Estado, Autor_Nombre AS Autor,"
        + " Editora_Nombre AS Editora, Libro_Fecha_Compra AS "
        + " [Fecha de Compra], Libro_Fecha_Registro AS [Fecha Registro] FROM Libros";

        ConexionSQL conexion = new ConexionSQL();

        private void llenarDataGridView()
        {
            conexion.consultar(sql, "libros");
            dgvLibros.DataSource = conexion.ds.Tables["libros"];
            dgvLibros.Refresh();
        }

        private void frmLibrosConsulta_Load(object sender, EventArgs e)
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
            btnVer.PerformClick();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvLibros.Rows.Count > 0)
            {
                frmViewLibro frm = new frmViewLibro();
                frm.IdLibro = int.Parse(dgvLibros[0, dgvLibros.SelectedCells[0].RowIndex].Value.ToString());
                frm.Show();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.Rows.Count > 0)
            {
                frmLibros frm = new frmLibros();
                frm.IdLibro = int.Parse(dgvLibros[0, dgvLibros.SelectedCells[0].RowIndex].Value.ToString());
                frm.Show();
            }
        }

        private void frmLibrosConsulta_Enter(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdLibro = 0;
            IdLibro = int.Parse(dgvLibros[0, dgvLibros.SelectedCells[0].RowIndex].Value.ToString());
            if (IdLibro > 0)
            {
                DialogResult d = MessageBox.Show("Está seguro que desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        conexion.ejecutar("Delete from Libros Where id=" + IdLibro);
                        MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Este libro no puede ser eliminado porque tiene registros dependientes (Prestamos, Devoluciones, etc.) " + error.Message, "Aviso - eliminarRegistro", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    finally
                    {
                        conexion.conexion.Close();
                    }
                    Close();
                }
            }
            else
            {
                MessageBox.Show("No hay un libro seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

    }
}
