namespace CapaVistaModuloSCM.Mantenimientos.Encargado_Bodega
{
    partial class frmEncargadoBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEncargadoBodega));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblBodega = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvEncargadoDatos = new System.Windows.Forms.DataGridView();
            this.cmbNomEmp = new System.Windows.Forms.ComboBox();
            this.cmbNomBodega = new System.Windows.Forms.ComboBox();
            this.tltToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargadoDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlSuperior.Controls.Add(this.navegador1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1796, 142);
            this.pnlSuperior.TabIndex = 0;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(5, 5);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1767, 129);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(61, 189);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(61, 266);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(89, 20);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblBodega
            // 
            this.lblBodega.AutoSize = true;
            this.lblBodega.Location = new System.Drawing.Point(61, 388);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(68, 20);
            this.lblBodega.TabIndex = 3;
            this.lblBodega.Text = "Bodega";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(61, 493);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.Location = new System.Drawing.Point(168, 189);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 27);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Tag = "pk_id_encargado_bodega";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(168, 263);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 28);
            this.cmbEmpleado.TabIndex = 6;
            this.cmbEmpleado.Tag = "fk_id_empleado";
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            this.cmbEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEmpleado_KeyPress);
            // 
            // cmbBodega
            // 
            this.cmbBodega.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(168, 380);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(121, 28);
            this.cmbBodega.TabIndex = 7;
            this.cmbBodega.Tag = "fk_id_bodega";
            this.cmbBodega.SelectedIndexChanged += new System.EventHandler(this.cmbBodega_SelectedIndexChanged);
            this.cmbBodega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBodega_KeyPress);
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmbEstado.Location = new System.Drawing.Point(168, 485);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 28);
            this.cmbEstado.TabIndex = 8;
            this.cmbEstado.Tag = "estado_encargado_bodega";
            this.cmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstado_KeyPress);
            // 
            // dgvEncargadoDatos
            // 
            this.dgvEncargadoDatos.AllowUserToDeleteRows = false;
            this.dgvEncargadoDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncargadoDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncargadoDatos.Location = new System.Drawing.Point(452, 189);
            this.dgvEncargadoDatos.Name = "dgvEncargadoDatos";
            this.dgvEncargadoDatos.ReadOnly = true;
            this.dgvEncargadoDatos.RowHeadersWidth = 51;
            this.dgvEncargadoDatos.RowTemplate.Height = 24;
            this.dgvEncargadoDatos.Size = new System.Drawing.Size(880, 312);
            this.dgvEncargadoDatos.TabIndex = 9;
            // 
            // cmbNomEmp
            // 
            this.cmbNomEmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNomEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomEmp.FormattingEnabled = true;
            this.cmbNomEmp.Location = new System.Drawing.Point(168, 316);
            this.cmbNomEmp.Name = "cmbNomEmp";
            this.cmbNomEmp.Size = new System.Drawing.Size(155, 28);
            this.cmbNomEmp.TabIndex = 10;
            this.cmbNomEmp.SelectedIndexChanged += new System.EventHandler(this.cmbNomEmp_SelectedIndexChanged);
            // 
            // cmbNomBodega
            // 
            this.cmbNomBodega.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbNomBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomBodega.FormattingEnabled = true;
            this.cmbNomBodega.Location = new System.Drawing.Point(168, 425);
            this.cmbNomBodega.Name = "cmbNomBodega";
            this.cmbNomBodega.Size = new System.Drawing.Size(155, 28);
            this.cmbNomBodega.TabIndex = 11;
            this.cmbNomBodega.SelectedIndexChanged += new System.EventHandler(this.cmbNomBodega_SelectedIndexChanged);
            // 
            // tltToolTip
            // 
            this.tltToolTip.IsBalloon = true;
            this.tltToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmEncargadoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1796, 576);
            this.Controls.Add(this.cmbNomBodega);
            this.Controls.Add(this.cmbNomEmp);
            this.Controls.Add(this.dgvEncargadoDatos);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbBodega);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblBodega);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEncargadoBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 2314 -Mantenimiento de Encargado de Bodega";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEncargadoBodega_FormClosing);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncargadoDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvEncargadoDatos;
        private System.Windows.Forms.ComboBox cmbNomEmp;
        private System.Windows.Forms.ComboBox cmbNomBodega;
        private System.Windows.Forms.ToolTip tltToolTip;
    }
}