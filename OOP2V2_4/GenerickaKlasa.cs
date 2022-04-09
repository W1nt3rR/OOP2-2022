using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V2_4
{
    internal class GenerickaKlasa<T> where T : IComparable
    {
        public GenerickaKlasa(T a)
        {

        }
        public T max<T>(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
