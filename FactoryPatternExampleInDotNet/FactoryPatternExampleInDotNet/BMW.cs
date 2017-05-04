using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExampleInDotNet
{
    class BMW : ICarSupplier
    {
        public string CarColor
        {
            get
            {
                return "Black";
            }
        }

        public void GetCarModel()
        {
            Console.WriteLine("BMW Car Model is BMW 2017");
        }
    }
}
