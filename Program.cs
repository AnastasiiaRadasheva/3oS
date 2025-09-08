using System;
using System.Text;

namespace _3oS
{
    internal class StartClass
    {
        public static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Random rnd = new Random();
            //3.osa List
            List<string> nimed = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}, Nimi:");
                nimed.Add(Console.ReadLine());
            }
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            int[] arvud = new int[5];
            int j = 0;
            while (j<5)
            {
                Console.WriteLine(j+1);
                arvud [j] = rnd.Next(1,101);
                j++;

            }
            foreach (int arv in arvud)
            {
                Console.WriteLine(arv);
            }

            List<ClassIsik> isikud = new List<ClassIsik>();
            j = 0;
            do
            {
                Console.WriteLine(j + 1);
                ClassIsik isik = new ClassIsik();
                Console.WriteLine("Eesnimi: ");
                isik.eesnimi = Console.ReadLine();
                Console.WriteLine("perenimi: ");
                isik.perenimi = Console.ReadLine();
                isikud.Add(isik);//list
                j++;
            }
            while (j < 5);
            isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            Console.WriteLine(isikud.Count);
            foreach (ClassIsik isik in isikud)
            {

                isik.Prindi_admed();

            }

            Console.WriteLine($"Kolmandal kohal on {isikud[2].eesnimi} {isikud[2].perenimi}");




        }
    }
}
