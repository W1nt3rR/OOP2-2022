using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V3_1
{
    public class PhotoFilters
    {
        public static void ApplyBrightness(Photo photo)
        {
            Console.WriteLine($"On Photo {photo.Title} we applied brightness filter!");
        }

        public static void ApplySmoothig(Photo photo)
        {
            Console.WriteLine($"On Photo {photo.Title} we applied Smoothing filter!");
        }
    }
}
