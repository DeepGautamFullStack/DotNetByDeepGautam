using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExampleInDotNet
{
    class Hundai : ICarSupplier
    {
        public string CarColor
        {
            get
            {
                return "Purple";
            }
        }

        public void GetCarModel()
        {
            Console.WriteLine("Hundai 2017 model");
        }
    }
}
