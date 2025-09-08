using System;
using System.Collections.Generic;
using System.Linq;
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

        public (int N, int M) GetGeneratedNumbers()
        {

            throw new NotImplementedException();
        }
    }
}
