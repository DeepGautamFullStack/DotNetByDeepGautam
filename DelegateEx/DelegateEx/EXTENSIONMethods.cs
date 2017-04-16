using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
  public static  class EXTENSIONMethods
    {
        public static string Discard(this string str, int param1)
            {
            return string.Join("  ", str.Take(param1)).ToString();
            }

    }
}
