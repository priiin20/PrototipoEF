/*
 Clase Controlador de Movimientos de Inventario
 */
using CapaModeloModuloSCM;
using CapaModeloModuloSCM.ClasesProcesos;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorModuloSCM.ControlProcesos
{
    public class clsControladorMovimientosInventarios
    {
        private clsConexion conexion = new clsConexion(); // instanciar la clase conexion 
        private DataTable tabla; // variable tipo DataTable 
        private OdbcDataAdapter datos; // Variable OdbcDataAdapter

        
        //Obtener Datos con los que han de visualizar los combobox
        public DataTable obtenerCamposCombobox(string Campo1, string Campo2, string Tabla, string Estado)
        {
            try
            {
                string sComando = string.Format("SELECT " + Campo1 + " ," + Campo2 + " FROM " + Tabla + " WHERE " + Estado + "=1");
                datos = new OdbcDataAdapter(sComando, conexion.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataTable obtenerDetalles(string Campo1, string Campo2, string Tabla, string primaryKey, int? noId, string estadoDetalle)
        {
            try
            {
                if (estadoDetalle.Length == 0)
                {
                    string sComando = string.Format("SELECT " + Campo1 + " ," + Campo2 + " FROM " + Tabla + " WHERE " + primaryKey + "=" + noId);
                    datos = new OdbcDataAdapter(sComando, conexion.conexion());
                    tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;
                }
                else
                {
                    string sComando = string.Format("SELECT " + Campo1 + " ," + Campo2 + " FROM " + Tabla + " WHERE " + primaryKey + "=" + noId + " AND " + estadoDetalle + "=1");
                    datos = new OdbcDataAdapter(sComando, conexion.conexion());
                    tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataTable obtenerNoCompraPedido(string Campo1, string Tabla, string Estado, string estadoProceso)
        {
            try
            {
                if (Estado.Length == 0 && estadoProceso.Length == 0)
                {
                    string sComando = string.Format("SELECT " + Campo1 + " FROM " + Tabla);
                    datos = new OdbcDataAdapter(sComando, conexion.conexion());
                    tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;
                }
                else
                {
                    string sComando = string.Format("SELECT " + Campo1 + " FROM " + Tabla + " WHERE " + Estado + "=1 AND " + estadoProceso + "=2");
                    datos = new OdbcDataAdapter(sComando, conexion.conexion());
                    tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Obtener el destino y ruta que sean iguales al id que se ingreso, se realiza la respectiva busqueda
        public string[] obtenerCamposRuta(int iID)
        {
            string[] datos=new string[2];
            try
            {
                string sComando = "select origen_ruta, destino_ruta from ruta where estado_ruta=1 and pk_id_ruta =" + iID;
                OdbcCommand comando = new OdbcCommand(sComando, conexion.conexion());
                OdbcDataReader registro = comando.ExecuteReader();

                int iPiv = 0;
                while (registro.Read() && iPiv<datos.Length)
                {
                    datos[iPiv] = registro["origen_ruta"].ToString();
                    iPiv++;
                    datos[iPiv] = registro["destino_ruta"].ToString();
                }
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de reportes");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Se generan ID automatico
        public int generarID(string sTabla, string sCampo)
        {
            OdbcConnection con = conexion.conexion();
            OdbcCommand comando = con.CreateCommand();
            int iIdNuevo;
            try
            {
                comando.CommandText = "SELECT max(" + sCampo + ") from " + sTabla + ";";
                int.TryParse(comando.ExecuteScalar().ToString(), out iIdNuevo);
                return (iIdNuevo+1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al Generar el Id Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        //Insertar datos a tablas
        public void insertarEncabezadoMovimientos(clsMantenimientoInventario movimiento)
        {
            string format = "yyyy-MM-dd HH:mm:ss";
            OdbcConnection con = conexion.conexion();
            OdbcCommand comando = con.CreateCommand();
            OdbcTransaction transaction;
           
            transaction = con.BeginTransaction();
            comando.Connection = con;
            comando.Transaction = transaction;
            try
            {
                if (movimiento.IdRuta == null && movimiento.IdVehiculo==null)
                {
                    comando.CommandText = "INSERT INTO movimiento_inventario (pk_id_movimiento_inventario, fecha_movimiento_inventario, fk_id_tipo_movimiento, fk_id_ruta, fk_id_vehiculo,documento_asociado_movimiento_inventario, descripcion_movimiento_inventario) VALUES (" +
                        +movimiento.IdMovimiento+",'"+movimiento.Fecha1.ToString(format)+"',"+movimiento.IdTipoMovimiento+", NULL, NULL,"+movimiento.DocuAsociado+",'"+movimiento.Descripcion1+"');";
                }else if (movimiento.DocuAsociado == null)
                {
                    comando.CommandText = "INSERT INTO movimiento_inventario (pk_id_movimiento_inventario, fecha_movimiento_inventario, fk_id_tipo_movimiento, fk_id_ruta, fk_id_vehiculo,documento_asociado_movimiento_inventario, descripcion_movimiento_inventario) VALUES (" +
                        +movimiento.IdMovimiento + ",'" + movimiento.Fecha1.ToString(format) + "'," + movimiento.IdTipoMovimiento + ","+movimiento.IdRuta+","+movimiento.IdVehiculo+", NULL, '" + movimiento.Descripcion1 + "');";
                }
                comando.ExecuteNonQuery();
                transaction.Commit();
                Console.WriteLine("Transaccion Exitosa Tabla 1");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error transaccion movimiento encabezado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        public void insertarDetalleMovimiento(clsDetalleMovimiento detalleMovimiento, int tipoMovimiento, int? docuAsociado)
        {
            string SQL = "";
            int CantidadAnterior, datosExistentes,bodegaRandom;
            
            OdbcConnection con = conexion.conexion();
            OdbcCommand comando = con.CreateCommand();
            OdbcCommand comandoActualizacion;
            OdbcTransaction transaction;
            transaction = con.BeginTransaction();
            comando.Connection = con;
            comando.Transaction = transaction;
            try
            {
                con = conexion.conexion();
                comando = con.CreateCommand();
                transaction = con.BeginTransaction();
                comando.Connection = con;
                comando.Transaction = transaction;
                comando.CommandText = "INSERT INTO movimiento_inventario_detalle (pk_id_movimiento_inventario_detalle, fk_id_movimiento_inventario, fk_id_producto, cantidad_inventario_detalle) VALUES (?,?,?,?);";
                comando.Parameters.Add("pk_id_movimiento_inventario_detalle", OdbcType.Int).Value = detalleMovimiento.IdDetalle;
                comando.Parameters.Add("fk_id_movimiento_inventario", OdbcType.Int).Value = detalleMovimiento.IdMovimiento;
                comando.Parameters.Add("fk_id_producto", OdbcType.Int).Value = detalleMovimiento.IdProducto;
                comando.Parameters.Add("cantidad_inventario_detalle", OdbcType.Int).Value = detalleMovimiento.Cantidad1;
                
                if (tipoMovimiento == 1)
                {
                    SQL = "SELECT COUNT(*) FROM inventario WHERE fk_id_producto="+detalleMovimiento.IdProducto;
                    comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                    datosExistentes = int.Parse(comandoActualizacion.ExecuteScalar().ToString());
                    SQL = "SELECT cantidad_inventario FROM inventario WHERE fk_id_producto=" + detalleMovimiento.IdProducto;
                    OdbcCommand actualizar = new OdbcCommand(SQL, conexion.conexion());
                    OdbcDataReader registro = actualizar.ExecuteReader();
                    if (datosExistentes == 0)
                    {
                        SQL = "INSERT INTO inventario (pk_id_inventario, fk_id_producto, cantidad_inventario,estado_inventario) VALUES (" +generarID("inventario","pk_id_inventario")+","+ detalleMovimiento.IdProducto + ","+ detalleMovimiento.Cantidad1 + ",1);";
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        comandoActualizacion.ExecuteNonQuery();
                    }
                    else
                    {
                        while (registro.Read())
                        {
                            CantidadAnterior = int.Parse(registro["cantidad_inventario"].ToString());
                            SQL = "UPDATE inventario SET cantidad_inventario=" + (CantidadAnterior + detalleMovimiento.Cantidad1) + " WHERE fk_id_producto=" + detalleMovimiento.IdProducto + ";";
                            comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                            comandoActualizacion.ExecuteNonQuery();
                        }
                    }
                }
                else if (tipoMovimiento == 2)
                {
                    SQL = "SELECT COUNT(*) FROM inventario WHERE fk_id_producto=" + detalleMovimiento.IdProducto;
                    comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                    datosExistentes = int.Parse(comandoActualizacion.ExecuteScalar().ToString());
                    SQL = "SELECT cantidad_inventario FROM inventario WHERE fk_id_producto=" + detalleMovimiento.IdProducto;
                    OdbcCommand actualizar = new OdbcCommand(SQL, conexion.conexion());
                    OdbcDataReader registro = actualizar.ExecuteReader();
                    if (datosExistentes == 0)
                    {
                        MessageBox.Show("No existe inventario para realizar este movimiento", "Error en Inventarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        while (registro.Read())
                        {
                            CantidadAnterior = int.Parse(registro["cantidad_inventario"].ToString());
                            if (CantidadAnterior > detalleMovimiento.Cantidad1)
                            {
                                SQL = "UPDATE inventario SET cantidad_inventario=" + (CantidadAnterior - detalleMovimiento.Cantidad1) + " WHERE fk_id_producto=" + detalleMovimiento.IdProducto + ";";
                                comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                                comandoActualizacion.ExecuteNonQuery();
                            }
                            else
                                MessageBox.Show("La cantidad a actualizar es mayor que la que existe en stock", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (tipoMovimiento == 3)
                {
                    SQL = "SELECT COUNT(*) FROM existencia WHERE fk_id_producto=" + detalleMovimiento.IdProducto;
                    comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                    datosExistentes = int.Parse(comandoActualizacion.ExecuteScalar().ToString());
                    SQL = "SELECT cantidad_existencia FROM existencia WHERE fk_id_producto=" + detalleMovimiento.IdProducto;
                    OdbcCommand actualizar = new OdbcCommand(SQL, conexion.conexion());
                    OdbcDataReader registro = actualizar.ExecuteReader();
                    if (datosExistentes == 0)
                    {
                        SQL = "SELECT pk_id_bodega FROM bodega ORDER BY RAND() LIMIT 1 ";
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        bodegaRandom = int.Parse(comandoActualizacion.ExecuteScalar().ToString());
                        SQL = "INSERT INTO existencia (pk_id_existencia, fk_id_bodega, fk_id_producto, cantidad_existencia, estado_existencia) VALUES (" + generarID("existencia", "pk_id_existencia") +","+bodegaRandom+"," + detalleMovimiento.IdProducto + "," + detalleMovimiento.Cantidad1 + ",1);";
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        comandoActualizacion.ExecuteNonQuery();
                    }
                    else
                    {
                        while (registro.Read())
                        {
                            CantidadAnterior = int.Parse(registro["cantidad_existencia"].ToString());
                            SQL = "UPDATE existencia SET cantidad_existencia=" + (CantidadAnterior + detalleMovimiento.Cantidad1) + " WHERE fk_id_producto=" + detalleMovimiento.IdProducto + ";";
                            comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                            comandoActualizacion.ExecuteNonQuery();
                        }
                    }
                }
                comando.ExecuteNonQuery();
                if (docuAsociado != null)
                {
                    if (tipoMovimiento == 1)
                    {
                        SQL = "UPDATE compra_detalle SET estado_compra_detalle=0 WHERE fk_id_compra_encabezado=" + docuAsociado;
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        comandoActualizacion.ExecuteNonQuery();
                        SQL = "UPDATE compra_encabezado SET estado_encabezado_compra=0 WHERE pk_id_compra_encabezado=" + docuAsociado;
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        comandoActualizacion.ExecuteNonQuery();
                    }
                    else if (tipoMovimiento == 2)
                    {
                        SQL = "DELETE FROM detalle_factura WHERE fk_id_factura=" + docuAsociado;
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        comandoActualizacion.ExecuteNonQuery();
                        SQL = "DELETE FROM facturas WHERE pk_id_factura=" + docuAsociado;
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        comandoActualizacion.ExecuteNonQuery();
                    }
                    else if (tipoMovimiento == 3)
                    {
                        SQL = "UPDATE pedido_detalle SET estado_pedido_detalle=0 WHERE fk_id_pedido_encabezado=" + docuAsociado;
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        comandoActualizacion.ExecuteNonQuery();
                        SQL = "UPDATE pedido_encabezado SET estado_pedido_encabezado=0 WHERE pk_id_pedido_encabezado=" + docuAsociado;
                        comandoActualizacion = new OdbcCommand(SQL, conexion.conexion());
                        comandoActualizacion.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                Console.WriteLine("Transaccion Exitosa Tabla 2");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error transaccion movimiento detalle", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
