using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V3_4_extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Danas ucimo mnogo novih oblasti iz C#";
            string shorter1 = text.Shorter(-1);
            string shorter = Splitter.Shorter(text, 4);
            //string shorter = Splitter.Shorter("Danas ucimo mnogo novih oblasti iz C#", 5);
            Console.WriteLine(shorter);

            Console.ReadLine();
        }
    }
}
