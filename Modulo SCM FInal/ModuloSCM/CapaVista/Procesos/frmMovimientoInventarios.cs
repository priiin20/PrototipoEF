/*
 *Formulario de Gestión de Movimientos de Inventarios 
 */
using CapaControladorModuloSCM.ControlProcesos;
using CapaModeloModuloSCM;
using CapaModeloModuloSCM.ClasesProcesos;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaModuloSCM.Procesos
{
    public partial class frmMovimientoInventarios : Form
    {
        //Variables Globales
        private clsConexion conexion = new clsConexion();
        private clsControladorMovimientosInventarios movimientosInventarios = new clsControladorMovimientosInventarios();
        private clsDetalleMovimiento detalleMovimiento;
        private clsMantenimientoInventario mantenimientoInventario;
        private int tipoMovimiento;
        private int? auxRuta, auxVehiculo, noDocu;
        public frmMovimientoInventarios()
        {
            InitializeComponent();
            bloquearComponentes(1);
            cargarRutas();
            cargarTipoMovimientos();
            cargarVehiculos();
            txtNoInventario.Text= movimientosInventarios.generarID("movimiento_inventario", "pk_id_movimiento_inventario").ToString();
        }
        //Validat Ingreso de Datos
        private bool validarCamposIngreso()
        {
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo de Movimiento", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTipo.Focus();
                return false;
            }
            else if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese Descripcion", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return false;
            }
            if (tipoMovimiento == 1||tipoMovimiento==2||tipoMovimiento==3)
            {
                if (cmbDocuAsociado.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione Documento Asociado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbDocuAsociado.Focus();
                    return false;
                }
            }else if (tipoMovimiento == 4 || tipoMovimiento == 5)
            {
                if (cmbRuta.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione Ruta", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbRuta.Focus();
                    return false;
                }
                else if (cmbVehiculo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione Vehiculo", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbVehiculo.Focus();
                    return false;
                }
            }
            return true;
        }
        //Bloqueo de Componentes
        private void bloquearComponentes(int habilitacionNo)
        {
            if (habilitacionNo == 1)
            {
                cmbRuta.Enabled = false;
                cmbVehiculo.Enabled = false;
                cmbDocuAsociado.Enabled = true;
                dgvMovimiento.Enabled = false;
            }
            else
            {
                cmbRuta.Enabled = true;
                cmbVehiculo.Enabled = true;
                cmbDocuAsociado.Enabled = false;
                dgvMovimiento.Enabled = true;
            }
        }
        //Cargar Rutas
        private void cargarRutas()
        {
            cmbRuta.ValueMember = "pk_id_ruta";
            cmbRuta.DisplayMember = "descripcion_ruta";
            cmbRuta.DataSource = movimientosInventarios.obtenerCamposCombobox("pk_id_ruta", "descripcion_ruta", "ruta", "estado_ruta");
            cmbRuta.Refresh();
            cmbRuta.SelectedIndex = -1;
        }
        //Cargar Tipos de Movimientos
        private void cargarTipoMovimientos()
        {
            cmbTipo.ValueMember = "pk_id_tipo_movimiento";
            cmbTipo.DisplayMember = "nombre_tipo_movimiento";
            cmbTipo.DataSource = movimientosInventarios.obtenerCamposCombobox("pk_id_tipo_movimiento", "nombre_tipo_movimiento", "tipo_movimiento", "estado_tipo_movimiento");
            cmbTipo.Refresh();
            cmbTipo.SelectedIndex = -1;
        }
        //Cargar datos de Vehiculos
        private void cargarVehiculos()
        {
            cmbVehiculo.ValueMember = "pk_id_vehiculo";
            cmbVehiculo.DisplayMember = "placa_vehiculo";
            cmbVehiculo.DataSource = movimientosInventarios.obtenerCamposCombobox("pk_id_vehiculo", "placa_vehiculo", "vehiculo", "estado_vehiculo");
            cmbVehiculo.Refresh();
            cmbVehiculo.SelectedIndex = -1;
        }
        //Obtiene la ruta
        private void cmbRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] ruta_campos = new string[2];
            if (cmbRuta.SelectedIndex > -1)
            {
                int indice = int.Parse(cmbRuta.SelectedValue.ToString());
                auxRuta = indice;
                ruta_campos[0]= movimientosInventarios.obtenerCamposRuta(indice)[0];
                ruta_campos[1] = movimientosInventarios.obtenerCamposRuta(indice)[1];
                txtOrigen.Text = ruta_campos[0];
                txtDestino.Text = ruta_campos[1];
            }
            else
            {
                txtDestino.Text = "";
                txtOrigen.Text = "";
            }
        }
        //Llena datos para movimiento encabezado
        private clsMantenimientoInventario llenarCamposEncabezado(int? Ruta, int? Vehiculo, int? Docu)
        {
            if (validarCamposIngreso() == true)
            {
                DateTime dtFecha = dtpFechaMovimiento.Value;
                clsMantenimientoInventario auxMantenimiento = new clsMantenimientoInventario();
                auxMantenimiento.IdMovimiento = int.Parse(txtNoInventario.Text);
                auxMantenimiento.IdTipoMovimiento = int.Parse(cmbTipo.SelectedValue.ToString());
                auxMantenimiento.IdRuta = Ruta;
                auxMantenimiento.IdVehiculo = Vehiculo;
                auxMantenimiento.Fecha1 = dtFecha;
                auxMantenimiento.DocuAsociado = Docu;
                auxMantenimiento.Descripcion1 = txtDescripcion.Text;
                return auxMantenimiento;
            }
            else return null;
        }
        //Llena datos para movimiento detalle
        private clsDetalleMovimiento llenarCamposDetalle(int Producto, int Cantidad)
        {
            clsDetalleMovimiento auxMantenimiento = new clsDetalleMovimiento();
            auxMantenimiento.IdDetalle = movimientosInventarios.generarID("movimiento_inventario_detalle", "pk_id_movimiento_inventario_detalle");
            auxMantenimiento.IdMovimiento = int.Parse(txtNoInventario.Text);
            auxMantenimiento.IdProducto = Producto;
            auxMantenimiento.Cantidad1 = Cantidad;
            return auxMantenimiento;
        }
        //Obtener Documento asociado
        private void cmbDocuAsociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDocuAsociado.SelectedIndex > -1)
            {
                noDocu = int.Parse(cmbDocuAsociado.SelectedValue.ToString());
                dgvMovimiento.DataSource = null;
                if (tipoMovimiento == 1)
                {
                    dgvMovimiento.DataSource = movimientosInventarios.obtenerDetalles("fk_id_producto as 'Producto'", "cantidad_compra_detalle as 'Cantidad'", "compra_detalle", "fk_id_compra_encabezado", noDocu, "estado_compra_detalle");
                }else if (tipoMovimiento==2)
                {
                    dgvMovimiento.DataSource = movimientosInventarios.obtenerDetalles("fk_id_producto as 'Producto'", "cantidad as 'Cantidad'", "detalle_factura", "fk_id_factura", noDocu, "");
                }                
                else if (tipoMovimiento == 3)
                {
                    dgvMovimiento.DataSource = movimientosInventarios.obtenerDetalles("fk_id_producto as 'Producto'", "cantidad_pedido_detalle as 'Cantidad'", "pedido_detalle", "fk_id_pedido_encabezado", noDocu, "estado_pedido_detalle");
                }

            }
        }
        //Ingreso de Datos
        private bool guardarDatos()
        {
            int CodLinea = 0, Producto, Cantidad;
            try
            {
                this.mantenimientoInventario = llenarCamposEncabezado(auxRuta,auxVehiculo,noDocu);
                if (mantenimientoInventario == null)
                {
                    MessageBox.Show("Ingrese Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    movimientosInventarios.insertarEncabezadoMovimientos(mantenimientoInventario);
                    int iFilas = dgvMovimiento.Rows.Count;
                    //Linea por linea del grid inserta a detalle movimiento
                    while (CodLinea < (iFilas - 1))
                    {
                        Producto = int.Parse(dgvMovimiento.Rows[CodLinea].Cells["Producto"].Value.ToString());
                        Cantidad = int.Parse(dgvMovimiento.Rows[CodLinea].Cells["Cantidad"].Value.ToString());
                        ++CodLinea;
                        this.detalleMovimiento = llenarCamposDetalle(Producto, Cantidad);
                        movimientosInventarios.insertarDetalleMovimiento(detalleMovimiento, tipoMovimiento,noDocu);
                    }
                    MessageBox.Show("Datos de Movimiento de Inventario Ingresados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Movimiento Exitosa");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Compra Fallida");
                MessageBox.Show("Error al Guardar Datos de Compras", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Obtener Tipo de Movimiento
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedValue!=null&&cmbTipo.SelectedIndex>-1)
            {
                tipoMovimiento = int.Parse(cmbTipo.SelectedValue.ToString());
                if (tipoMovimiento == 1)//COMPRA
                {
                    bloquearComponentes(1);
                    cmbDocuAsociado.DataSource = null;
                    cmbDocuAsociado.ValueMember = "pk_id_compra_encabezado";
                    cmbDocuAsociado.DisplayMember = "pk_id_compra_encabezado";
                    cmbDocuAsociado.DataSource = movimientosInventarios.obtenerNoCompraPedido("pk_id_compra_encabezado", "compra_encabezado", "estado_encabezado_compra", "estado_proceso_encabezado_compra");
                    cmbDocuAsociado.Refresh();
                    cmbDocuAsociado.SelectedIndex = -1;
                    auxRuta = null;
                    auxVehiculo = null;
                    VaciarGrid();
                    LimpiarTraslados();
                }
                else if (tipoMovimiento == 2)//VENTA
                {
                    bloquearComponentes(1);
                    cmbDocuAsociado.DataSource = null;
                    cmbDocuAsociado.ValueMember = "pk_id_compra_encabezado";
                    cmbDocuAsociado.DisplayMember = "pk_id_compra_encabezado";
                    cmbDocuAsociado.DataSource = movimientosInventarios.obtenerNoCompraPedido("pk_id_factura", "facturas", "", "");
                    cmbDocuAsociado.Refresh();
                    cmbDocuAsociado.SelectedIndex = -1;
                    auxRuta = null;
                    auxVehiculo = null;
                    VaciarGrid();
                    LimpiarTraslados();
                }
                else if (tipoMovimiento == 3 )//PEDIDOS
                {
                    bloquearComponentes(1);
                    cmbDocuAsociado.DataSource = null;
                    cmbDocuAsociado.ValueMember = "pk_id_pedido_encabezado";
                    cmbDocuAsociado.DisplayMember = "pk_id_pedido_encabezado";
                    cmbDocuAsociado.DataSource = movimientosInventarios.obtenerNoCompraPedido("pk_id_pedido_encabezado", "pedido_encabezado", "estado_pedido_encabezado", "estado_proceso_pedido_encabezado");
                    cmbDocuAsociado.Refresh();
                    cmbDocuAsociado.SelectedIndex = -1;
                    auxRuta = null;
                    auxVehiculo = null;
                    VaciarGrid();
                    LimpiarTraslados();
                }
                else if (tipoMovimiento == 4 || tipoMovimiento==5)//TRASLADOS
                {
                    bloquearComponentes(2);
                    dgvMovimiento.Enabled = true;
                    cmbDocuAsociado.SelectedIndex = -1;
                    noDocu = null;
                    VaciarGrid();
                    GenerarGrid();
                }
            }
            else
            {
                cmbDocuAsociado.DataSource = null;
            }
        }
        //Limpiar Todos los componentes
        private void limpiarTodo()
        {
            DateTime fechaAux = DateTime.Now;
            cmbDocuAsociado.SelectedIndex = -1;
            dtpFechaMovimiento.Value = fechaAux;
            LimpiarTraslados();
            txtDescripcion.Text = "";
            cmbTipo.SelectedIndex = -1;
            VaciarGrid();
        }
        //Limpiar Traslados  de Rutas
        private void LimpiarTraslados()
        {
            cmbRuta.SelectedIndex = -1;
            cmbVehiculo.SelectedIndex = -1;
        }
        //Vaciar el Grid
        private void VaciarGrid()
        {
            dgvMovimiento.ReadOnly = true;
            dgvMovimiento.Columns.Clear();
            dgvMovimiento.DataSource = null;
        }
        //Validar Datos Grid
        private void dgvMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvMovimiento.CurrentCell.ColumnIndex == 1)
            {
                char caracter = e.KeyChar;
                if (!char.IsNumber(caracter) && caracter != 8)
                    e.Handled = true;
            }
        }
        //Habilitar la validacion
        private void dgvMovimiento_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvMovimiento.CurrentCell.ColumnIndex == 1)
            {
                TextBox txtAux = e.Control as TextBox;
                if (txtAux != null)
                {
                    txtAux.KeyPress -= new KeyPressEventHandler(dgvMovimiento_KeyPress);
                    txtAux.KeyPress += new KeyPressEventHandler(dgvMovimiento_KeyPress);
                }
            }
        }
        //Vehiculo obtener
        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehiculo.SelectedIndex>-1&&cmbVehiculo.Enabled==true)
            {
                auxVehiculo = int.Parse(cmbVehiculo.SelectedValue.ToString());
            }
        }
        //Salida de formulario
        private void frmMovimientoInventarios_FormClosing(object sender, FormClosingEventArgs e)
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
        //Maximo de caracteres
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.MaxLength = 50;
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasModuloSCM/AyudasSCMASII.chm", "MovimientoInventarios.html");
        }

        //Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (guardarDatos() == true)
            {
                limpiarTodo();
                txtNoInventario.Text = movimientosInventarios.generarID("movimiento_inventario", "pk_id_movimiento_inventario").ToString();
            }
            else
            {
                limpiarTodo();
            }
        }
        //Generar grid de rutas
        private void GenerarGrid()
        {
            dgvMovimiento.ReadOnly = false;
            DataGridViewComboBoxColumn columnaProducto = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn columnaCantidad = new DataGridViewTextBoxColumn();
            columnaProducto.HeaderText = "Productos";
            columnaProducto.Name = "Producto";
            dgvMovimiento.Columns.Add(columnaProducto);
            columnaCantidad.HeaderText = "Cantidad";
            columnaCantidad.Name = "Cantidad";
            dgvMovimiento.Columns.Add(columnaCantidad);
            columnaProducto.ValueMember = "pk_id_producto";
            columnaProducto.DisplayMember = "nombre_producto";
            columnaProducto.DataSource = movimientosInventarios.obtenerCamposCombobox("pk_id_producto", "nombre_producto", "producto", "estado_producto");
        }
    }
}
