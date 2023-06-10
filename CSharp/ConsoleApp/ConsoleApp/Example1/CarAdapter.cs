using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Example1
{
    internal class CarAdapter : IVehicle
    {
        private readonly LegacyCar _legacyCar;

        public CarAdapter(LegacyCar legacyCar)
        {
            this._legacyCar = legacyCar;
        }

        public void StartEngine()
        {
            _legacyCar.Start();
        }
    }
}
