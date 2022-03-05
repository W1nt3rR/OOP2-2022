using System;

namespace OOP2V1
{
    //Racunanje obima i povrsine na osnovu ulaznih podataka, poluprecnika odnosno stranice

    class Student
    {
        // Fields, Property
        // polja, praksa camel case
        private string _prezimeStudenta;

        public string PrezimeStudenta
        {
            get { return _prezimeStudenta; }
            set { _prezimeStudenta = value; }
        }

        private string _imeStudenta;

        public string ImeStudenta
        {
            get { return _imeStudenta; }
            set { _imeStudenta = value; }
        }


        /*
        public void SetImeStudenta(string value)
        {

        }

        public string GetImeStudenta()
        {
            return imeStudenta;
        }

        public string GetPrezimeStudenta()
        {
            return prezimeStudenta;
        }
        */

        public Student()
        {
            this._imeStudenta = "Ramiz";
            this._prezimeStudenta = "Sabovic";
        }

        public Student(string imeStudenta, string prezimeStudenta)
        {
            this._imeStudenta = imeStudenta;
            this._prezimeStudenta= prezimeStudenta;
        }

        // Metode - Pascal Case
        public string PredstaviSe()
        {
            return _imeStudenta + " " + _prezimeStudenta;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Student s1 = new Student();
            Student nn = new Student();

            Console.WriteLine("Unesite ime studenta");
            nn.ImeStudenta = Console.ReadLine();
            nn.PrezimeStudenta = Console.ReadLine();
            
            Console.WriteLine("Dobro dosli " + s1.PredstaviSe() + " na kurs OOP2");
            Console.WriteLine("Dobro dosli " + nn.PredstaviSe() + " na kurs OOP2");
            */

            Krug k1 = new Krug();
            Krug k2 = new Krug(6.9);
            Console.WriteLine(k1.Obim());
            Console.WriteLine(k2.Obim());

            //Console.WriteLine("Obim kruga je {0}, a povrsina kruga je {1}", k1.Obim(), k1.Povrsina());
            Console.WriteLine($"Obim kruga 2 je {k2.Obim()}, a povrsina kruga 2 je {k2.Povrsina()}"); //najbolja metoda ispisa

            Kvadrat kv1 = new Kvadrat();
            Kvadrat kv2 = new Kvadrat(6.9f);

            Console.WriteLine(kv1.Obim());
            Console.WriteLine(kv1.Povrsina());
            Console.WriteLine(kv2.Obim());
            Console.WriteLine(kv2.Povrsina());

            Console.ReadLine();

        }
    }
}
