namespace CapaVistaModuloSCM.Procesos
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.gbxTipoOperacion = new System.Windows.Forms.GroupBox();
            this.rbtnPedido = new System.Windows.Forms.RadioButton();
            this.rbtnCompra = new System.Windows.Forms.RadioButton();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTotalEtiqueta = new System.Windows.Forms.Label();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.cmbProducto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxEncabezado = new System.Windows.Forms.GroupBox();
            this.cmbEstadoProceso = new System.Windows.Forms.ComboBox();
            this.lblEstadoProceso = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblProvFab = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.tmrTotal = new System.Windows.Forms.Timer(this.components);
            this.tltToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCuerpo.SuspendLayout();
            this.gbxTipoOperacion.SuspendLayout();
            this.gbxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.gbxEncabezado.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.gbxTipoOperacion);
            this.pnlCuerpo.Controls.Add(this.lblValorTotal);
            this.pnlCuerpo.Controls.Add(this.lblTotalEtiqueta);
            this.pnlCuerpo.Controls.Add(this.gbxDetalle);
            this.pnlCuerpo.Controls.Add(this.btnGuardar);
            this.pnlCuerpo.Controls.Add(this.gbxEncabezado);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 51);
            this.pnlCuerpo.Margin = new System.Windows.Forms.Padding(5);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1391, 720);
            this.pnlCuerpo.TabIndex = 7;
            // 
            // gbxTipoOperacion
            // 
            this.gbxTipoOperacion.Controls.Add(this.rbtnPedido);
            this.gbxTipoOperacion.Controls.Add(this.rbtnCompra);
            this.gbxTipoOperacion.Location = new System.Drawing.Point(30, 32);
            this.gbxTipoOperacion.Name = "gbxTipoOperacion";
            this.gbxTipoOperacion.Size = new System.Drawing.Size(204, 167);
            this.gbxTipoOperacion.TabIndex = 2;
            this.gbxTipoOperacion.TabStop = false;
            this.gbxTipoOperacion.Text = "Tipo de Operación";
            // 
            // rbtnPedido
            // 
            this.rbtnPedido.AutoSize = true;
            this.rbtnPedido.Location = new System.Drawing.Point(39, 103);
            this.rbtnPedido.Name = "rbtnPedido";
            this.rbtnPedido.Size = new System.Drawing.Size(85, 24);
            this.rbtnPedido.TabIndex = 14;
            this.rbtnPedido.TabStop = true;
            this.rbtnPedido.Text = "Pedido";
            this.rbtnPedido.UseVisualStyleBackColor = true;
            this.rbtnPedido.CheckedChanged += new System.EventHandler(this.rbtnPedido_CheckedChanged);
            // 
            // rbtnCompra
            // 
            this.rbtnCompra.AutoSize = true;
            this.rbtnCompra.Location = new System.Drawing.Point(39, 48);
            this.rbtnCompra.Name = "rbtnCompra";
            this.rbtnCompra.Size = new System.Drawing.Size(94, 24);
            this.rbtnCompra.TabIndex = 13;
            this.rbtnCompra.TabStop = true;
            this.rbtnCompra.Text = "Compra";
            this.rbtnCompra.UseVisualStyleBackColor = true;
            this.rbtnCompra.CheckedChanged += new System.EventHandler(this.rbtnCompra_CheckedChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(153, 652);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(21, 22);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "0";
            this.lblValorTotal.Visible = false;
            // 
            // lblTotalEtiqueta
            // 
            this.lblTotalEtiqueta.AutoSize = true;
            this.lblTotalEtiqueta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEtiqueta.Location = new System.Drawing.Point(52, 652);
            this.lblTotalEtiqueta.Name = "lblTotalEtiqueta";
            this.lblTotalEtiqueta.Size = new System.Drawing.Size(55, 22);
            this.lblTotalEtiqueta.TabIndex = 15;
            this.lblTotalEtiqueta.Text = "Total";
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.dgvCompras);
            this.gbxDetalle.Location = new System.Drawing.Point(30, 223);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(1327, 386);
            this.gbxDetalle.TabIndex = 12;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle de Gestión";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToResizeColumns = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbProducto,
            this.txtCantidad,
            this.txtPrecioUnitario,
            this.txtSubtotal});
            this.dgvCompras.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCompras.Location = new System.Drawing.Point(26, 49);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(1264, 318);
            this.dgvCompras.TabIndex = 1;
            this.dgvCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellEndEdit);
            this.dgvCompras.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCompras_EditingControlShowing);
            this.dgvCompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCompras_KeyPress);
            // 
            // cmbProducto
            // 
            this.cmbProducto.HeaderText = "Producto";
            this.cmbProducto.MinimumWidth = 6;
            this.cmbProducto.Name = "cmbProducto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.HeaderText = "Cantidad";
            this.txtCantidad.MinimumWidth = 6;
            this.txtCantidad.Name = "txtCantidad";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.HeaderText = "Precio Unitario";
            this.txtPrecioUnitario.MinimumWidth = 6;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.HeaderText = "Subtotal";
            this.txtSubtotal.MinimumWidth = 6;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DimGray;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(1187, 636);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 56);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Registrar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbxEncabezado
            // 
            this.gbxEncabezado.Controls.Add(this.cmbEstadoProceso);
            this.gbxEncabezado.Controls.Add(this.lblEstadoProceso);
            this.gbxEncabezado.Controls.Add(this.dtpFechaCompra);
            this.gbxEncabezado.Controls.Add(this.cmbProveedor);
            this.gbxEncabezado.Controls.Add(this.txtCodigo);
            this.gbxEncabezado.Controls.Add(this.lblFechaIngreso);
            this.gbxEncabezado.Controls.Add(this.lblProvFab);
            this.gbxEncabezado.Controls.Add(this.lblID);
            this.gbxEncabezado.Controls.Add(this.button2);
            this.gbxEncabezado.Location = new System.Drawing.Point(261, 32);
            this.gbxEncabezado.Margin = new System.Windows.Forms.Padding(5);
            this.gbxEncabezado.Name = "gbxEncabezado";
            this.gbxEncabezado.Padding = new System.Windows.Forms.Padding(5);
            this.gbxEncabezado.Size = new System.Drawing.Size(1096, 167);
            this.gbxEncabezado.TabIndex = 0;
            this.gbxEncabezado.TabStop = false;
            this.gbxEncabezado.Text = "Encabezado de Gestión";
            // 
            // cmbEstadoProceso
            // 
            this.cmbEstadoProceso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEstadoProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoProceso.FormattingEnabled = true;
            this.cmbEstadoProceso.Items.AddRange(new object[] {
            "Seleccionar Opción",
            "Ingreso de Órden",
            "Ejecución de Órden",
            "Recepción de Órden"});
            this.cmbEstadoProceso.Location = new System.Drawing.Point(217, 113);
            this.cmbEstadoProceso.Name = "cmbEstadoProceso";
            this.cmbEstadoProceso.Size = new System.Drawing.Size(222, 28);
            this.cmbEstadoProceso.TabIndex = 23;
            this.cmbEstadoProceso.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoProceso_SelectedIndexChanged);
            // 
            // lblEstadoProceso
            // 
            this.lblEstadoProceso.AutoSize = true;
            this.lblEstadoProceso.Location = new System.Drawing.Point(35, 121);
            this.lblEstadoProceso.Name = "lblEstadoProceso";
            this.lblEstadoProceso.Size = new System.Drawing.Size(159, 20);
            this.lblEstadoProceso.TabIndex = 22;
            this.lblEstadoProceso.Text = "Estado del Proceso";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpFechaCompra.Location = new System.Drawing.Point(689, 50);
            this.dtpFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(313, 27);
            this.dtpFechaCompra.TabIndex = 21;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(335, 52);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(206, 28);
            this.cmbProveedor.TabIndex = 20;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(75, 50);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(91, 27);
            this.txtCodigo.TabIndex = 19;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(605, 55);
            this.lblFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(56, 20);
            this.lblFechaIngreso.TabIndex = 18;
            this.lblFechaIngreso.Text = "Fecha";
            // 
            // lblProvFab
            // 
            this.lblProvFab.AutoSize = true;
            this.lblProvFab.Location = new System.Drawing.Point(223, 52);
            this.lblProvFab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvFab.Name = "lblProvFab";
            this.lblProvFab.Size = new System.Drawing.Size(92, 20);
            this.lblProvFab.TabIndex = 17;
            this.lblProvFab.Text = "Proveedor";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(31, 52);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 20);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "No.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1165, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlSuperior.Controls.Add(this.btnAyuda);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(5);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1391, 51);
            this.pnlSuperior.TabIndex = 6;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1307, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(84, 51);
            this.btnAyuda.TabIndex = 0;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // tmrTotal
            // 
            this.tmrTotal.Tick += new System.EventHandler(this.tmrTotal_Tick);
            // 
            // tltToolTip
            // 
            this.tltToolTip.IsBalloon = true;
            this.tltToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 771);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2316 - Proceso de Registro de Órdenes de Compras y Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCompras_FormClosing);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            this.gbxTipoOperacion.ResumeLayout(false);
            this.gbxTipoOperacion.PerformLayout();
            this.gbxDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.gbxEncabezado.ResumeLayout(false);
            this.gbxEncabezado.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.GroupBox gbxEncabezado;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblProvFab;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubtotal;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.RadioButton rbtnPedido;
        private System.Windows.Forms.RadioButton rbtnCompra;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTotalEtiqueta;
        private System.Windows.Forms.GroupBox gbxTipoOperacion;
        private System.Windows.Forms.Timer tmrTotal;
        private System.Windows.Forms.ToolTip tltToolTip;
        private System.Windows.Forms.ComboBox cmbEstadoProceso;
        private System.Windows.Forms.Label lblEstadoProceso;
        private System.Windows.Forms.Button btnAyuda;
    }
}