using System;
using System.Collections.Generic;
using System.Text;

namespace TallerToluca.EN
{
    internal class Repuesto
    {
    }
}
namespace TallerToluca.EN
{
    public class RepuestoEN
    {
        public int RepuestoID { get; set; }
        public string Codigo { get; set; }
        public string NombreRepuesto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Existencia { get; set; }
    }
}