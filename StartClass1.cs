using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3oS
{
    internal class StartClass1
    {
        public static void Main1(string[] args)
        {
            int[] numbers = new int[5];
            double[] arvud = ArvuTootlus.Tekstist_arvud();
            var tulemus = ArvuTootlus.AnalüüsiArve(arvud);
            Console.WriteLine($"Summ: {tulemus.Item1}, Kesk: {tulemus.Item2}, Korrus: {tulemus.Item3}");


        }
    }
}
