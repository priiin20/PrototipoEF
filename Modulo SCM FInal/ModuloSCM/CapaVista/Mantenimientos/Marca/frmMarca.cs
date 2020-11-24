using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.Mantenimientos.Marca
{
    public partial class frmMarca : Form
    {
        //Variable Globales
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmMarca(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            //Tooltips
            tltToolTip.SetToolTip(txtCodigo, "Código de Ingreso de Datos");
            tltToolTip.SetToolTip(txtDescripcion, "Ingrese la Descripción de la Marca. Ej: Honda");
            tltToolTip.SetToolTip(cmbEstado, "Seleccione el Estado: 1 Es Activo y 0 Inactivo");
        }
        //Navegador
        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2311;
            navegador1.tbl = "marca";
            navegador1.campoEstado = "estado_marca";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
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
            navegador1.DatosActualizar = dgvMarcaVista;
            navegador1.procActualizarData();
            navegador1.procCargar();
           navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm";
            navegador1.ruta = "Marca.html";
        }
        //Cerrar Ventana
        private void frmMarca_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.MaxLength = 45;
        }
    }
}
