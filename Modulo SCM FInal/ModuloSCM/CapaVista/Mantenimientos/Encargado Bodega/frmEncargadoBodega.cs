/*
 * Este formulario se encarga del mantenimiento de la tabla Encargado Bodega
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

namespace CapaVistaModuloSCM.Mantenimientos.Encargado_Bodega
{
    public partial class frmEncargadoBodega : Form
    {
        //Variables Globales
        string UsuarioAplicacion;
        static Form FormularioPadre;
        clsConexion con = new clsConexion();
        public frmEncargadoBodega(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            cargarBodega();//Cargar Datos al Combo
            cargarEmpleado();//Cargar Datos de Empleado al Combo
            //Tooltips
            tltToolTip.SetToolTip(txtCodigo, "Código de Ingreso");
            tltToolTip.SetToolTip(cmbBodega, "Seleccione la Bodega");
            tltToolTip.SetToolTip(cmbEmpleado, "Seleccione el Empleado");
            tltToolTip.SetToolTip(cmbNomBodega, "Visualiza el Nombre de la Bodega Seleccionada, puede seleccionar una bodega y visualizar su código en el componente superior"); ;
            tltToolTip.SetToolTip(cmbNomEmp, "Visualiza el Nombre del Empleado, seleccione y visualizará el código");
            tltToolTip.SetToolTip(cmbEstado, "Seleccione el Estado: 1 Es Activo y 0 Inactivo");
        }
        //Cargar Datos de Bodega
        private void cargarBodega()
        {
            try
            {
                string bodega = "SELECT * FROM BODEGA";
                OdbcCommand comando2 = new OdbcCommand(bodega, con.conexion());
                OdbcDataReader mostrarBodega = comando2.ExecuteReader();
                while (mostrarBodega.Read())
                {
                    cmbBodega.Items.Add(mostrarBodega.GetInt32(0));
                    cmbNomBodega.Items.Add(mostrarBodega.GetString(2));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos al combo");
                Console.WriteLine(ex.Message);
            }
        }
        //Cargar Datos de Empleado
        private void cargarEmpleado()
        {
            try
            {
                string bodega = "SELECT * FROM EMPLEADO";
                OdbcCommand comando2 = new OdbcCommand(bodega, con.conexion());
                OdbcDataReader mostrarBodega = comando2.ExecuteReader();
                while (mostrarBodega.Read())
                {
                    cmbEmpleado.Items.Add(mostrarBodega.GetInt32(0));
                    cmbNomEmp.Items.Add(mostrarBodega.GetString(1));
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
            navegador1.aplicacion = 2314;
            navegador1.tbl = "encargado_bodega";
            navegador1.campoEstado = "estado_encargado_bodega";
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
            navegador1.DatosActualizar = dgvEncargadoDatos;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm";
            navegador1.ruta = "EncargadoBodega.html";
        }
        //Cerrar Ventana
        private void frmEncargadoBodega_FormClosing(object sender, FormClosingEventArgs e)
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
        //Cambiar indice
        private void cmbNomEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEmpleado.SelectedIndex = cmbNomEmp.SelectedIndex;
        }
        //Cambiar indice
        private void cmbNomBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBodega.SelectedIndex = cmbNomBodega.SelectedIndex;
        }
        //Cambiar indice
        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNomEmp.SelectedIndex = cmbEmpleado.SelectedIndex;
        }
        //Cambiar indice
        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNomBodega.SelectedIndex = cmbBodega.SelectedIndex;
        }

        private void cmbEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8)
            {
                e.Handled = true;
            }
        }

        private void cmbBodega_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
