﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Creational_AbstractFactory
{
    /// <summary>
    /// Creating Truck Vehicle
    /// </summary>
    public class Truck : IVehicle
    {
        public void DisplayInfo()
        {
            string s =this.GetType().Name;
            Console.WriteLine(string.Format("Produce {0} ", s));
        }
    }
}
