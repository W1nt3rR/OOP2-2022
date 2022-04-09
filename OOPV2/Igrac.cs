using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPV2
{
    internal class Igrac
    {
        private int broj;

        public int Broj
        {
            get { return broj; }
            set 
            { 
                if(value >= -1 && value <= 10)
                    broj = value; 
            }
        }

        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public Igrac()
        {
            ime = "Ramiz";
        }

        public void GenerisiBroj()
        {
            Console.WriteLine("Unesite jedan broj (1 do 10)");
            var brojTekst = Console.ReadLine();
            Broj = int.Parse(brojTekst);
        }

    }
}
