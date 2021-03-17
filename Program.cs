﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "Rayhan";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassager();
            taxi.DropOffPassenger();

            Console.ReadKey();

        }
    }
}
