using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3oS
{
    internal class ArvuTootlus
    {
        private Random rnd = new Random();

        public int[] GenereeriRuudud(int min, int max)
        {
            int N = rnd.Next(-100, 100);
            int M = rnd.Next(-100, 100);

            int start = int.Min(N, M);
            int end = int.Max(N, M);

            int length = end - start + 1;
            int[] ruudud = new int[length];

            for (int i = 0; i < length; i++)
            {
                int number = start + i;
                ruudud[i] = number * number;
            }

            return ruudud;
        }

        //public (int N, int M) GetGeneratedNumbers()
        //{

        //    throw new NotImplementedException();
        //}
        //public static int[] Arvude_massiv(int N, int M)
        //{
        //    int arv;
        //    int[] arvud = new int[M - N];
        //    for (int i = 0; i < arvud.Length; i++)
        //    {
        //        Console.WriteLine("{0} arv:", i + 1);
        //        arv = N;
        //        arvud[i] = arv;
        //        N++;
        //    }
        //    return arvud;
        //}
        public static double[] Tekstist_arvud ()
        {
            Console.WriteLine("Sisestage viis arvu:");
            string sisend = Console.ReadLine();
            char[] eraldajad = new char[] { ' ', ',', ';' };

            string [] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);
            double[] arvud = new double[osad.Length];
            for (int i = 0; i < osad.Length; i++)
            {
                Console.Write("Sisestage arv {0}: ", i + 1);
                arvud[i] = Convert.ToDouble(Console.ReadLine());
            }
            return arvud;

        
        }
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double sum = 0;
            double product = 1;
            foreach (double arv in arvud)
            {
                sum += arv;
                product *= arv;
            }
            double average = sum / arvud.Length;
            Console.WriteLine($"Summa: {sum}, Keskmine: {average}, Toode: {product}");
            return Tuple.Create(sum, average, product);
        }
        public static Tuple<int, double, ClassIsik, ClassIsik> Statistika(List<ClassIsik> inimesed)
        {
            int sum = 0;
            double average = 0;
            ClassIsik youngest = inimesed[0];
            ClassIsik oldest = inimesed[0];
            foreach (ClassIsik inimene in inimesed)
            {
                sum += inimene.synniaasta;
                if (inimene.synniaasta < youngest.synniaasta)
                {
                    youngest = inimene;
                }
                if (inimene.synniaasta > oldest.synniaasta)
                {
                    oldest = inimene;
                }
            }
            average = (double)sum / inimesed.Count;
            return Tuple.Create(sum, average, youngest, oldest);
        }

    }
}
