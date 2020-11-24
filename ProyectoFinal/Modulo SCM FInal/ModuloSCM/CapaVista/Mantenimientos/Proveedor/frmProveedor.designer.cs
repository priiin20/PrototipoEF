namespace CapaVistaModuloSCM.Mantenimientos
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblRazon = new System.Windows.Forms.Label();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tltAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.cmbMostrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(4, 4);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 116);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(89, 171);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 21);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(89, 216);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(52, 21);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "Pais:";
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazon.Location = new System.Drawing.Point(89, 271);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(126, 21);
            this.lblRazon.TabIndex = 3;
            this.lblRazon.Text = "Razon Social:";
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepresentante.Location = new System.Drawing.Point(89, 334);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(144, 21);
            this.lblRepresentante.TabIndex = 4;
            this.lblRepresentante.Text = "Representante:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(93, 382);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(42, 21);
            this.lblNit.TabIndex = 5;
            this.lblNit.Text = "Nit:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(93, 437);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 21);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(257, 171);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(191, 29);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.Tag = "pk_id_proveedor";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.Enabled = false;
            this.cmbPais.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(257, 216);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(64, 28);
            this.cmbPais.TabIndex = 8;
            this.cmbPais.Tag = "fk_id_pais";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            this.cmbPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPais_KeyPress);
            this.cmbPais.MouseHover += new System.EventHandler(this.cmbPais_MouseHolver);
            // 
            // txtRazon
            // 
            this.txtRazon.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazon.Location = new System.Drawing.Point(257, 270);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(191, 29);
            this.txtRazon.TabIndex = 9;
            this.txtRazon.Tag = "razon_social_proveedor";
            this.txtRazon.TextChanged += new System.EventHandler(this.txtRazon_TextChanged);
            this.txtRazon.MouseHover += new System.EventHandler(this.txtRazon_MouseHolver);
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepresentante.Location = new System.Drawing.Point(257, 333);
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(191, 29);
            this.txtRepresentante.TabIndex = 10;
            this.txtRepresentante.Tag = "representante_legal_proveedor";
            this.txtRepresentante.TextChanged += new System.EventHandler(this.txtRepresentante_TextChanged);
            this.txtRepresentante.MouseHover += new System.EventHandler(this.txtRepresentante_MouseHover);
            // 
            // txtNit
            // 
            this.txtNit.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNit.Location = new System.Drawing.Point(257, 382);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(191, 29);
            this.txtNit.TabIndex = 11;
            this.txtNit.Tag = "nit_proveedor";
            this.txtNit.TextChanged += new System.EventHandler(this.txtNit_TextChanged);
            this.txtNit.MouseHover += new System.EventHandler(this.txtNit_MouseHover);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmbEstado.Location = new System.Drawing.Point(257, 437);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(191, 28);
            this.cmbEstado.TabIndex = 12;
            this.cmbEstado.Tag = "estado_proveedor";
            this.cmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstado_KeyPress);
            this.cmbEstado.MouseHover += new System.EventHandler(this.cmbEstado_MouseHover);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(551, 154);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(847, 365);
            this.dgvProveedor.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 124);
            this.panel1.TabIndex = 14;
            // 
            // cmbMostrar
            // 
            this.cmbMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMostrar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMostrar.FormattingEnabled = true;
            this.cmbMostrar.Location = new System.Drawing.Point(327, 216);
            this.cmbMostrar.Name = "cmbMostrar";
            this.cmbMostrar.Size = new System.Drawing.Size(121, 28);
            this.cmbMostrar.TabIndex = 15;
            this.cmbMostrar.SelectedIndexChanged += new System.EventHandler(this.cmbMostrar_SelectedIndexChanged);
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 540);
            this.Controls.Add(this.cmbMostrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.txtRepresentante);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.lblRepresentante);
            this.Controls.Add(this.lblRazon);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2307 - Mantenimiento de Proveedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProveedor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.Label lblRepresentante;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip tltAyuda;
        private System.Windows.Forms.ComboBox cmbMostrar;
    }
}