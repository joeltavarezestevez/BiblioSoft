using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Agregar referencia a estos espacios de nombres
using System.Data;
using System.Data.SqlClient;

namespace BiblioSoft
{
    class ConexionSQL
    {
        //Propiedades de la conexion
        public SqlConnection conexion;

        //Propiedades adicionales
        public DataSet ds = new DataSet();

        //Representa una coleccion de datos de mysql en conjunto con la conexion
        public SqlDataAdapter da;

        public SqlCommandBuilder cmb;

        //Connection String de SQLServer
        private string parametrosDeConexion = "Data source=SQLSERVER\\ILDV; initial catalog=Biblioteca; User Id=sa; Password=*qa7823dv*;";

        //Metodo para realizar la conexion
        private void conectar()
        {
            conexion = new SqlConnection(parametrosDeConexion);
        }

        //Constructor de la clase
        public ConexionSQL()
        {
            conectar();
        }

        //Metodo para Consultar Registros en SQL y almacenar el resultado en un dataset
        public void consultar(String consulta, String tabla)
        {
            //limpiar el dataset
            ds.Tables.Clear();

            //Realizar la consulta en SQL y obtener los datos
            // en el MySQLDataAdapter
            da = new SqlDataAdapter(consulta, conexion);

            //Recibir los datos del MySqlDataAdapter en 
            //el objeto MySqlCommandBuilder
            cmb = new SqlCommandBuilder(da);

            //Llenar el dataset con los datos obtenidos
            //por el DataAdapter
            da.Fill(ds, tabla);
        }


        /********************************************************************************
         *                              BuscarRegistro()                                *
         *                                     -                                        *
         *     Metodo para seleccionar y extraer los datos de un registro de la BD      *
         ********************************************************************************/
        public SqlDataReader BuscarRegistro(String query)
        {
            //Para extraer los datos del registro seleccionado en la base de datos
            SqlDataReader LectorRegistro = null;

            //Abrimos la conexion hacia la BD
            conexion.Open();

            //Creamos una instruccion o comando SQL
            SqlCommand Comando = new SqlCommand();

            //Le asignamos la conexion actual
            Comando.Connection = conexion;

            //Enviamos el parametro o la consulta que se desea realizar en SQL
            Comando.CommandText = query;

            //Ejecutamos el comando y almacenamos el resultado en el Lector de datos.
            LectorRegistro = Comando.ExecuteReader();
            
            conexion.Close();

            //Si se encontró un registro, entonces mostramos los datos de este registro en el formulario.
            if (LectorRegistro.Read() == true)
            {
                LectorRegistro.Close();
                return LectorRegistro;
            }
            //De lo contrario, si no se encontró ningun registro, retornamos null.
            else
            {
                LectorRegistro.Close();
                return null;
            }
        }

        //Metodo para ejecutar una instruccion en referencia a un registro en SQL
        public void ejecutar(String comando)
        {
            //abrir la conexion
            conexion.Open();

            //Pasar los parametros de la instruccion a ejecutar
            // y de la conexion al MySqlCommand
            SqlCommand cmd = new SqlCommand(comando, conexion);

            //Obtenemos el numero de filas afectadas por la instruccion
            cmd.ExecuteNonQuery();

            //cerrar la conexion
            conexion.Close();
        }

        //Metodo para llenar un ComboBox a partir de una consulta en SQL
        public DataTable llenarComboBox(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SqlDataAdapter(sql, conexion);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
    }
}
