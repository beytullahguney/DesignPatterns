using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_AbstractFactory
{
    /// <summary>
    /// Creating Car Vehicles
    /// </summary>
    public class Car : IVehicle
    {
        /// <summary>
        /// Creating Vehicle Information
        /// </summary>
        public void DisplayInfo()
        {
            string s = this.GetType().Name;
            Console.WriteLine(string.Format("Produce {0} ", s));
        }
    }
}
