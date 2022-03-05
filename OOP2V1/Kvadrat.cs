using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V1
{
    internal class Kvadrat
    {
        private float _a;

        public float a
        {
            get { return _a; }
            set { _a = value; }
        }

        public double Obim()
        {
            return 4 * _a;
        }

        public double Povrsina()
        {
            return _a * _a;
        }

        public Kvadrat()
        {
            //_a = 5;
            Math.Pow(_a, 2);
        }

        public Kvadrat(float stranica)
        {
            _a = stranica;
        }
    }
}
