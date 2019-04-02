using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace BiblioSoft
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        ConexionSQL conexion = new ConexionSQL();

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbxMaximizar.Visible = true;
            pbxRestaurar.Visible = false;
        }

        private void pbxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbxRestaurar.Visible = true;
            pbxMaximizar.Visible = false;
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Metodo para abrir un Form en un Panel
        private void abrirFormEnPanel(object formHijo)
        {
            //Verificar si hay un form en el panel
            if (panelContenedor.Controls.Count > 0)
            {
                //remover el form
                panelContenedor.Controls.RemoveAt(0);
            }

            //Creando una instancia del formHijo llamada formNuevo
            Form formNuevo = formHijo as Form;

            //Evitar que el formulario nuevo sea superior al MenuPrincipal (Contenedor)
            formNuevo.TopLevel = false;

            //Para rellenar el espacio completo del Panel2 con el formNuevo
            formNuevo.Dock = DockStyle.Fill;

            //Agregamos el formNuevo al Panel2
            panelContenedor.Controls.Add(formNuevo);

            //Mostramos el formNuevo
            formNuevo.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new frmInicio());
            lblOpcionSeleccionada.Text = "Inicio";
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnInicio.PerformClick();
        }
    }
}
