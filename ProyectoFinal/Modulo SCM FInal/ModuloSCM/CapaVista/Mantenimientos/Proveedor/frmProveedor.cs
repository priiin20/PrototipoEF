using CapaModeloModuloSCM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.Mantenimientos
{
    public partial class frmProveedor : Form
    {
        clsConexion cn = new clsConexion();
        string UsuarioAplicacion;
        static Form FormularioPadre;

        //llamadas cuando inicie el programa
        public frmProveedor(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            Pais();
        }

        //
        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2307; //el número de la aplicación
            navegador1.tbl = "proveedor"; // llamada a la tabbla
            navegador1.campoEstado = "estado_proveedor"; // nombre de la columna estado de la tabla
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals(""))) // para validar los tag
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvProveedor; // nombre del datagridview
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm"; // aquí se debe colocar la carpeta y el archivo.chm
            navegador1.ruta = "Proveedor.html"; // nombre del archivo.html
        }

        private void cmbPais_MouseHolver(object sender, EventArgs e)
        {
            tltAyuda.ToolTipTitle = "Pais Proveedor"; // nombre principal
            tltAyuda.SetToolTip(cmbPais, "Seleccione el pais del proveedor"); // descripción 
            tltAyuda.ToolTipIcon = ToolTipIcon.Info; // icono informativo 
        }

        private void txtRazon_MouseHolver(object sender, EventArgs e)
        {
            tltAyuda.ToolTipTitle = "Razon Social"; // nombre principal
            tltAyuda.SetToolTip(txtRazon, "Ingrese Razon social del Proveedor"); // descripción 
            tltAyuda.ToolTipIcon = ToolTipIcon.Info; // icono informativo 
        }

        private void txtRepresentante_MouseHover(object sender, EventArgs e)
        {
            tltAyuda.ToolTipTitle = "Representante Legal"; // nombre principal
            tltAyuda.SetToolTip(txtRepresentante, "Ingrese Representante Legal del Proveedor"); // descripción 
            tltAyuda.ToolTipIcon = ToolTipIcon.Info; // icono informativo 
        }

        private void txtNit_MouseHover(object sender, EventArgs e)
        {
            tltAyuda.ToolTipTitle = "Nit Proveedor"; // nombre principal
            tltAyuda.SetToolTip(txtNit, "Ingrese Nit del Proveedor"); // descripción 
            tltAyuda.ToolTipIcon = ToolTipIcon.Info; // icono informativo 
        }

        private void cmbEstado_MouseHover(object sender, EventArgs e)
        {
            tltAyuda.ToolTipTitle = "Estado del Proveedor"; // nombre principal
            tltAyuda.SetToolTip(cmbEstado, "Ingrese estado 1:activo , 0:Inactivo"); // descripción 
            tltAyuda.ToolTipIcon = ToolTipIcon.Info; // icono informativo 
        }
    
        // muestra os datos en los combobox
        void Pais()
        {
            try
            {
                string Proveedor = "SELECT * FROM PAIS";
                OdbcCommand comm = new OdbcCommand(Proveedor, cn.conexion());
                OdbcDataReader mostrarProv = comm.ExecuteReader();

                while (mostrarProv.Read())
                {
                    cmbPais.Items.Add(mostrarProv.GetInt32(0));
                    cmbMostrar.Items.Add(mostrarProv.GetString(1));
                }

            }
            catch (Exception ex) { }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMostrar.SelectedIndex = cmbPais.SelectedIndex;
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPais.SelectedIndex = cmbMostrar.SelectedIndex;
        }

        private void frmProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje = MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cmbPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8)
            {
                e.Handled = true;
            }
        }

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8)
            {
                e.Handled = true;
            }
        }

        private void txtRazon_TextChanged(object sender, EventArgs e)
        {
            txtRazon.MaxLength = 45;
        }

        private void txtRepresentante_TextChanged(object sender, EventArgs e)
        {
            txtRepresentante.MaxLength = 45;
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {
            txtNit.MaxLength = 20;
        }
    }
}
