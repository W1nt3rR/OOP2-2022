using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2P1_1
{
    internal class Student
    {
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String BrojIndeksa { get; set; }
        public double Prosek { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime} {BrojIndeksa} Prosek: {Prosek}";
        }
    }
}
