namespace BiblioSoft
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Contenedor = new System.Windows.Forms.SplitContainer();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnSuplidores = new System.Windows.Forms.Button();
            this.btnEditoras = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.pbxUsername = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxMaximizar = new System.Windows.Forms.PictureBox();
            this.pbxRestaurar = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.lblOpcionSeleccionada = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).BeginInit();
            this.Contenedor.Panel1.SuspendLayout();
            this.Contenedor.Panel2.SuspendLayout();
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsername)).BeginInit();
            this.panelMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            // 
            // Contenedor.Panel1
            // 
            this.Contenedor.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(123)))));
            this.Contenedor.Panel1.Controls.Add(this.btnInicio);
            this.Contenedor.Panel1.Controls.Add(this.btnSuplidores);
            this.Contenedor.Panel1.Controls.Add(this.btnEditoras);
            this.Contenedor.Panel1.Controls.Add(this.btnAutores);
            this.Contenedor.Panel1.Controls.Add(this.btnLibros);
            this.Contenedor.Panel1.Controls.Add(this.pbxUsername);
            this.Contenedor.Panel1.Controls.Add(this.lblUsername);
            this.Contenedor.Panel1.Controls.Add(this.btnPrestamos);
            this.Contenedor.Panel1.Controls.Add(this.panelMenuPrincipal);
            this.Contenedor.Panel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contenedor.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // Contenedor.Panel2
            // 
            this.Contenedor.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Contenedor.Panel2.Controls.Add(this.panelContenedor);
            this.Contenedor.Panel2.Controls.Add(this.panelTitulo);
            this.Contenedor.Panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contenedor.Size = new System.Drawing.Size(1068, 640);
            this.Contenedor.SplitterDistance = 287;
            this.Contenedor.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::BiblioSoft.Properties.Resources.home_icon;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 137);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(287, 50);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.Text = "      Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnSuplidores
            // 
            this.btnSuplidores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuplidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuplidores.FlatAppearance.BorderSize = 0;
            this.btnSuplidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuplidores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuplidores.Image = global::BiblioSoft.Properties.Resources.supplier_icon;
            this.btnSuplidores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuplidores.Location = new System.Drawing.Point(0, 417);
            this.btnSuplidores.Name = "btnSuplidores";
            this.btnSuplidores.Size = new System.Drawing.Size(287, 50);
            this.btnSuplidores.TabIndex = 10;
            this.btnSuplidores.Text = "      Suplidores";
            this.btnSuplidores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuplidores.UseVisualStyleBackColor = true;
            // 
            // btnEditoras
            // 
            this.btnEditoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditoras.FlatAppearance.BorderSize = 0;
            this.btnEditoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditoras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditoras.Image = global::BiblioSoft.Properties.Resources.editors_icon;
            this.btnEditoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditoras.Location = new System.Drawing.Point(3, 361);
            this.btnEditoras.Name = "btnEditoras";
            this.btnEditoras.Size = new System.Drawing.Size(287, 50);
            this.btnEditoras.TabIndex = 9;
            this.btnEditoras.Text = "      Editoras";
            this.btnEditoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditoras.UseVisualStyleBackColor = true;
            // 
            // btnAutores
            // 
            this.btnAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutores.FlatAppearance.BorderSize = 0;
            this.btnAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.Image = global::BiblioSoft.Properties.Resources.author_icon;
            this.btnAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.Location = new System.Drawing.Point(0, 305);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(287, 50);
            this.btnAutores.TabIndex = 8;
            this.btnAutores.Text = "      Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutores.UseVisualStyleBackColor = true;
            // 
            // btnLibros
            // 
            this.btnLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibros.FlatAppearance.BorderSize = 0;
            this.btnLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibros.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.Image = global::BiblioSoft.Properties.Resources.book_icon2;
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.Location = new System.Drawing.Point(0, 249);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(287, 50);
            this.btnLibros.TabIndex = 7;
            this.btnLibros.Text = "      Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibros.UseVisualStyleBackColor = true;
            // 
            // pbxUsername
            // 
            this.pbxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxUsername.Image = global::BiblioSoft.Properties.Resources.default_user_icon;
            this.pbxUsername.Location = new System.Drawing.Point(-1, 574);
            this.pbxUsername.Name = "pbxUsername";
            this.pbxUsername.Size = new System.Drawing.Size(65, 67);
            this.pbxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUsername.TabIndex = 3;
            this.pbxUsername.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(70, 595);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(115, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Image = global::BiblioSoft.Properties.Resources.book_loan;
            this.btnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 193);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(287, 50);
            this.btnPrestamos.TabIndex = 0;
            this.btnPrestamos.Text = "      Préstamos";
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenuPrincipal.BackColor = System.Drawing.Color.White;
            this.panelMenuPrincipal.Controls.Add(this.pbxLogo);
            this.panelMenuPrincipal.Controls.Add(this.lblMenu);
            this.panelMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenuPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(123)))));
            this.panelMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(287, 50);
            this.panelMenuPrincipal.TabIndex = 6;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.White;
            this.pbxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogo.Image = global::BiblioSoft.Properties.Resources.Da_vinci_;
            this.pbxLogo.Location = new System.Drawing.Point(3, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(59, 48);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.White;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(123)))));
            this.lblMenu.Location = new System.Drawing.Point(64, 8);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(184, 28);
            this.lblMenu.TabIndex = 4;
            this.lblMenu.Text = "Menú Principal";
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizar.Image = global::BiblioSoft.Properties.Resources.minimize_icon;
            this.pbxMinimizar.Location = new System.Drawing.Point(657, 9);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pbxMinimizar.TabIndex = 0;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pbxMaximizar
            // 
            this.pbxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMaximizar.Image = global::BiblioSoft.Properties.Resources.maximize_icon;
            this.pbxMaximizar.Location = new System.Drawing.Point(697, 9);
            this.pbxMaximizar.Name = "pbxMaximizar";
            this.pbxMaximizar.Size = new System.Drawing.Size(32, 32);
            this.pbxMaximizar.TabIndex = 1;
            this.pbxMaximizar.TabStop = false;
            this.pbxMaximizar.Click += new System.EventHandler(this.pbxMaximizar_Click);
            // 
            // pbxRestaurar
            // 
            this.pbxRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRestaurar.Image = global::BiblioSoft.Properties.Resources.restore_icon;
            this.pbxRestaurar.Location = new System.Drawing.Point(697, 9);
            this.pbxRestaurar.Name = "pbxRestaurar";
            this.pbxRestaurar.Size = new System.Drawing.Size(32, 32);
            this.pbxRestaurar.TabIndex = 2;
            this.pbxRestaurar.TabStop = false;
            this.pbxRestaurar.Visible = false;
            this.pbxRestaurar.Click += new System.EventHandler(this.pbxRestaurar_Click);
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCerrar.Image = global::BiblioSoft.Properties.Resources.close_icon;
            this.pbxCerrar.Location = new System.Drawing.Point(737, 8);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(32, 32);
            this.pbxCerrar.TabIndex = 3;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // lblOpcionSeleccionada
            // 
            this.lblOpcionSeleccionada.AutoSize = true;
            this.lblOpcionSeleccionada.Location = new System.Drawing.Point(13, 14);
            this.lblOpcionSeleccionada.Name = "lblOpcionSeleccionada";
            this.lblOpcionSeleccionada.Size = new System.Drawing.Size(179, 21);
            this.lblOpcionSeleccionada.TabIndex = 4;
            this.lblOpcionSeleccionada.Text = "Opcion Seleccionada";
            // 
            // panelTitulo
            // 
            this.panelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitulo.BackColor = System.Drawing.Color.White;
            this.panelTitulo.Controls.Add(this.lblOpcionSeleccionada);
            this.panelTitulo.Controls.Add(this.pbxCerrar);
            this.panelTitulo.Controls.Add(this.pbxRestaurar);
            this.panelTitulo.Controls.Add(this.pbxMaximizar);
            this.panelTitulo.Controls.Add(this.pbxMinimizar);
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(777, 50);
            this.panelTitulo.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.Location = new System.Drawing.Point(5, 56);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(764, 574);
            this.panelContenedor.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 640);
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Contenedor.Panel1.ResumeLayout(false);
            this.Contenedor.Panel1.PerformLayout();
            this.Contenedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Contenedor)).EndInit();
            this.Contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsername)).EndInit();
            this.panelMenuPrincipal.ResumeLayout(false);
            this.panelMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Contenedor;
        private System.Windows.Forms.PictureBox pbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnSuplidores;
        private System.Windows.Forms.Button btnEditoras;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblOpcionSeleccionada;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.PictureBox pbxRestaurar;
        private System.Windows.Forms.PictureBox pbxMaximizar;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

