namespace CapaVistaModuloSCM.Mantenimientos
{
    partial class frmCorreoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorreoProveedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbIdProveedor = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvCorreoProveedor = new System.Windows.Forms.DataGridView();
            this.cmbMostrar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreoProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 124);
            this.panel1.TabIndex = 0;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(0, -5);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(66, 182);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 21);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProveedor.Location = new System.Drawing.Point(36, 237);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(109, 21);
            this.lblIdProveedor.TabIndex = 2;
            this.lblIdProveedor.Text = "Proveedor:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(64, 285);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(79, 21);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(62, 333);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(81, 21);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(168, 179);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(181, 29);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Tag = "pk_id_correo_proveedor";
            // 
            // cmbIdProveedor
            // 
            this.cmbIdProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdProveedor.Enabled = false;
            this.cmbIdProveedor.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdProveedor.FormattingEnabled = true;
            this.cmbIdProveedor.Location = new System.Drawing.Point(168, 237);
            this.cmbIdProveedor.Name = "cmbIdProveedor";
            this.cmbIdProveedor.Size = new System.Drawing.Size(55, 28);
            this.cmbIdProveedor.TabIndex = 6;
            this.cmbIdProveedor.Tag = "fk_id_proveedor";
            this.cmbIdProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbIdProveedor_SelectedIndexChanged);
            this.cmbIdProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIdProveedor_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(168, 285);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(181, 29);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.Tag = "correo_correo_proveedor";
            this.txtCorreo.TextChanged += new System.EventHandler(this.tctCorreo_TextChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmbEstado.Location = new System.Drawing.Point(168, 333);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(181, 28);
            this.cmbEstado.TabIndex = 8;
            this.cmbEstado.Tag = "estado_correo_proveedor";
            this.cmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstado_KeyPress);
            // 
            // dgvCorreoProveedor
            // 
            this.dgvCorreoProveedor.AllowUserToDeleteRows = false;
            this.dgvCorreoProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorreoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorreoProveedor.Location = new System.Drawing.Point(408, 161);
            this.dgvCorreoProveedor.Name = "dgvCorreoProveedor";
            this.dgvCorreoProveedor.ReadOnly = true;
            this.dgvCorreoProveedor.RowHeadersWidth = 51;
            this.dgvCorreoProveedor.RowTemplate.Height = 24;
            this.dgvCorreoProveedor.Size = new System.Drawing.Size(977, 332);
            this.dgvCorreoProveedor.TabIndex = 9;
            // 
            // cmbMostrar
            // 
            this.cmbMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMostrar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMostrar.FormattingEnabled = true;
            this.cmbMostrar.Location = new System.Drawing.Point(229, 237);
            this.cmbMostrar.Name = "cmbMostrar";
            this.cmbMostrar.Size = new System.Drawing.Size(120, 28);
            this.cmbMostrar.TabIndex = 10;
            this.cmbMostrar.SelectedIndexChanged += new System.EventHandler(this.cmbMostrar_SelectedIndexChanged);
            // 
            // frmCorreoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 540);
            this.Controls.Add(this.cmbMostrar);
            this.Controls.Add(this.dgvCorreoProveedor);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.cmbIdProveedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblIdProveedor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCorreoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2309 - Mantenimiento de Correo Proveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCorreoProveedor_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreoProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbIdProveedor;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvCorreoProveedor;
        private System.Windows.Forms.ComboBox cmbMostrar;
    }
}