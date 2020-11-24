/*
 El siguiente formulario es un Mantenimiento con respecto a la tabla Bodega
 */
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

namespace CapaVistaModuloSCM.Mantenimientos.Bodega
{
    public partial class frmBodega : Form
    {
        //Variables Globales
        string UsuarioAplicacion;
        static Form FormularioPadre;
        clsConexion con = new clsConexion();
        public frmBodega(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            //Cargar Datos de Municipio a Combo
            cargarMunicipio();
            //Tooltips
            tltToolTip.SetToolTip(txtCodigo, "Código de los Datos a Ingresar");
            tltToolTip.SetToolTip(txtDescripcion, "Ingrese la Descripción");
            tltToolTip.SetToolTip(txtDimension, "Ingrese las Dimensiones");
            tltToolTip.SetToolTip(txtDireccion, "Ingrese la Dirección");
            tltToolTip.SetToolTip(txtTelefono, "Ingrese el Teléfono");
            tltToolTip.SetToolTip(cmbEstado, "Seleccione el Estado: 1 Es Activo y 0 Inactivo");
            tltToolTip.SetToolTip(cmbMunicipio, "Seleccione el Municipio");
            tltToolTip.SetToolTip(cmbNombre, "Se visualiza el nombre del Municipio, puede seleccionar una opción y verá su respectivo código");
        }
        //Metodo para cargar datos al combo
        private void cargarMunicipio()
        {
            try
            {
                string Municipio = "SELECT * FROM MUNICIPIO";
                OdbcCommand comando = new OdbcCommand(Municipio, con.conexion());
                OdbcDataReader mostrarMuni = comando.ExecuteReader();
                while (mostrarMuni.Read())
                {
                    cmbMunicipio.Items.Add(mostrarMuni.GetInt32(0));
                    cmbNombre.Items.Add(mostrarMuni.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos al combo");
                Console.WriteLine(ex.Message);
            }
        }
        //Navegador
        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2313;
            navegador1.tbl = "bodega";
            navegador1.campoEstado = "estado_bodega";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if (C.Tag != null)
                {
                    if (C.Tag.ToString() == "saltar")
                    {

                    }
                    else
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
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvBodega;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm";
            navegador1.ruta = "Bodega.html";
        }
        //Cerrar la ventana
        private void frmBodega_FormClosing(object sender, FormClosingEventArgs e)
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
        //Validar el indice de combo
        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNombre.SelectedIndex = cmbMunicipio.SelectedIndex;
        }
        //Validar indice de combo
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.SelectedIndex = cmbNombre.SelectedIndex;
        }

        private void txtDimension_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.MaxLength = 10;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.MaxLength = 45;
        }

        private void txtDimension_TextChanged(object sender, EventArgs e)
        {
            txtDimension.MaxLength = 7;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.MaxLength = 45;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 8;
        }
    }
}
