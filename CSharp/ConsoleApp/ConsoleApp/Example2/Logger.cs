using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Example2
{
    // Adaptee (incompatible interface)
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logger: {message}");
        }
    }
}
