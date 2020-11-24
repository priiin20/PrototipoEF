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

    public partial class frmCorreoProveedor : Form
    {

        clsConexion cn = new clsConexion();
        string UsuarioAplicacion;
        static Form FormularioPadre;
        //llamadas cuando inicie el programa
        public frmCorreoProveedor(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            Proveedor();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2309; //el número de la aplicación
            navegador1.tbl = "correo_proveedor"; // llamada a la tabbla
            navegador1.campoEstado = "estado_correo_proveedor"; // nombre de la columna estado de la tabla
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
            navegador1.DatosActualizar = dgvCorreoProveedor;  // nombre del datagridview
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm"; // aquí se debe colocar la carpeta y el archivo.chm
            navegador1.ruta = "CorreoProveedor.html"; // nombre del archivo.html
        }

        void Proveedor()
        {
            try
            {
                string Proveedor = "SELECT * FROM PROVEEDOR";
                OdbcCommand comm = new OdbcCommand(Proveedor, cn.conexion());
                OdbcDataReader mostrarProv = comm.ExecuteReader();

                while (mostrarProv.Read())
                {
                    cmbIdProveedor.Items.Add(mostrarProv.GetInt32(0));
                    cmbMostrar.Items.Add(mostrarProv.GetString(2));
                }

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                MessageBox.Show("PRUEBA"); 
            }

            

        }

        private void cmbIdProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMostrar.SelectedIndex = cmbIdProveedor.SelectedIndex;
        }

        private void cmbMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdProveedor.SelectedIndex = cmbMostrar.SelectedIndex;
        }

        private void frmCorreoProveedor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmbIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tctCorreo_TextChanged(object sender, EventArgs e)
        {
            txtCorreo.MaxLength = 50;
        }
    }

}
