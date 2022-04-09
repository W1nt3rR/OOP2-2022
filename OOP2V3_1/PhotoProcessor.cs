using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP2V3_1
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string url, PhotoFilterHandler photoFilterHandler)
        {
            //Action<> // Func kada se vraca vrednost

            Photo photo = Photo.Load(url);
            Console.WriteLine("Base photo has been loaded!");
            Thread.Sleep(3000);

            photoFilterHandler(photo);

            //PhotoFilters.ApplyBrightness(photo);
            //Thread.Sleep(1000);
            //PhotoFilters.ApplySmoothig(photo);

            //photoFilterHandler.Apply

            Thread.Sleep(1000);

            photo.Save();
        }
    }
}
