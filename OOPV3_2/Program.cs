using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"Kvadrat broja {a} iznosi {Kvadrat(a)}");
            // a => a * a;
            Func<int, int> nasKvadrat = w => w * w;

            Console.WriteLine($"Kvadrat broja {a} izracunat preko lambda izraza iznosi {nasKvadrat(a)}");
            
            // p, p*n
            Func<int, int, int> proizvoid = (p, n) => p * n;
            Console.WriteLine($"Proizvoid broja 2 i 5 iznosi {proizvoid(2, 5)}");

            Console.ReadLine();
        }

        static int Kvadrat(int x)
        {
            return x * x;
        }
    }
}
