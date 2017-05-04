using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExampleInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarSupplier objCarSupplier = CarFactory.GetCarInstance(4);
            objCarSupplier.GetCarModel();
            Console.WriteLine("And Car color is-" + objCarSupplier.CarColor);
            Console.ReadLine();
        }
    }
}
