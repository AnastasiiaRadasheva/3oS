using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3oS
{
    internal class ClassIsik
    {
        public string eesnimi;
        public string perenimi;
        public int synniaasta=2000;

        public ClassIsik() {}
        public ClassIsik(string eesnimi, string perenimi)
        {
            this.eesnimi = eesnimi;
            this.perenimi = perenimi;
        }
        public void Prindi_admed()
        {
            Console.WriteLine($"{eesnimi} {perenimi}, sünniaasta: {synniaasta}");

        }
    }

}
