using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Interfaces;

namespace Lib.Engines
{
    internal class BenzEngine : IEngine
    {
        Manufacturer IEngine.Manufacturer => Manufacturer.Benz;

        public void Start()
        {
            Console.WriteLine("Benz 부릉부릉");
        }
    }
}
