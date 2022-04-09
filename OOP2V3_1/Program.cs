using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoProcessor processor = new PhotoProcessor();
            PhotoFilters photoFilters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler photoFilterHandler = PhotoFilters.ApplyBrightness;
            photoFilterHandler += RedEyeFilter;


            processor.Process("neki url slike", photoFilterHandler);

            Console.ReadLine();
        }

        public static void RedEyeFilter(Photo photo)
        {
            Console.WriteLine($"On Photo {photo.Title} we applied Red Eye Filter!");
        }
    }
}

/*
 * lista delegata
 *  brighntess
 *  redeye
 *  
 */