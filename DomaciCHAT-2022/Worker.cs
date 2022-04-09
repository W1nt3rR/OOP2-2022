using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciCHAT_2022
{
    internal class Worker
    {
        enum WorkerType {DEVELOPER, QUALITYASSURANCE};



        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private int plata;

        public int Plata
        {
            get { return plata; }
            set { plata = value; }
        }


        public Worker(int ID, string Ime, string Prezime, int Plata)
        {
            //this.id = ID;
            this.ID = ID;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.Plata = Plata;
        }
    }
}
