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

        public String codigoLibro = "";

        String sql = "";

        private void frmViewLibro_Load(object sender, EventArgs e)
        {
            BuscarRegistro();
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
            Comando.CommandText = "SELECT Libros.Id, Libros.Libro_Codigo_Entrada AS Codigo, Libros.Libro_Titulo AS Titulo, Libros.Libro_Subtitulo AS Subtitulo,"
                   + " Libros.Libro_Ubicacion AS Ubicacion, Libros.Libro_Fecha_Compra AS [Fecha Compra], Libros.Libro_Fecha_Registro AS "
                   + " [Fecha Registro], Libros.Libro_Estado AS Estado, Libros.Libro_Observaciones AS Observaciones, Autores.Autor_Nombre AS Autor,"
                   + " Editoras.Editora_Nombre AS Editora, Suplidores.Suplidor_Nombre AS Suplidor FROM Libros INNER JOIN Autores ON "
                   + " Libros.Autor_Id = Autores.Id INNER JOIN Editoras ON Libros.Editora_Id = Editoras.Id INNER JOIN Suplidores ON "
                   + " Libros.Suplidor_id = Suplidores.Id where Libros.Libro_Codigo_Entrada = '" + codigoLibro + "'";

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
    }
}
