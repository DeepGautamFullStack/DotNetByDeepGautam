using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    
   public class PhotoProcessors
    {
        public delegate void PhotoFilterhandler(Photo photo);
        public void Process(string path, PhotoFilterhandler filterhandler)
        {
            var photo = Photo.Load(path);
            filterhandler(photo);

            photo.Save();
        }

    }
}
