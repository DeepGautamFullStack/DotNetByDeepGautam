using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExampleInDotNet
{
  static  class CarFactory
    {
        public static ICarSupplier GetCarInstance(int id)
        {
            switch (id)
            {
                case 0:
                    return new BMW();
                case 1:
                    return new Honda();
                case 2:
                    return new Hundai();
                case 3:
                    return new Maruti();
                case 4:
                    return new Nano();
                default:
                    return null;
            }
        }
    }
}
