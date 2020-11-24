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

namespace CapaVistaModuloSCM.Mantenimientos.Municipio
{
    public partial class frmMunicipio : Form
    {
        //variables para el navegador
        string UsuarioAplicacion;
        static Form FormularioPadre;
        clsConexion conexion = new clsConexion();

        public frmMunicipio(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            
            //proceso para obtener los datos del departamento
            Procdepartamento();

            // tooltips de ayuda
            tltAyuda.SetToolTip(txtCodigo, "Código de ingreso");
            tltAyuda.SetToolTip(txtDescripcion, "Ingrese una descripcion");
            tltAyuda.SetToolTip(txtNombre, "Ingrese un nombre para la categoria de producto");
            tltAyuda.SetToolTip(cmbEstado, "Ingrese el estado como valor 1 ");
            tltAyuda.SetToolTip(cmbIdDepartamento, "Seleccione el numero del Departamento");
            tltAyuda.SetToolTip(cmbNombreDepartamento, "Seleccione el nombre del Departamento");
        }


        //consulta para obtener el id y nombre del departamento
        void Procdepartamento()
        {
            try
            {
                string departamento = "Select * from DEPARTAMENTO ";
                OdbcCommand comm = new OdbcCommand(departamento, conexion.conexion());
                OdbcDataReader mostrarDep = comm.ExecuteReader();

                while (mostrarDep.Read())
                {
                    cmbIdDepartamento.Items.Add(mostrarDep.GetInt32(0));
                    cmbNombreDepartamento.Items.Add(mostrarDep.GetString(1));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Prueba");
            }

        }

     
        //funcion para el navegador
        private void navegador1_Load(object sender, EventArgs e)
        {

            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 2305;
            navegador1.tbl = "municipio";
            navegador1.campoEstado = "estado_municipio";
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
                //  MessageBox.Show(""+C.Name)

            }
            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvMunicipio;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm";
            navegador1.ruta = "Municipio.html";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //funciones para mostrar los datos del depatartamento en los combobox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNombreDepartamento.SelectedIndex = cmbIdDepartamento.SelectedIndex;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdDepartamento.SelectedIndex = cmbNombreDepartamento.SelectedIndex;
        }

        //funciones para solo dejar usar letras o numeros
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cCaracter = e.KeyChar;
            if (!char.IsLetter(cCaracter) && cCaracter != 8 && cCaracter != 32)
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

        private void frmMunicipio_FormClosing(object sender, FormClosingEventArgs e)
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
            txtNombre.MaxLength = 30;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.MaxLength = 45;
        }
    }
}

