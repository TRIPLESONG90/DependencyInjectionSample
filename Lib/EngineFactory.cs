using Lib.Engines;
using Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public static class EngineFactory
    {
        public static IEngine CreateEngine(Manufacturer manufacturer)
        {
            switch(manufacturer)
            {
                case Manufacturer.BMW:
                    return new BMWEngine();
                case Manufacturer.Benz:
                    return new BenzEngine();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
