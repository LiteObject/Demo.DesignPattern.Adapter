using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Example1
{
    /// <summary>
    /// The adaptee (incompatible interface)
    /// </summary>
    internal class LegacyCar
    {
        public void Start()
        {
            Console.WriteLine("Car started.");
        }
    }
}
