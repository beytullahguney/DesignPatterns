using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_AbstractFactory
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle ProduceVehicle(VehicleType _type)
        {
            IVehicle vehicle = null;

            switch (_type)
            {
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Truck:
                    vehicle = new Truck();
                    break;
                case VehicleType.Motorcycle:
                    vehicle = new Motorcycle();
                    break;
                default:
                    break;
            }
            return vehicle;
        }
    }
}
