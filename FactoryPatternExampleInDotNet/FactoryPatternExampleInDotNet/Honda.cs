using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExampleInDotNet
{
    class Honda : ICarSupplier
    {
        public string CarColor
        {
            get
            {
                return "White";
            }
        }

        public void GetCarModel()
        {
            Console.WriteLine("Honda 2017 model");
        }
    }
}
