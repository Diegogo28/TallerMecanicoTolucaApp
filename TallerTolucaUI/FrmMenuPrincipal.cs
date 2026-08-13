using System;
using System.Collections.Generic;
using System.Text;
using TallerToluca.BL;

namespace TallerTolucaUI
{
    internal class FrmMenuPrincipal
    {
    }
}
using System;
using System.Windows.Forms;
using TallerToluca.BL;

namespace TallerToluca.UI
{
    public partial class FrmMenuPrincipal : Form
    {
        private readonly CitaBL _citaBL = new CitaBL();

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            AplicarSeguridadSegunRol();
            ProcesarCitasVencidas();
        }

        private void AplicarSeguridadSegunRol()
        {
            string rol = SesionSistema.Rol;
            lblUsuarioActivo.Text = $"Usuario: {SesionSistema.NombreUsuario} | Rol: {rol}";

            // Restricción de permisos según el Rol (Punto 25)
            if (rol == "Mecánico")
            {
                btnClientes.Enabled = false;
                btnCaja.Enabled = false;
                btnFacturacion.Enabled = false;
                btnEmpleados.Enabled = false;
            }
            else if (rol == "Recepcionista")
            {
                btnEmpleados.Enabled = false;
            }
        }

        private void ProcesarCitasVencidas()
        {
            try
            {
                // Regla Fuera de Alcance #3: Marcar citas vencidas automáticamente como "No Recibida"
                _citaBL.ProcesarCitasVencidas(30);
            }
            catch { }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionSistema.UsuarioID = 0;
            SesionSistema.Rol = null;
            this.Close();
        }
    }
} 
