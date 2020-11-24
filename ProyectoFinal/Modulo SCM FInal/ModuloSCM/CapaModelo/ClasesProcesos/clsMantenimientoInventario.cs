/*
 Clase de Movimiento de Inventario
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloModuloSCM.ClasesProcesos
{
    public class clsMantenimientoInventario
    {
        //Datos de Tabla
        private int idMovimiento;
        private int idTipoMovimiento;
        private DateTime Fecha;
        private int? idRuta;
        private int? idVehiculo;
        private int? docuAsociado;
        private string Descripcion;

        public int IdMovimiento { get => idMovimiento; set => idMovimiento = value; }
        public int IdTipoMovimiento { get => idTipoMovimiento; set => idTipoMovimiento = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int? IdRuta { get => idRuta; set => idRuta = value; }
        public int? IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public int? DocuAsociado { get => docuAsociado; set => docuAsociado = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
    }
}
