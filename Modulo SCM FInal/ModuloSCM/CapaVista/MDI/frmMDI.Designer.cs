namespace CapaVistaModuloSCM.MDI
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.txtVistaUsuario = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.msMenuMDI = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teléfonoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasYPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asinacionDePerfilYAplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoModuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDeAplicaciónAPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDeReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarReporteAModuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarReporteAAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReportesDeMóduloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.pnlInferior.SuspendLayout();
            this.msMenuMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInferior
            // 
            this.pnlInferior.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlInferior.Controls.Add(this.txtVistaUsuario);
            this.pnlInferior.Controls.Add(this.lblFecha);
            this.pnlInferior.Controls.Add(this.lblHora);
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 844);
            this.pnlInferior.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(1638, 60);
            this.pnlInferior.TabIndex = 5;
            // 
            // txtVistaUsuario
            // 
            this.txtVistaUsuario.Location = new System.Drawing.Point(76, 21);
            this.txtVistaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtVistaUsuario.Name = "txtVistaUsuario";
            this.txtVistaUsuario.Size = new System.Drawing.Size(230, 27);
            this.txtVistaUsuario.TabIndex = 2;
            this.txtVistaUsuario.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblFecha.Location = new System.Drawing.Point(1170, 21);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(1433, 21);
            this.lblHora.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(46, 20);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // msMenuMDI
            // 
            this.msMenuMDI.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.msMenuMDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.módulosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.msMenuMDI.Location = new System.Drawing.Point(0, 0);
            this.msMenuMDI.Name = "msMenuMDI";
            this.msMenuMDI.Padding = new System.Windows.Forms.Padding(16, 2, 0, 2);
            this.msMenuMDI.Size = new System.Drawing.Size(1638, 33);
            this.msMenuMDI.TabIndex = 4;
            this.msMenuMDI.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.archivoToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(219, 30);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // módulosToolStripMenuItem
            // 
            this.módulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedorToolStripMenuItem,
            this.paisToolStripMenuItem,
            this.rutaToolStripMenuItem});
            this.módulosToolStripMenuItem.Name = "módulosToolStripMenuItem";
            this.módulosToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.módulosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.correoProveedorToolStripMenuItem,
            this.teléfonoProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // correoProveedorToolStripMenuItem
            // 
            this.correoProveedorToolStripMenuItem.Name = "correoProveedorToolStripMenuItem";
            this.correoProveedorToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.correoProveedorToolStripMenuItem.Text = "Correo Proveedor";
            this.correoProveedorToolStripMenuItem.Click += new System.EventHandler(this.correoProveedorToolStripMenuItem_Click);
            // 
            // teléfonoProveedorToolStripMenuItem
            // 
            this.teléfonoProveedorToolStripMenuItem.Name = "teléfonoProveedorToolStripMenuItem";
            this.teléfonoProveedorToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.teléfonoProveedorToolStripMenuItem.Text = "Teléfono Proveedor";
            this.teléfonoProveedorToolStripMenuItem.Click += new System.EventHandler(this.teléfonoProveedorToolStripMenuItem_Click);
            // 
            // paisToolStripMenuItem
            // 
            this.paisToolStripMenuItem.Name = "paisToolStripMenuItem";
            this.paisToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.paisToolStripMenuItem.Text = "Pais";
            this.paisToolStripMenuItem.Click += new System.EventHandler(this.paisToolStripMenuItem_Click);
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.rutaToolStripMenuItem.Text = "Ruta";
            this.rutaToolStripMenuItem.Click += new System.EventHandler(this.rutaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasYPedidosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.herramientasToolStripMenuItem.Text = "Procesos";
            // 
            // comprasYPedidosToolStripMenuItem
            // 
            this.comprasYPedidosToolStripMenuItem.Name = "comprasYPedidosToolStripMenuItem";
            this.comprasYPedidosToolStripMenuItem.Size = new System.Drawing.Size(269, 30);
            this.comprasYPedidosToolStripMenuItem.Text = "Compras y Pedidos";
            this.comprasYPedidosToolStripMenuItem.Click += new System.EventHandler(this.comprasYPedidosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.ayudaToolStripMenuItem.Text = "Herramientas";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambioDeContraseñaToolStripMenuItem,
            this.mantenimientoUsuarioToolStripMenuItem,
            this.mantenimientoAplicacionesToolStripMenuItem,
            this.asinacionDePerfilYAplicacionesToolStripMenuItem,
            this.mantenimientoModuloToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.cambioDeContraseñaToolStripMenuItem.Text = "Cambio de Contraseña";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // mantenimientoUsuarioToolStripMenuItem
            // 
            this.mantenimientoUsuarioToolStripMenuItem.Name = "mantenimientoUsuarioToolStripMenuItem";
            this.mantenimientoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.mantenimientoUsuarioToolStripMenuItem.Text = "Mantenimiento Usuario";
            this.mantenimientoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoUsuarioToolStripMenuItem_Click);
            // 
            // mantenimientoAplicacionesToolStripMenuItem
            // 
            this.mantenimientoAplicacionesToolStripMenuItem.Name = "mantenimientoAplicacionesToolStripMenuItem";
            this.mantenimientoAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.mantenimientoAplicacionesToolStripMenuItem.Text = "Mantenimiento Aplicaciones";
            this.mantenimientoAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoAplicacionesToolStripMenuItem_Click);
            // 
            // asinacionDePerfilYAplicacionesToolStripMenuItem
            // 
            this.asinacionDePerfilYAplicacionesToolStripMenuItem.Name = "asinacionDePerfilYAplicacionesToolStripMenuItem";
            this.asinacionDePerfilYAplicacionesToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.asinacionDePerfilYAplicacionesToolStripMenuItem.Text = "Asignación de Perfil y Aplicaciones";
            this.asinacionDePerfilYAplicacionesToolStripMenuItem.Click += new System.EventHandler(this.asinacionDePerfilYAplicacionesToolStripMenuItem_Click);
            // 
            // mantenimientoModuloToolStripMenuItem
            // 
            this.mantenimientoModuloToolStripMenuItem.Name = "mantenimientoModuloToolStripMenuItem";
            this.mantenimientoModuloToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.mantenimientoModuloToolStripMenuItem.Text = "Mantenimiento Módulo";
            this.mantenimientoModuloToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoModuloToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoPerfilToolStripMenuItem,
            this.asignaciónDeAplicaciónAPerfilToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(401, 30);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // mantenimientoPerfilToolStripMenuItem
            // 
            this.mantenimientoPerfilToolStripMenuItem.Name = "mantenimientoPerfilToolStripMenuItem";
            this.mantenimientoPerfilToolStripMenuItem.Size = new System.Drawing.Size(381, 30);
            this.mantenimientoPerfilToolStripMenuItem.Text = "Mantenimiento Perfil";
            this.mantenimientoPerfilToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoPerfilToolStripMenuItem_Click);
            // 
            // asignaciónDeAplicaciónAPerfilToolStripMenuItem
            // 
            this.asignaciónDeAplicaciónAPerfilToolStripMenuItem.Name = "asignaciónDeAplicaciónAPerfilToolStripMenuItem";
            this.asignaciónDeAplicaciónAPerfilToolStripMenuItem.Size = new System.Drawing.Size(381, 30);
            this.asignaciónDeAplicaciónAPerfilToolStripMenuItem.Text = "Asignación de Aplicación a Perfil";
            this.asignaciónDeAplicaciónAPerfilToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDeAplicaciónAPerfilToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestorDeReportesToolStripMenuItem,
            this.asignarReporteAModuloToolStripMenuItem,
            this.asignarReporteAAplicaciónToolStripMenuItem,
            this.verReportesDeMóduloToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // gestorDeReportesToolStripMenuItem
            // 
            this.gestorDeReportesToolStripMenuItem.Name = "gestorDeReportesToolStripMenuItem";
            this.gestorDeReportesToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.gestorDeReportesToolStripMenuItem.Text = "Gestor de Reportes";
            this.gestorDeReportesToolStripMenuItem.Click += new System.EventHandler(this.gestorDeReportesToolStripMenuItem_Click);
            // 
            // asignarReporteAModuloToolStripMenuItem
            // 
            this.asignarReporteAModuloToolStripMenuItem.Name = "asignarReporteAModuloToolStripMenuItem";
            this.asignarReporteAModuloToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.asignarReporteAModuloToolStripMenuItem.Text = "Asignar Reporte a Módulo";
            this.asignarReporteAModuloToolStripMenuItem.Click += new System.EventHandler(this.asignarReporteAModuloToolStripMenuItem_Click);
            // 
            // asignarReporteAAplicaciónToolStripMenuItem
            // 
            this.asignarReporteAAplicaciónToolStripMenuItem.Name = "asignarReporteAAplicaciónToolStripMenuItem";
            this.asignarReporteAAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.asignarReporteAAplicaciónToolStripMenuItem.Text = "Asignar Reporte a Aplicación";
            this.asignarReporteAAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.asignarReporteAAplicaciónToolStripMenuItem_Click);
            // 
            // verReportesDeMóduloToolStripMenuItem
            // 
            this.verReportesDeMóduloToolStripMenuItem.Name = "verReportesDeMóduloToolStripMenuItem";
            this.verReportesDeMóduloToolStripMenuItem.Size = new System.Drawing.Size(349, 30);
            this.verReportesDeMóduloToolStripMenuItem.Text = "Ver Reportes de Módulo";
            this.verReportesDeMóduloToolStripMenuItem.Click += new System.EventHandler(this.verReportesDeMóduloToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(83, 29);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            this.ayudaToolStripMenuItem1.Click += new System.EventHandler(this.ayudaToolStripMenuItem1_Click);
            // 
            // tmrHoraFecha
            // 
            this.tmrHoraFecha.Enabled = true;
            this.tmrHoraFecha.Tick += new System.EventHandler(this.tmrHoraFecha_Tick);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 904);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.msMenuMDI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMDI";
            this.Text = "Karen Roldán 0901-17-63";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.pnlInferior.ResumeLayout(false);
            this.pnlInferior.PerformLayout();
            this.msMenuMDI.ResumeLayout(false);
            this.msMenuMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.TextBox txtVistaUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MenuStrip msMenuMDI;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.Timer tmrHoraFecha;
        private System.Windows.Forms.ToolStripMenuItem comprasYPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teléfonoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asinacionDePerfilYAplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoModuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDeAplicaciónAPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarReporteAModuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarReporteAAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReportesDeMóduloToolStripMenuItem;
    }
}