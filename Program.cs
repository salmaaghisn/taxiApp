﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi1 = new Taxi();
            Taxi taxi2 = new Taxi();
            Taxi taxi3 = new Taxi();
            Taxi taxi4 = new Taxi();

            taxi1.DriverName = "|| Muhammad ";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 47;

            taxi2.DriverName = "|| Haiban ";
            taxi2.OnDuty = true;
            taxi2.NumPassenger = 20;

            taxi3.DriverName = "|| Budi ";
            taxi3.OnDuty = false;
            taxi3.NumPassenger = 15;

            taxi4.DriverName = "|| Ariawan ";
            taxi4.OnDuty = false;
            taxi4.NumPassenger = 76;

            taxi1.TaxiInfo();
            taxi1.PickUpPassenger();
            taxi1.DropOffPassenger();

            taxi2.TaxiInfo();
            taxi2.PickUpPassenger();
            taxi2.DropOffPassenger();

            taxi3.TaxiInfo();
            taxi3.PickUpPassenger();
            taxi3.DropOffPassenger();

            taxi4.TaxiInfo();
            taxi4.PickUpPassenger();
            taxi4.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
