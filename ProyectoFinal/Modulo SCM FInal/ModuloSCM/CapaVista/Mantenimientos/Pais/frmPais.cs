using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.Mantenimientos
{
    public partial class frmPais : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;
        //llamadas cuando inicie el programa
        public frmPais(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2310; //el número de la aplicación
            navegador1.tbl = "pais"; // llamada a la tabbla
            navegador1.campoEstado = "estado_pais"; // nombre de la columna estado de la tabla
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
            navegador1.DatosActualizar = dgvPais; // nombre del datagridview
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm"; // aquí se debe colocar la carpeta y el archivo.chm
            navegador1.ruta = "Pais.html"; // nombre del archivo.html


        }

        private void txtNombre_MouseHover(object sender, EventArgs e)
        {
            tltAyuda.ToolTipTitle = "Nombre Pais"; // nombre principal
            tltAyuda.SetToolTip(txtNombre, "Ingrese Nombre del pais"); // descripción 
            tltAyuda.ToolTipIcon = ToolTipIcon.Info; // icono informativo 
        }

        private void txtCapital_MouseHover(object sender, EventArgs e)
        {
            tltAyuda.ToolTipTitle = "Capital Pais"; // nombre principal
            tltAyuda.SetToolTip(txtCapital, "Ingrese Capital del pais"); // descripción 
            tltAyuda.ToolTipIcon = ToolTipIcon.Info; // icono informativo 

        }

        private void cmbEstado_MouseHover(object sender, EventArgs e)
        {
            tltAyuda.ToolTipTitle = "Estado Pais"; // nombre principal
            tltAyuda.SetToolTip(cmbEstado, "Seleccione estado 1:Activo 0:inactivo"); // descripción 
            tltAyuda.ToolTipIcon = ToolTipIcon.Info; // icono informativo 
        }

        private void frmPais_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 40;
        }

        private void txtCapital_TextChanged(object sender, EventArgs e)
        {
            txtCapital.MaxLength = 40;
        }
    }
}
