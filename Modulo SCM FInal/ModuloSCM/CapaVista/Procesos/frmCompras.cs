/*
 Este formulario maneja el ingreso de órdenes de compras y pedidos
 */
using CapaControladorModuloSCM.ControlProcesos;
using CapaModeloModuloSCM;
using CapaModeloModuloSCM.ClasesProcesos;
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

namespace CapaVistaModuloSCM.Procesos
{
    public partial class frmCompras : Form
    {
        //Variables Globales
        private clsControladorGestionCompraPedido controladorCompras = new clsControladorGestionCompraPedido();
        private clsCompraEncabezado compraEncabezado;
        private clsCompraDetalle compraDetalle;
        private clsPedidoEncabezado pedidoEncabezado;
        private clsPedidoDetalle pedidoDetalle;
        private clsConexion conexion=new clsConexion();
        private int IDProducto, Cantidad, estadoProceso;
        private double Precio, SubTotal, TotalValor;
        public frmCompras()
        {
            InitializeComponent();
            BloquearComponentes();
            cmbEstadoProceso.SelectedIndex = 0;
            //Tooltips
            tltToolTip.SetToolTip(rbtnCompra, "Habilita Ingreso de Órden de Compra");
            tltToolTip.SetToolTip(rbtnPedido, "Habilita Ingreso de Órden de Pedidos a Fábrica");
            tltToolTip.SetToolTip(btnGuardar, "Ingrese los Datos de la Órden");            
        }
        //Bloquea componentes
        private void BloquearComponentes()
        {
            dgvCompras.Enabled = false;
            dtpFechaCompra.Enabled = false;
            cmbProveedor.Enabled = false;
            lblValorTotal.Visible = false;
            cmbEstadoProceso.Enabled = false;
        }

