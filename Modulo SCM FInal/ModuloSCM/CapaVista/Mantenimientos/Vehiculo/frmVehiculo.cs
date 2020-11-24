/*
 Este formulario se encarga del mantenimiento de Vehiculo
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

namespace CapaVistaModuloSCM.Mantenimientos.Vehiculo
{
    public partial class frmVehiculo : Form
    {
        //Variables Globales
        string UsuarioAplicacion;
        static Form FormularioPadre;
        clsConexion con = new clsConexion();
        public frmVehiculo(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            cargarMarca();//Cargar Datos de Marca
            //Tooltips
            tltToolTip.SetToolTip(txtAnio, "Ingrese el Año del Vehículo");
            tltToolTip.SetToolTip(txtCodigo, "Código de los datos a Ingresar");
            tltToolTip.SetToolTip(txtColor, "Ingrese el Color del Vehículo");
            tltToolTip.SetToolTip(txtCombustible, "Ingrese el Tipo de Combustible del Vehículo");
            tltToolTip.SetToolTip(txtModelo, "Ingrese Modelo del Vehículo");
            tltToolTip.SetToolTip(txtPlaca, "Ingrese el Número de Placa");
            tltToolTip.SetToolTip(cmbMarca, "Seleccione la Marca del Vehículo, el nombre de la misma se mostrará en el componente debajo de este");
            tltToolTip.SetToolTip(cmbNombre, "Visualiza el Nombre de la Marca, puede seleccionar este para visualizar el Código del mismo");
            tltToolTip.SetToolTip(cmbEstado, "Seleccione el Estado: 1 Es Activo y 0 Inactivo");
        }
        //Cargar Datos de Marca
        private void cargarMarca()
        {
            try
            {
                string Marca = "SELECT * FROM MARCA";
                OdbcCommand comando = new OdbcCommand(Marca, con.conexion());
                OdbcDataReader mostrarMuni = comando.ExecuteReader();
                while (mostrarMuni.Read())
                {
                    cmbMarca.Items.Add(mostrarMuni.GetInt32(0));
                    cmbNombre.Items.Add(mostrarMuni.GetString(1));    
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
            navegador1.aplicacion = 2312;
            navegador1.tbl = "vehiculo";
            navegador1.campoEstado = "estado_vehiculo";
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
            navegador1.DatosActualizar = dgvVehiculo;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudasModuloSCM/AyudasSCMASII.chm";
            navegador1.ruta = "Vehiculo.html";
        }
        //Cerrar Ventana
        private void frmVehiculo_FormClosing(object sender, FormClosingEventArgs e)
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
        //Cambiar Indice
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = cmbNombre.SelectedIndex;
        }
        //Cambiar Indice
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNombre.SelectedIndex = cmbMarca.SelectedIndex;
        }

        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            txtPlaca.MaxLength = 45;
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            txtModelo.MaxLength = 45;
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            txtColor.MaxLength = 45;
        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {
            txtAnio.MaxLength = 45;
        }

        private void txtCombustible_TextChanged(object sender, EventArgs e)
        {
            txtCombustible.MaxLength = 45;
        }
    }
}
