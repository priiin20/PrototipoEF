/*
 Clase de Compra Encabezado
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloModuloSCM.ClasesProcesos
{
    public class clsCompraEncabezado
    {
        //Datos de Tabla
        private int idCompra;
        private int idProveedor;
        private int estadoProceso;
        private DateTime FechaCompra;
        private double totalCompra;
        private int Estado;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public DateTime FechaCompra1 { get => FechaCompra; set => FechaCompra = value; }
        public double TotalCompra { get => totalCompra; set => totalCompra = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
        public int EstadoProceso { get => estadoProceso; set => estadoProceso = value; }
    }
}
