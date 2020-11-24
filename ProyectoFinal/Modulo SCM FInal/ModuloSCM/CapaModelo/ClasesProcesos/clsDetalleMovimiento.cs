using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloModuloSCM.ClasesProcesos
{
    public class clsDetalleMovimiento
    {
        private int idDetalle;
        private int idMovimiento;
        private int idProducto;
        private int Cantidad;

        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public int IdMovimiento { get => idMovimiento; set => idMovimiento = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
    }
}
