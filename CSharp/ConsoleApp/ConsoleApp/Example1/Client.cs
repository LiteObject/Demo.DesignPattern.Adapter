﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Example1
{
    internal class Client
    {
        public void StartEngine(IVehicle vehicle)
        {
            vehicle.StartEngine();
        }
    }
}
