using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIinDotNetCore
{
  public  interface ICreditService
    {
        void Credit(decimal amount);
    }
}
