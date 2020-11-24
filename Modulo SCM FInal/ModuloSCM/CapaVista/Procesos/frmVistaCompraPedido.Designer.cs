namespace CapaVistaModuloSCM.Procesos
{
    partial class frmVistaCompraPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVistaCompraPedido));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.rbtnCompras = new System.Windows.Forms.RadioButton();
            this.rbtnPedido = new System.Windows.Forms.RadioButton();
            this.dgvVistaDatos = new System.Windows.Forms.DataGridView();
            this.rbtnInventario = new System.Windows.Forms.RadioButton();
            this.rbtnExistencias = new System.Windows.Forms.RadioButton();
            this.pnlSuperior.SuspendLayout();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlSuperior.Controls.Add(this.btnAyuda);
            this.pnlSuperior.Controls.Add(this.btnIngresar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1128, 125);
            this.pnlSuperior.TabIndex = 0;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1014, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(114, 125);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(0, 0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(317, 141);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar Compras y Pedidos";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.BackColor = System.Drawing.Color.White;
            this.pnlCuerpo.Controls.Add(this.rbtnExistencias);
            this.pnlCuerpo.Controls.Add(this.rbtnInventario);
            this.pnlCuerpo.Controls.Add(this.rbtnCompras);
            this.pnlCuerpo.Controls.Add(this.rbtnPedido);
            this.pnlCuerpo.Controls.Add(this.dgvVistaDatos);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 125);
            this.pnlCuerpo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(1128, 768);
            this.pnlCuerpo.TabIndex = 1;
            // 
            // rbtnCompras
            // 
            this.rbtnCompras.AutoSize = true;
            this.rbtnCompras.Location = new System.Drawing.Point(250, 36);
            this.rbtnCompras.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCompras.Name = "rbtnCompras";
            this.rbtnCompras.Size = new System.Drawing.Size(135, 24);
            this.rbtnCompras.TabIndex = 2;
            this.rbtnCompras.TabStop = true;
            this.rbtnCompras.Text = "Ver Compras";
            this.rbtnCompras.UseVisualStyleBackColor = true;
            this.rbtnCompras.CheckedChanged += new System.EventHandler(this.rbtnCompras_CheckedChanged);
            // 
            // rbtnPedido
            // 
            this.rbtnPedido.AutoSize = true;
            this.rbtnPedido.Location = new System.Drawing.Point(41, 36);
            this.rbtnPedido.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPedido.Name = "rbtnPedido";
            this.rbtnPedido.Size = new System.Drawing.Size(126, 24);
            this.rbtnPedido.TabIndex = 1;
            this.rbtnPedido.TabStop = true;
            this.rbtnPedido.Text = "Ver Pedidos";
            this.rbtnPedido.UseVisualStyleBackColor = true;
            this.rbtnPedido.CheckedChanged += new System.EventHandler(this.btnPedido_CheckedChanged);
            // 
            // dgvVistaDatos
            // 
            this.dgvVistaDatos.AllowUserToDeleteRows = false;
            this.dgvVistaDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVistaDatos.Location = new System.Drawing.Point(32, 88);
            this.dgvVistaDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVistaDatos.Name = "dgvVistaDatos";
            this.dgvVistaDatos.ReadOnly = true;
            this.dgvVistaDatos.RowHeadersWidth = 51;
            this.dgvVistaDatos.RowTemplate.Height = 24;
            this.dgvVistaDatos.Size = new System.Drawing.Size(1061, 590);
            this.dgvVistaDatos.TabIndex = 0;
            // 
            // rbtnInventario
            // 
            this.rbtnInventario.AutoSize = true;
            this.rbtnInventario.Location = new System.Drawing.Point(454, 38);
            this.rbtnInventario.Name = "rbtnInventario";
            this.rbtnInventario.Size = new System.Drawing.Size(110, 24);
            this.rbtnInventario.TabIndex = 3;
            this.rbtnInventario.TabStop = true;
            this.rbtnInventario.Text = "Inventario";
            this.rbtnInventario.UseVisualStyleBackColor = true;
            this.rbtnInventario.CheckedChanged += new System.EventHandler(this.rbtnInventario_CheckedChanged);
            // 
            // rbtnExistencias
            // 
            this.rbtnExistencias.AutoSize = true;
            this.rbtnExistencias.Location = new System.Drawing.Point(633, 38);
            this.rbtnExistencias.Name = "rbtnExistencias";
            this.rbtnExistencias.Size = new System.Drawing.Size(119, 24);
            this.rbtnExistencias.TabIndex = 4;
            this.rbtnExistencias.TabStop = true;
            this.rbtnExistencias.Text = "Existencias";
            this.rbtnExistencias.UseVisualStyleBackColor = true;
            this.rbtnExistencias.CheckedChanged += new System.EventHandler(this.rbtnExistencias_CheckedChanged);
            // 
            // frmVistaCompraPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 893);
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlSuperior);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVistaCompraPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2319 - Gestión de Compras y Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVistaCompraPedido_FormClosing);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlCuerpo.ResumeLayout(false);
            this.pnlCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVistaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.RadioButton rbtnCompras;
        private System.Windows.Forms.RadioButton rbtnPedido;
        private System.Windows.Forms.DataGridView dgvVistaDatos;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.RadioButton rbtnExistencias;
        private System.Windows.Forms.RadioButton rbtnInventario;
    }
}