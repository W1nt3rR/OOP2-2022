using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPV2
{
    internal class Igra 
    {
        Igrac igrac; // ili ovde inicijalizocati, ako ne treba ime
        Racunar racunar;

        public Igra()
        {
            igrac = new Igrac();
            racunar = new Racunar();
        }

        public void Igraj()
        {
            int brojPogodataka = 0;
            int brojGenerisanja = 0;
            // Igra
            while(true)
            {
                igrac.GenerisiBroj();
                if(igrac.Broj == -1)
                {
                    break;
                }
                racunar.GenBroj();
                if (igrac.Broj == racunar.Broj);
                {
                    brojPogodataka++;
                }
                brojGenerisanja++;
            }

            float procenat = (float)brojPogodataka / brojGenerisanja;
            Console.WriteLine($"Igrac {igrac.Ime} je pogodio broj {brojPogodataka} i ostvario uspesnost {procenat}%");
        }
    }
}
