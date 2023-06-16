using Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Engines
{
    internal class BMWEngine : IEngine
    {
        public Manufacturer Manufacturer => Manufacturer.BMW;

        public void Start()
        {
            Console.WriteLine("BMW 부릉부릉");
        }
    }
}
