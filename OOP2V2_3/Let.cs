using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V2_3
{
    internal class Let
    {
        private string polaznaDestinacija;

        public string PolaznaDestinacija
        {
            get { return polaznaDestinacija; }
            set { polaznaDestinacija = value; }
        }

        private string dolaznaDestinacija;

        public string DolaznaDestinacija
        {
            get { return dolaznaDestinacija; }
            set { dolaznaDestinacija = value; }
        }

        private DateTime datumVremePoletanja;

        public DateTime DatumVremePoletanja
        {
            get { return datumVremePoletanja; }
            set { datumVremePoletanja = value; }
        }

        private int brRezervisanihMesta;

        public int BrRezervisanihMesta
        {
            get { return brRezervisanihMesta; }
            set { brRezervisanihMesta = value; }
        }

        public abstract bool Rezervacija();

        public Let(string polaznaDestinacija, string dolaznaDestinacija, DateTime datumVremePoletanja, int brRezervisanihMesta)
        {
            this.dolaznaDestinacija = dolaznaDestinacija;
            this.polaznaDestinacija = polaznaDestinacija;
            this.datumVremePoletanja = datumVremePoletanja;
            this.brRezervisanihMesta = brRezervisanihMesta;
        }
    }

    internal class RedovniLetovi : Let
    {
        private int brMesta;

        public int BrMesta
        {
            get { return brMesta; }
            set { brMesta = value; }
        }

        public RedovniLetovi(int brMesta, string polaznaDestinacija, string dolaznaDestinacija, DateTime datumVremePoletanja, int brRezervisanihMesta) : base(polaznaDestinacija, dolaznaDestinacija, datumVremePoletanja, brRezervisanihMesta)
        {
            this.brMesta = brMesta;
        }

        public override bool Rezervacija()
        {
            if (BrRezervisanihMesta == BrMesta)
                return false;
            BrRezervisanihMesta++;
            return true;
        }

        public override string ToString()
        {
            return $"Na ovom koji ide od {PolaznaDestinacija} do {DolaznaDestinacija} datuma {DatumVremePoletanja}, ima slobodnih mesta {brMesta-BrRezervisanihMesta}";
        }
    }

    internal class CarterLetovi : Let
    {
        private int brMesta;

        public int BrMesta
        {
            get { return brMesta; }
            set { brMesta = value; }
        }

        public CarterLetovi(int brMesta, string polaznaDestinacija, string dolaznaDestinacija, DateTime datumVremePoletanja, int brRezervisanihMesta) : base(polaznaDestinacija, dolaznaDestinacija, datumVremePoletanja, brRezervisanihMesta)
        {
            this.brMesta = brMesta;
        }

        public override bool Rezervacija()
        {
            if (BrRezervisanihMesta == BrMesta)
                return false;
            BrRezervisanihMesta++;
            return true;
        }

        public override string ToString()
        {
            return $"Na ovom koji ide od {PolaznaDestinacija} do {DolaznaDestinacija} datuma {DatumVremePoletanja}, ima slobodnih mesta {brMesta - BrRezervisanihMesta}";
        }
    }
}
