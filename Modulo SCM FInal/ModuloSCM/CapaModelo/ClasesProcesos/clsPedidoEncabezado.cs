/*
 Clase de Pedido Encabezado
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloModuloSCM.ClasesProcesos
{
    public class clsPedidoEncabezado
    {
        //Datos de la tabla
        private int idPedido;
        private int idFabrica;
        private int estadoProceso;
        private DateTime FechaPedido;
        private double totalPedido;
        private int Estado;

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int IdFabrica { get => idFabrica; set => idFabrica = value; }
        public DateTime FechaPedido1 { get => FechaPedido; set => FechaPedido = value; }
        public double TotalPedido { get => totalPedido; set => totalPedido = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
        public int EstadoProceso { get => estadoProceso; set => estadoProceso = value; }
    }
}
