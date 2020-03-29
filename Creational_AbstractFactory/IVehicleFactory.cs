using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_AbstractFactory
{
    interface IVehicleFactory
    {
        IVehicle ProduceVehicle(VehicleType _type);
    }
}
