using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V1
{
    internal class Krug
    {
        private double r;

        public double Poluprecnik
        {
            get { return r; }
            set { r = value; }
        }

        public Krug()
        {
            this.r = 5.0;
        }

        public Krug(double poluprecnik)
        {
            this.r = poluprecnik;
        }

        public double Obim()
        {
            return r * 2 * Math.PI;
        }

        public double Povrsina()
        {
            return r * r * Math.PI;
        }
    }
}
