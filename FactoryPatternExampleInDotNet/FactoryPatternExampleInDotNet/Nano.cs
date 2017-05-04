using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExampleInDotNet
{
    class Nano : ICarSupplier
    {
        public string CarColor
        {
            get
            {
                return "Green";
            }
        }

        public void GetCarModel()
        {
            Console.WriteLine("Nano 2017 model");
        }
    }
}
