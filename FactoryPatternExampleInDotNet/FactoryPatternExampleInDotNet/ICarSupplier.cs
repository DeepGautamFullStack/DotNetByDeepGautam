using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExampleInDotNet
{
   public interface ICarSupplier
    {
         string CarColor { get;}
        void GetCarModel();
    }
}
