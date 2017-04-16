using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
  public  class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness applied");
        }
        public void ApplyCOntrast(Photo photo)
        {
            Console.WriteLine("COntrast applied");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize applied");
        }
    }
}
