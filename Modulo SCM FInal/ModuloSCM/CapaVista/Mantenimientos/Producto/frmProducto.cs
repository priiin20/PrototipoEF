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

namespace CapaVistaModuloSCM.Mantenimientos.Producto
{
    public partial class frmProducto : Form
    {
        //variables para el navegador
        string UsuarioAplicacion;
        static Form FormularioPadre;
        clsConexion conexion = new clsConexion();


        public frmProducto(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            //procedimientos para cargar las tablas categoria y linea para el producto
            ProcCategoria();
            ProcLineaProducto();
            
            //tooltips, ayudas al usuario
            tltAyuda.SetToolTip(txtCodigo, "Código de ingreso");
            tltAyuda.SetToolTip(txtMedida, "Ingrese una medida");
            tltAyuda.SetToolTip(txtDescripcion, "Ingrese una descripcion");
            tltAyuda.SetToolTip(cmbEstado, "Ingrese el estado como valor 1 ");
            tltAyuda.SetToolTip(cmbIdcategoria, "Seleccione un numero de categoria para el producto");
            tltAyuda.SetToolTip(cmbCategoria, "Seleccione una categoria para el producto");
            tltAyuda.SetToolTip(cmbIdLineaProducto, "Seleccione un numero para la linea de producto");
            tltAyuda.SetToolTip(cmbLinea, "Seleccione una  linea de producto");
            tltAyuda.SetToolTip(txtPrecio, "Ingrese un precio al producto");
            tltAyuda.SetToolTip(txtNombre, "Ingrese un nombre para producto");

        }

        private void lblMedida_Click(object sender, EventArgs e)
        {

        }

        //Procedimiento para obtener datos de la categoria
        void ProcCategoria()
        {
            try
            {
                string categoria = "Select * from categoria_producto ";
                OdbcCommand comm = new OdbcCommand(categoria, conexion.conexion());
                OdbcDataReader mostrarCategoria = comm.ExecuteReader();

                while (mostrarCategoria.Read())
                {
                    cmbIdcategoria.Items.Add(mostrarCategoria.GetInt32(0));
                    cmbCategoria.Items.Add(mostrarCategoria.GetString(1));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prueba");
            }

        }

        //Procedimiento para obtener datos de la linea producto 
        void ProcLineaProducto()
        {
            try
            {
                string linea = "Select * from linea_producto ";
                OdbcCommand comm = new OdbcCommand(linea, conexion.conexion());
                OdbcDataReader mostrarLinea = comm.ExecuteReader();

                while (mostrarLinea.Read())
                {
                    cmbIdLineaProducto.Items.Add(mostrarLinea.GetInt32(0));
                    cmbLinea.Items.Add(mostrarLinea.GetString(1));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prueba");
            }

        }

        // funcion para el navegador 
        private void navegador1_Load(object sender, EventArgs e)
        {

            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2303;
            navegador1.tbl = "producto";
            navegador1.campoEstado = "estado_producto";
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
            navegador1.DatosActualizar = dgvProducto;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm";
            navegador1.ruta = "Producto.html";
        
        }

        //muestra el los datos de las tablas categoria y linea 
        private void cmbIdcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbCategoria.SelectedIndex = cmbIdcategoria.SelectedIndex;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdcategoria.SelectedIndex = cmbCategoria.SelectedIndex;
        }

        private void cmbIdLineaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLinea.SelectedIndex = cmbIdLineaProducto.SelectedIndex;
        }

        private void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdLineaProducto.SelectedIndex = cmbLinea.SelectedIndex;
        }


        // metodos para poder ingresar solo letras o numeros 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            char cCaracter = e.KeyChar;
            if (!char.IsLetterOrDigit(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetterOrDigit(cCaracter) && cCaracter != 8 && cCaracter != 32)
            {
                e.Handled = true;
            }
        }

        private void frmProducto_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmbIdLineaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsDigit(cCaracter) && cCaracter != 8)
            {
                e.Handled = true;
            }
        }

        private void cmbIdcategoria_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.MaxLength = 50;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.MaxLength = 12;
        }

        private void txtMedida_TextChanged(object sender, EventArgs e)
        {
            txtMedida.MaxLength = 5;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.MaxLength = 45;
        }
    }
}
