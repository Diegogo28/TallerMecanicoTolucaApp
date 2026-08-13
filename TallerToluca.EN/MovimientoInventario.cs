using System;
using System.Collections.Generic;
using System.Text;

namespace TallerToluca.EN
{
    internal class MovimientoInventario
    {
    }
}
using System;

namespace TallerToluca.EN
{
    public class MovimientoInventarioEN
    {
        public int MovimientoID { get; set; }
        public int RepuestoID { get; set; }
        public string TipoMovimiento { get; set; } // Entrada, Salida
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Motivo { get; set; }
    }
}
