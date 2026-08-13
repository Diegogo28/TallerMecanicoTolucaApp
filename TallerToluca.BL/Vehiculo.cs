using System;
using System.Collections.Generic;
using System.Text;
using TallerToluca.DAL;
using TallerToluca.EN;

namespace TallerToluca.BL
{
    internal class Vehiculo
    {
    }
}
using System;
using TallerToluca.DAL;
using TallerToluca.EN;

namespace TallerToluca.BL
{
    public class VehiculoBL
    {
        private readonly VehiculoDAL _vehiculoDAL = new VehiculoDAL();

        public int RegistrarVehiculo(VehiculoEN vehiculo)
        {
            if (vehiculo.ClienteID <= 0)
                throw new ArgumentException("Debe seleccionar un cliente propietario válido.");

            if (string.IsNullOrWhiteSpace(vehiculo.Placa))
                throw new ArgumentException("La placa del vehículo es obligatoria.");

            // Restricción #4: Solo vehículos livianos
            if (vehiculo.TipoVehiculo != "Liviano")
            {
                throw new InvalidOperationException("El sistema solo permite el registro de vehículos livianos (no pesados ni motocicletas).");
            }

            return _vehiculoDAL.Registrar(vehiculo);
        }
    }
}
