using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_AbstractFactory
{
    /// <summary>
    /// Vehicle Factory Contract
    /// </summary>
    interface IVehicleFactory
    {
        IVehicle ProduceVehicle(VehicleType _type);
    }
}
