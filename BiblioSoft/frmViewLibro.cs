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
    public partial class frmViewLibro : Form
    {
        public frmViewLibro()
        {
            InitializeComponent();
        }

        ConexionSQL conexion = new ConexionSQL();

        public int IdLibro = 0;

        private void frmViewLibro_Load(object sender, EventArgs e)
        {
            if (IdLibro > 0)
            {
                BuscarRegistro();
            }
            
        }

        /********************************************************************************
         *                              BuscarRegistro()                                *
         *                                     -                                        *
         *     Metodo para seleccionar y extraer los datos de un registro de la BD      *
         ********************************************************************************/
        private void BuscarRegistro()
        {
            //Para extraer los datos del registro seleccionado en la base de datos
            SqlDataReader LectorRegistro;

            //Abrimos la conexion hacia la BD
            conexion.conexion.Open();

            //Creamos una instruccion o comando SQL
            SqlCommand Comando = new SqlCommand();

            //Le asignamos la conexion actual
            Comando.Connection = conexion.conexion;

            //Enviamos el parametro o la consulta que se desea realizar en SQL
            Comando.CommandText = "SELECT Id, Libro_Codigo_Entrada AS Codigo, Libro_Titulo AS Titulo, Libro_Subtitulo AS Subtitulo,"
                   + " Libro_Ubicacion AS Ubicacion, Libro_Fecha_Compra AS [Fecha Compra], Libro_Fecha_Registro AS "
                   + " [Fecha Registro], Libro_Estado AS Estado, Libro_Observaciones AS Observaciones, Autor_Nombre AS Autor,"
                   + " Editora_Nombre AS Editora, Suplidor_Nombre AS Suplidor FROM Libros where Id = '" + IdLibro + "'";

            //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
            LectorRegistro = Comando.ExecuteReader();


            //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
            if (LectorRegistro.Read() == true)
            {
                lblCodigo.Text = LectorRegistro.GetString(1);
                lblTitulo.Text = LectorRegistro.GetString(2);
                lblSubtitulo.Text = LectorRegistro.GetString(3);
                lblUbicacion.Text = LectorRegistro.GetString(4);
                lblFechaCompra.Text = LectorRegistro.GetDateTime(5).ToShortDateString();
                lblFechaRegistro.Text = LectorRegistro.GetDateTime(6).ToShortDateString();
                lblEstado.Text = LectorRegistro.GetString(7);
                lblObservaciones.Text = LectorRegistro.GetString(8);
                lblAutor.Text = LectorRegistro.GetString(9);
                lblEditora.Text = LectorRegistro.GetString(10);
                lblSuplidor.Text = LectorRegistro.GetString(11);
            }
            //De lo contrario, si no se encontró ningun registro, retornamos null.
            else
            {
                MessageBox.Show("No existe un registro con este codigo, verifique y trate de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            conexion.conexion.Close();
            LectorRegistro.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmLibros frm = new frmLibros();
            frm.IdLibro = IdLibro;
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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