        //Carga datos al combobox producto, dentro del grid y fuera de el para compras
        private void cargarProductos_Proveedor()
        {
            cmbProducto.ValueMember = "pk_id_producto";
            cmbProducto.DisplayMember = "nombre_producto";
            cmbProducto.DataSource = controladorCompras.obtenerDatos("pk_id_producto", "nombre_producto", "producto","estado_producto");
            cmbProveedor.ValueMember = "pk_id_proveedor";
            cmbProveedor.DisplayMember = "razon_social_proveedor";
            cmbProveedor.DataSource = controladorCompras.obtenerDatos("pk_id_proveedor", "razon_social_proveedor", "proveedor", "estado_proveedor");
            cmbProveedor.Refresh();
            cmbProveedor.SelectedIndex = -1;
        }
        //Carga datos al combobox producto, dentro del grid y fuera de el para pedido
        private void cargarProductos_Fabrica()
        {
            cmbProducto.ValueMember = "pk_id_producto";
            cmbProducto.DisplayMember = "nombre_producto";
            cmbProducto.DataSource = controladorCompras.obtenerDatos("pk_id_producto", "nombre_producto", "producto", "estado_producto");
            cmbProveedor.ValueMember = "pk_id_fabrica";
            cmbProveedor.DisplayMember = "descripcion_fabrica";
            cmbProveedor.DataSource = controladorCompras.obtenerDatos("pk_id_fabrica", "descripcion_fabrica", "fabrica", "estado_fabrica");
            cmbProveedor.Refresh();
            cmbProveedor.SelectedIndex = -1;
        }
        //Llena datos para compra encabezado
        private clsCompraEncabezado llenarCamposCompraEncabezado(double Total)
        {
            if (validarEncabezado() == true)
            {
                DateTime dtFecha = dtpFechaCompra.Value;
                clsCompraEncabezado auxMantenimiento = new clsCompraEncabezado();
                auxMantenimiento.IdCompra = int.Parse(txtCodigo.Text);
                auxMantenimiento.IdProveedor = int.Parse(cmbProveedor.SelectedValue.ToString());
                auxMantenimiento.EstadoProceso = estadoProceso;
                auxMantenimiento.FechaCompra1 = dtFecha;
                auxMantenimiento.TotalCompra = Total;
                auxMantenimiento.Estado1 = 1;
                return auxMantenimiento;
            }
            else
                return null;
            
        }
        //Llena datos para compra detalle
        private clsCompraDetalle llenarCamposCompraDetalle(int Producto, int CodLinea, int Cantidad, double PrecioU, double SubTotal)
        {
            clsCompraDetalle auxMantenimiento = new clsCompraDetalle();
            auxMantenimiento.IdCompra = int.Parse(txtCodigo.Text);
            auxMantenimiento.IdProducto = Producto;
            auxMantenimiento.CodLinea = CodLinea;
            auxMantenimiento.Cantidad1 = Cantidad;
            auxMantenimiento.PrecioUnitario = PrecioU;
            auxMantenimiento.SubTotal = SubTotal;
            auxMantenimiento.Estado1 = 1;
            return auxMantenimiento;
        }
        //Llena datos para pedido encabezado
        private clsPedidoEncabezado llenarCamposPedidoEncabezado(double Total)
        {
            if (validarEncabezado() == true)
            {
                DateTime dtFecha = dtpFechaCompra.Value;
                clsPedidoEncabezado auxMantenimiento = new clsPedidoEncabezado();
                auxMantenimiento.IdPedido = int.Parse(txtCodigo.Text);
                auxMantenimiento.IdFabrica = int.Parse(cmbProveedor.SelectedValue.ToString());
                auxMantenimiento.EstadoProceso = estadoProceso;
                auxMantenimiento.FechaPedido1 = dtFecha;
                auxMantenimiento.TotalPedido = Total;
                auxMantenimiento.Estado1 = 1;
                return auxMantenimiento;
            }
            else 
                return null;
        }
        //Llena datos para pedido detalle
        private clsPedidoDetalle llenarCamposPedidoDetalle(int Producto, int CodLinea, int Cantidad, double PrecioU, double SubTotal)
        {
            clsPedidoDetalle auxMantenimiento = new clsPedidoDetalle();
            auxMantenimiento.IdPedido = int.Parse(txtCodigo.Text);
            auxMantenimiento.IdProducto = Producto;
            auxMantenimiento.CodLinea = CodLinea;
            auxMantenimiento.Cantidad1 = Cantidad;
            auxMantenimiento.PrecioUnitario = PrecioU;
            auxMantenimiento.SubTotal = SubTotal;
            auxMantenimiento.Estado1 = 1;
            return auxMantenimiento;
        }
        //Verifica si el radiobutton es compra para habilitar los campos y el grid
        private void rbtnCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCompra.Checked == true)
            {
                cmbProveedor.DataSource = null;
                cmbProveedor.Items.Clear();
                txtCodigo.Text = controladorCompras.generarID("compra_encabezado", "pk_id_compra_encabezado").ToString();
                lblProvFab.Text = "Proveedor";
                cargarProductos_Proveedor();
                LimpiaHabilitaRadio();
            }
        }
        //Verifica si el radiobutton es pedido para habilitar los campos y el grid
        private void rbtnPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPedido.Checked == true)
            {
                cmbProveedor.DataSource = null;
                cmbProveedor.Items.Clear();
                txtCodigo.Text = controladorCompras.generarID("pedido_encabezado", "pk_id_pedido_encabezado").ToString();
                lblProvFab.Text = "Fabrica";
                cargarProductos_Fabrica();
                LimpiaHabilitaRadio();
            }
        }
        private bool validarEncabezado()
        {
            if (cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el proveedor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbProveedor.Focus();
                return false;
            }else if (cmbEstadoProceso.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione el estado del proceso", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbEstadoProceso.Focus();
                return false;
            }
            return true;
        }
        private void LimpiaHabilitaRadio()
        {
            dgvCompras.Enabled = true;
            dtpFechaCompra.Enabled = true;
            cmbProveedor.Enabled = true;
            cmbEstadoProceso.Enabled = true;
            lblValorTotal.Visible = true;
            cmbProveedor.SelectedIndex = -1;
            dtpFechaCompra.Value = DateTime.Now;
            cmbEstadoProceso.SelectedIndex = 0;
            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                row.Cells["cmbProducto"].Value = null;
                row.Cells["txtCantidad"].Value = null;
                row.Cells["txtPrecioUnitario"].Value = null;
                row.Cells["txtSubtotal"].Value = null;
            }
            dgvCompras.Rows.Clear();
            lblValorTotal.Text = "0";
        }
        //Datos Guardados
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbtnCompra.Checked == true)
            {
                if (RegistrarCompra() == true)
                {
                    LimpiarComponentes();
                }
            }else if (rbtnPedido.Checked == true)
            {
                if (RegistrarPedido() == true)
                {
                    LimpiarComponentes();
                }
            }
            
        }
        //Limpia componetes incluyendo grid
        private void LimpiarComponentes()
        {
            cmbProveedor.SelectedIndex = -1;
            txtCodigo.Text = "";
            dtpFechaCompra.Value = DateTime.Now;
            cmbEstadoProceso.SelectedIndex = 0;
            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                row.Cells["cmbProducto"].Value = null;
                row.Cells["txtCantidad"].Value = null;
                row.Cells["txtPrecioUnitario"].Value = null;
                row.Cells["txtSubtotal"].Value = null;
            }
            dgvCompras.Rows.Clear();
            rbtnCompra.Checked = false;
            rbtnPedido.Checked = false;
            lblValorTotal.Text = "0";
            BloquearComponentes();
        }
        //Realiza los cálculos de precio y subtotal cada vez que se ingresa y traslada a otra fila
        private void dgvCompras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCompras.Rows[e.RowIndex].Cells["cmbProducto"].Value != null)
                {
                    if (dgvCompras.Rows[e.RowIndex].Cells["txtCantidad"].Value != null)
                    {
                        IDProducto = int.Parse(dgvCompras.Rows[e.RowIndex].Cells["cmbProducto"].Value.ToString());
                        string sSQL = "SELECT precio_producto FROM producto WHERE pk_id_producto=" + IDProducto;
                        OdbcCommand comando = new OdbcCommand(sSQL, conexion.conexion());
                        OdbcDataReader registro = comando.ExecuteReader();
                        while (registro.Read())
                        {
                            dgvCompras.Rows[e.RowIndex].Cells["txtPrecioUnitario"].Value = registro["precio_producto"];
                        }
                        Precio = double.Parse(dgvCompras.Rows[e.RowIndex].Cells["txtPrecioUnitario"].Value.ToString());
                        Cantidad = int.Parse(dgvCompras.Rows[e.RowIndex].Cells["txtCantidad"].Value.ToString());
                        SubTotal = Precio * Cantidad;
                        dgvCompras.Rows[e.RowIndex].Cells["txtSubtotal"].Value = SubTotal;
                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al cargar compra detalle", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Visualza el total
        private void tmrTotal_Tick(object sender, EventArgs e)
        {
            lblValorTotal.Text = SumarColumnas().ToString();
        }
        //Cierre del Formulario
        private void frmCompras_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvCompras.CurrentCell.ColumnIndex == 1)
            {
                char caracter = e.KeyChar;
                if (!char.IsNumber(caracter)&&caracter!=8)
                    e.Handled = true;
            }
        }

        private void dgvCompras_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvCompras.CurrentCell.ColumnIndex == 1)
            {
                TextBox txtAux = e.Control as TextBox;
                if (txtAux != null)
                {
                    txtAux.KeyPress -= new KeyPressEventHandler(dgvCompras_KeyPress);
                    txtAux.KeyPress += new KeyPressEventHandler(dgvCompras_KeyPress);
                }
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasModuloSCM/AyudasSCMASII.chm", "GestionCompras.html");
        }

        //Obtener estado del proceso
        private void cmbEstadoProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEstadoProceso.SelectedItem.ToString() == "Ingreso de Órden")
            {
                estadoProceso = 0;
            }else if (cmbEstadoProceso.SelectedItem.ToString() == "Ejecución de Órden")
            {
                estadoProceso = 1;
            }
            else if (cmbEstadoProceso.SelectedItem.ToString() == "Recepción de Órden")
            {
                estadoProceso = 2;
            }
            else if (cmbEstadoProceso.SelectedItem==null)
            {
                estadoProceso = -1;
            }
        }

        //Sumar Total 
        private double SumarColumnas()
        {
            TotalValor = 0;
            try
            {
                foreach (DataGridViewRow row in dgvCompras.Rows)
                {
                    if (row.Cells["txtSubtotal"].Value != null)
                        TotalValor += (double)row.Cells["txtSubtotal"].Value;
                }
                lblValorTotal.Text = TotalValor.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al totales compras", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TotalValor;
        }
        //Registrar compra
        private bool RegistrarCompra()
        {
            int CodLinea = 0, Producto, Cantidad;
            double PrecioU, SubtotalU;
            try
            {
                this.compraEncabezado = llenarCamposCompraEncabezado(SumarColumnas());
                if (compraEncabezado == null)    
                {
                    MessageBox.Show("Campos Vacios", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    controladorCompras.InsertarFactura(compraEncabezado);
                    int iFilas = dgvCompras.Rows.Count;
                    Console.WriteLine(iFilas);
                    //Linea por linea del grid inserta a detalle compra
                    while (CodLinea < (iFilas - 1))
                    {
                        Producto = int.Parse(dgvCompras.Rows[CodLinea].Cells["cmbProducto"].Value.ToString());
                        Cantidad = int.Parse(dgvCompras.Rows[CodLinea].Cells["txtCantidad"].Value.ToString());
                        PrecioU = double.Parse(dgvCompras.Rows[CodLinea].Cells["txtPrecioUnitario"].Value.ToString());
                        SubtotalU = double.Parse(dgvCompras.Rows[CodLinea].Cells["txtSubtotal"].Value.ToString());
                        ++CodLinea;
                        this.compraDetalle = llenarCamposCompraDetalle(Producto, CodLinea, Cantidad, PrecioU, SubtotalU);
                        controladorCompras.InsertarDetalleFactura(compraDetalle);
                    }
                    MessageBox.Show("Datos de Compra Ingresados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Compra Exitosa");
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
        //Registrar pedido 
        private bool RegistrarPedido()
        {
            int CodLinea = 0, Producto, Cantidad;
            double PrecioU, SubtotalU;
            try
            {
                this.pedidoEncabezado = llenarCamposPedidoEncabezado(SumarColumnas());
                if (pedidoEncabezado == null)
                {
                    MessageBox.Show("Campos Vacios", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    controladorCompras.InsertarPedidoE(pedidoEncabezado);
                    int iFilas = dgvCompras.Rows.Count;
                    Console.WriteLine(iFilas);
                    //Linea por linea del grid inserta a detalle compra
                    while (CodLinea < (iFilas - 1))
                    {
                        Producto = int.Parse(dgvCompras.Rows[CodLinea].Cells["cmbProducto"].Value.ToString());
                        Cantidad = int.Parse(dgvCompras.Rows[CodLinea].Cells["txtCantidad"].Value.ToString());
                        PrecioU = double.Parse(dgvCompras.Rows[CodLinea].Cells["txtPrecioUnitario"].Value.ToString());
                        SubtotalU = double.Parse(dgvCompras.Rows[CodLinea].Cells["txtSubtotal"].Value.ToString());
                        ++CodLinea;
                        this.pedidoDetalle = llenarCamposPedidoDetalle(Producto, CodLinea, Cantidad, PrecioU, SubtotalU);
                        controladorCompras.InsertarDetallePedido(pedidoDetalle);
                    }
                    MessageBox.Show("Datos de Pedido Ingresados", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Pedido Exitoso");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Pedido Fallido");
                MessageBox.Show("Error al Guardar Datos de Pedido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
