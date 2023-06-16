using Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Car
    {
        IEngine _engine;
        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void StartEngine()
        {
            _engine.Start();
        }
    }
}
