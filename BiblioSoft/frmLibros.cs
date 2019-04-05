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
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        ConexionSQL conexion = new ConexionSQL();
        int mayor = 0;
        int menor = 0;
        public int IdLibro = 0;
        String tabla;
        String campos;
        String valores;
        String condicion;
        String query;
        String sql = "";

        private void BuscarRegistroMayoryMenor()
        {
            try
            {
                //Para extraer los datos del registro seleccionado en la base de datos
                SqlDataReader LectorClientes;
                //Abrimos la conexion hacia la BD
                conexion.conexion.Open();
                //Creamos una instruccion o comando SQL
                SqlCommand Comando = new SqlCommand();
                //Le asignamos la conexion actual
                Comando.Connection = conexion.conexion;
                //Enviamos el parametro o la consulta que se desea realizar en SQL
                Comando.CommandText = "Select count(id) From Libros";
                //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
                LectorClientes = Comando.ExecuteReader();
                //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
                if (LectorClientes.Read() == true)
                {
                    if (LectorClientes.GetInt32(0) > 0)
                    {
                        LectorClientes.Close();
                        //Enviamos el parametro o la consulta que se desea realizar en SQL
                        Comando.CommandText = "Select max(id), min(id) From Libros";
                        //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
                        LectorClientes = Comando.ExecuteReader();
                        if (LectorClientes.Read() == true)
                        {
                            //Asignando el valor de cada campo al objeto correspondiente
                            mayor = LectorClientes.GetInt32(0);
                            menor = LectorClientes.GetInt32(1);
                            LectorClientes.Close();
                        }
                    }
                }
                else
                {
                    //Borramos el lector que almacena el registro, para poder utilizarlo nuevamente
                    LectorClientes.Close();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Aviso - BuscarRegistroMayoryMenor", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            finally
            {
                conexion.conexion.Close();
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
                   + " Editora_Nombre AS Editora, Suplidor_Nombre AS Suplidor FROM Libros where ID = '" + IdLibro + "'";

            //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
            LectorRegistro = Comando.ExecuteReader();


            //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
            if (LectorRegistro.Read() == true)
            {
                txtCodigo.Text = LectorRegistro.GetString(1);
                txtTitulo.Text = LectorRegistro.GetString(2);
                txtSubtitulo.Text = LectorRegistro.GetString(3);
                txtUbicacion.Text = LectorRegistro.GetString(4);
                dtpFechaCompra.Text = LectorRegistro.GetDateTime(5).ToString();
                lblFechaRegistro.Text = LectorRegistro.GetDateTime(6).ToString();
                cbxEstado.SelectedItem = LectorRegistro.GetString(7);
                txtObservaciones.Text = LectorRegistro.GetString(8);
                txtAutor.Text = LectorRegistro.GetString(9);
                txtEditora.Text = LectorRegistro.GetString(10);
                txtSuplidor.Text = LectorRegistro.GetString(11);
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

        private void frmLibros_Load(object sender, EventArgs e)
        {
            BuscarRegistroMayoryMenor();

            if (IdLibro > 0)
            {
                lblIdLibro.Text = IdLibro.ToString();
                BuscarRegistro();
            }
            else
            {
                IdLibro = mayor+1;
                lblIdLibro.Text = IdLibro.ToString();
                cbxEstado.SelectedIndex = 0;
                btnEliminarCliente.Enabled = false;
            }
        }

        private void btnRegistroAnterior_Click(object sender, EventArgs e)
        {
            if (IdLibro > 1)
            {
                int codigoanterior = IdLibro - 1;

                if (codigoanterior >= menor)
                {
                    IdLibro = codigoanterior;
                    lblIdLibro.Text = IdLibro.ToString();
                }
            }
        }

        private void btnRegistroSiguiente_Click(object sender, EventArgs e)
        {
            if (IdLibro > 0)
            {
                int codigosiguiente = IdLibro + 1;

                if (codigosiguiente <= mayor)
                {
                    IdLibro = codigosiguiente;
                    lblIdLibro.Text = IdLibro.ToString();
                }
            }
        }

        private void lblIdLibro_TextChanged(object sender, EventArgs e)
        {
            if (IdLibro > 0 && IdLibro <= mayor)
            {
                BuscarRegistro();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Debe indicar el título del libro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtTitulo.Focus();
                return;
            }

            if (IdLibro > mayor)
            {
                tabla = "Libros";
                campos = " Libro_Codigo_Entrada, Libro_Titulo, Libro_Subtitulo, Libro_Ubicacion, Libro_Fecha_Compra, " +
                         " Libro_Estado, Libro_Observaciones, Autor_Nombre, Editora_Nombre, Suplidor_Nombre";

                valores = "'" + txtCodigo.Text.Trim() + "', '" + txtTitulo.Text.Trim() + "',  '" + txtSubtitulo.Text.Trim() + "'," +
                          "'" + txtUbicacion.Text.Trim() + "', '" + dtpFechaCompra.Value.ToString("yyyy-MM-dd") + "', '" + cbxEstado.SelectedItem + "'," +
                          "'" + txtObservaciones.Text.Trim() + "', '" + txtAutor.Text.Trim() + "', '" + txtEditora.Text.Trim() + "'," +
                          "'" + txtSuplidor.Text.Trim() + "'";

                query = "INSERT INTO " + tabla + "(" + campos + ") values (" + valores + ")";

                try
                {
                    conexion.ejecutar(query);
                    MessageBox.Show("Registro Insertado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al insertar el registro: " + error.Message, "Aviso - insertarRegistro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                campos = " Libro_Codigo_Entrada         = '" + txtCodigo.Text.Trim() + "'," +
                         " Libro_Titulo                 = '" + txtTitulo.Text.Trim() + "'," +
                         " Libro_Subtitulo              = '" + txtSubtitulo.Text.Trim() + "'," +
                         " Libro_Ubicacion              = '" + txtUbicacion.Text.Trim() + "'," +
                         " Libro_Fecha_Compra           = '" + dtpFechaCompra.Value.ToString("yyyy-MM-dd") + "'," +
                         " Libro_Estado                 = '" + cbxEstado.SelectedItem + "'," +
                         " Libro_Observaciones          = '" + txtObservaciones.Text.Trim() + "'," +
                         " Autor_Nombre                 = '" + txtAutor.Text.Trim() + "'," +
                         " Editora_Nombre               = '" + txtEditora.Text.Trim() + "'," +
                         " Suplidor_Nombre              = '" + txtSuplidor.Text.Trim() + "'";
                
                tabla = " Libros";
                condicion = " id =" + IdLibro;
                query = "Update " + tabla + " SET " + campos + " WHERE " + condicion;
                try
                {
                    conexion.ejecutar(query);
                    MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al actualizar el registro: " + error.Message, "Aviso - actualizarRegistro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

    }
}
