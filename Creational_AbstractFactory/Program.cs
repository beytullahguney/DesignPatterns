using System;

namespace Creational_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleFactory = new VehicleFactory();

            IVehicle car = vehicleFactory.ProduceVehicle(VehicleType.Car);
            car.DisplayInfo();

            IVehicle truck = vehicleFactory.ProduceVehicle(VehicleType.Truck);
            truck.DisplayInfo();

            IVehicle motorCycle = vehicleFactory.ProduceVehicle(VehicleType.Motorcycle);
            motorCycle.DisplayInfo();

        }
    }
}
