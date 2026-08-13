using System;
using System.Collections.Generic;
using System.Text;

namespace TallerToluca.EN
{
    internal class EmpleadoEN
    {
   
    }
}

namespace TallerToluca.EN
{
    public class EmpleadoEN
    {
        public int EmpleadoID { get; set; }
        public string NombreCompleto { get; set; }
        public string Cargo { get; set; } // Administrador, Recepcionista, Mecánico
        public string Telefono { get; set; }
        public string Estado { get; set; } = "Activo";
    }
}