using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExampleInDotNet
{
    class Maruti : ICarSupplier
    {
        public string CarColor
        {
            get
            {
                return "Red";
            }
        }

        public void GetCarModel()
        {
            Console.WriteLine("Maruiti 2017 model");
        }
    }
}
