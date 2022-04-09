using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V2_2
{
    interface IOblik
    {
        // ne moze da ima polja
        // interface sadrzi samo potpise metoda
    }

    /*
    class Krug : Oblik { }

    class Auto { }

    class Oblik { }
    */

    /*
    class Stack
    {
        public object elements;
    }
    */

    //TOblik, Trougao, Kvadrat, Pravougaonik
    abstract class TOblik
    {
        public abstract void Obim();

        public abstract void Povrsina();
    }

    class Trougao : TOblik
    {
        public int a, b, c;
        public int O;
        public sealed override void Obim()
        {
            O = a + b + c;
        }

        public override void Povrsina()
        {
            throw new NotImplementedException();
        }
    }

    class Piramida : Trougao
    {
        DateTime date = new DateTime();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Krug k = new Krug();
            Oblik o = k as Oblik; // ovaj vraca null ako ne uspe. Upcasting/Downcasting
            if(o == null)
            Oblik o = (Oblik)k;
            */

            TOblik[] oblici = new TOblik[10];
            oblici[4] = new Trougao();
            oblici[5] = new Mnogougao();
            for(int i = 0, i =< 10; i++)
            {
                oblici[i].Povrsina();
            }
        }
    }
}
