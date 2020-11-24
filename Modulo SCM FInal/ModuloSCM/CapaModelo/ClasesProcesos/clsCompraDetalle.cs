/*
 Clase de Compra Detalle
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloModuloSCM.ClasesProcesos
{
    public class clsCompraDetalle
    {
        //Datos de la Tabla
        private int idCompra;
        private int codLinea;
        private int idProducto;
        private int Cantidad;
        private double precioUnitario;
        private double subTotal;
        private int Estado;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int CodLinea { get => codLinea; set => codLinea = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public double SubTotal { get => subTotal; set => subTotal = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
    }
}
