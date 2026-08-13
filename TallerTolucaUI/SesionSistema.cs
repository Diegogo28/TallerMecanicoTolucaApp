using System;
using System.Collections.Generic;
using System.Text;

namespace TallerTolucaUI
{
    internal class SesionSistema
    {
    }
}
namespace TallerToluca.UI
{
    public static class SesionSistema
    {
        public static int UsuarioID { get; set; }
        public static string NombreUsuario { get; set; }
        public static string Rol { get; set; } // 'Administrador', 'Recepcionista', 'Mecánico'
    }
}
