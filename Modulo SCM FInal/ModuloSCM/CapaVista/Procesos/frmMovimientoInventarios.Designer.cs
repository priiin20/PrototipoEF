namespace CapaVistaModuloSCM.Procesos
{
    partial class frmMovimientoInventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimientoInventarios));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxDetalleMovimiento = new System.Windows.Forms.GroupBox();
            this.dgvMovimiento = new System.Windows.Forms.DataGridView();
            this.gbxEncabezado = new System.Windows.Forms.GroupBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cmbDocuAsociado = new System.Windows.Forms.ComboBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dtpFechaMovimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNoInventario = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDocuAsociado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.lblNoInventario = new System.Windows.Forms.Label();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            this.gbxDetalleMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).BeginInit();
            this.gbxEncabezado.SuspendLayout();
            this.cmsOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlSuperior.Controls.Add(this.btnAyuda);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1133, 49);
            this.pnlSuperior.TabIndex = 0;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.btnGuardar);
            this.pnlCuerpo.Controls.Add(this.gbxDetalleMovimiento);
            this.pnlCuerpo.Controls.Add(this.gbxEncabezado);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 49);
            this.pnlCuerpo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1133, 715);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(904, 411);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 75);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Registrar Movimiento";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbxDetalleMovimiento
            // 
            this.gbxDetalleMovimiento.Controls.Add(this.dgvMovimiento);
            this.gbxDetalleMovimiento.Location = new System.Drawing.Point(23, 392);
            this.gbxDetalleMovimiento.Name = "gbxDetalleMovimiento";
            this.gbxDetalleMovimiento.Size = new System.Drawing.Size(836, 288);
            this.gbxDetalleMovimiento.TabIndex = 2;
            this.gbxDetalleMovimiento.TabStop = false;
            this.gbxDetalleMovimiento.Text = "Detalles del Movimiento";
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.AllowUserToDeleteRows = false;
            this.dgvMovimiento.AllowUserToResizeColumns = false;
            this.dgvMovimiento.AllowUserToResizeRows = false;
            this.dgvMovimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimiento.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.Location = new System.Drawing.Point(30, 36);
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.ReadOnly = true;
            this.dgvMovimiento.RowHeadersWidth = 51;
            this.dgvMovimiento.RowTemplate.Height = 24;
            this.dgvMovimiento.Size = new System.Drawing.Size(774, 214);
            this.dgvMovimiento.TabIndex = 1;
            this.dgvMovimiento.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMovimiento_EditingControlShowing);
            this.dgvMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvMovimiento_KeyPress);
            // 
            // gbxEncabezado
            // 
            this.gbxEncabezado.Controls.Add(this.txtDestino);
            this.gbxEncabezado.Controls.Add(this.txtOrigen);
            this.gbxEncabezado.Controls.Add(this.lblDestino);
            this.gbxEncabezado.Controls.Add(this.lblOrigen);
            this.gbxEncabezado.Controls.Add(this.cmbDocuAsociado);
            this.gbxEncabezado.Controls.Add(this.cmbVehiculo);
            this.gbxEncabezado.Controls.Add(this.cmbRuta);
            this.gbxEncabezado.Controls.Add(this.cmbTipo);
            this.gbxEncabezado.Controls.Add(this.dtpFechaMovimiento);
            this.gbxEncabezado.Controls.Add(this.txtDescripcion);
            this.gbxEncabezado.Controls.Add(this.txtNoInventario);
            this.gbxEncabezado.Controls.Add(this.lblDescripcion);
            this.gbxEncabezado.Controls.Add(this.lblDocuAsociado);
            this.gbxEncabezado.Controls.Add(this.lblFecha);
            this.gbxEncabezado.Controls.Add(this.lblVehiculo);
            this.gbxEncabezado.Controls.Add(this.lblRuta);
            this.gbxEncabezado.Controls.Add(this.lblTipoMovimiento);
            this.gbxEncabezado.Controls.Add(this.lblNoInventario);
            this.gbxEncabezado.Location = new System.Drawing.Point(23, 21);
            this.gbxEncabezado.Name = "gbxEncabezado";
            this.gbxEncabezado.Size = new System.Drawing.Size(1081, 351);
            this.gbxEncabezado.TabIndex = 0;
            this.gbxEncabezado.TabStop = false;
            this.gbxEncabezado.Text = "Datos Generales de Movimiento de Inventario";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(421, 221);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDestino.Size = new System.Drawing.Size(139, 27);
            this.txtDestino.TabIndex = 17;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(161, 221);
            this.txtOrigen.Multiline = true;
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.ReadOnly = true;
            this.txtOrigen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrigen.Size = new System.Drawing.Size(139, 27);
            this.txtOrigen.TabIndex = 16;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(335, 221);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(69, 20);
            this.lblDestino.TabIndex = 15;
            this.lblDestino.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(81, 221);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(65, 20);
            this.lblOrigen.TabIndex = 14;
            this.lblOrigen.Text = "Origen";
            // 
            // cmbDocuAsociado
            // 
            this.cmbDocuAsociado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDocuAsociado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocuAsociado.FormattingEnabled = true;
            this.cmbDocuAsociado.Location = new System.Drawing.Point(731, 35);
            this.cmbDocuAsociado.Name = "cmbDocuAsociado";
            this.cmbDocuAsociado.Size = new System.Drawing.Size(223, 28);
            this.cmbDocuAsociado.TabIndex = 13;
            this.cmbDocuAsociado.SelectedIndexChanged += new System.EventHandler(this.cmbDocuAsociado_SelectedIndexChanged);
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(190, 290);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(223, 28);
            this.cmbVehiculo.TabIndex = 12;
            this.cmbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculo_SelectedIndexChanged);
            // 
            // cmbRuta
            // 
            this.cmbRuta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(190, 162);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(223, 28);
            this.cmbRuta.TabIndex = 11;
            this.cmbRuta.SelectedIndexChanged += new System.EventHandler(this.cmbRuta_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(190, 98);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(223, 28);
            this.cmbTipo.TabIndex = 10;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // dtpFechaMovimiento
            // 
            this.dtpFechaMovimiento.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaMovimiento.Location = new System.Drawing.Point(731, 106);
            this.dtpFechaMovimiento.Name = "dtpFechaMovimiento";
            this.dtpFechaMovimiento.Size = new System.Drawing.Size(320, 27);
            this.dtpFechaMovimiento.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.Location = new System.Drawing.Point(731, 167);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(320, 147);
            this.txtDescripcion.TabIndex = 8;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtNoInventario
            // 
            this.txtNoInventario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNoInventario.Enabled = false;
            this.txtNoInventario.Location = new System.Drawing.Point(190, 35);
            this.txtNoInventario.Name = "txtNoInventario";
            this.txtNoInventario.ReadOnly = true;
            this.txtNoInventario.Size = new System.Drawing.Size(100, 27);
            this.txtNoInventario.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(582, 169);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblDocuAsociado
            // 
            this.lblDocuAsociado.AutoSize = true;
            this.lblDocuAsociado.Location = new System.Drawing.Point(582, 37);
            this.lblDocuAsociado.Name = "lblDocuAsociado";
            this.lblDocuAsociado.Size = new System.Drawing.Size(132, 20);
            this.lblDocuAsociado.TabIndex = 5;
            this.lblDocuAsociado.Text = "Docu. Asociado";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(582, 105);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(26, 290);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(80, 20);
            this.lblVehiculo.TabIndex = 3;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(26, 170);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(43, 20);
            this.lblRuta.TabIndex = 2;
            this.lblRuta.Text = "Ruta";
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(26, 106);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(142, 20);
            this.lblTipoMovimiento.TabIndex = 1;
            this.lblTipoMovimiento.Text = "Tipo Movimiento";
            // 
            // lblNoInventario
            // 
            this.lblNoInventario.AutoSize = true;
            this.lblNoInventario.Location = new System.Drawing.Point(26, 38);
            this.lblNoInventario.Name = "lblNoInventario";
            this.lblNoInventario.Size = new System.Drawing.Size(120, 20);
            this.lblNoInventario.TabIndex = 0;
            this.lblNoInventario.Text = "No. Inventario";
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemEliminar,
            this.itemActualizar});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(158, 52);
            // 
            // itemEliminar
            // 
            this.itemEliminar.Name = "itemEliminar";
            this.itemEliminar.Size = new System.Drawing.Size(157, 24);
            this.itemEliminar.Text = "Eliminar";
            // 
            // itemActualizar
            // 
            this.itemActualizar.Name = "itemActualizar";
            this.itemActualizar.Size = new System.Drawing.Size(157, 24);
            this.itemActualizar.Text = "Actualizar";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1049, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(84, 49);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmMovimientoInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 764);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimientoInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2400 - Movimientos de Inventarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMovimientoInventarios_FormClosing);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.gbxDetalleMovimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).EndInit();
            this.gbxEncabezado.ResumeLayout(false);
            this.gbxEncabezado.PerformLayout();
            this.cmsOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem itemEliminar;
        private System.Windows.Forms.ToolStripMenuItem itemActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbxDetalleMovimiento;
        private System.Windows.Forms.DataGridView dgvMovimiento;
        private System.Windows.Forms.GroupBox gbxEncabezado;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cmbDocuAsociado;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DateTimePicker dtpFechaMovimiento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNoInventario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDocuAsociado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.Label lblNoInventario;
        private System.Windows.Forms.Button btnAyuda;
    }
}