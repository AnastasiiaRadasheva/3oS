using System;
using System.Text;

namespace _3oS
{
    internal class StartClass
    {
        public static void Main(string[] args)
        {
            //Random rnd = new Random();
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            ////3.osa List
            //List<string> nimed = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i + 1}, Nimi:");
            //    nimed.Add(Console.ReadLine());
            //}
            //foreach (string nimi in nimed)
            //{
            //    Console.WriteLine(nimi);
            //}
            //int[] arvud = new int[5];
            //int j = 0;
            //while (j < 5)
            //{
            //    Console.WriteLine(j + 1);
            //    arvud[j] = rnd.Next(1, 101);
            //    j++;

            //}
            //foreach (int arv in arvud)
            //{
            //    Console.WriteLine(arv);
            //}

            //List<ClassIsik> isikud = new List<ClassIsik>();
            //j = 0;
            //do
            //{
            //    Console.WriteLine(j + 1);
            //    ClassIsik isik = new ClassIsik();
            //    Console.WriteLine("Eesnimi: ");
            //    isik.eesnimi = Console.ReadLine();
            //    Console.WriteLine("perenimi: ");
            //    isik.perenimi = Console.ReadLine();
            //    isikud.Add(isik);//list
            //    j++;
            //}
            //while (j < 5);
            //isikud.Sort((x, y) => x.eesnimi.CompareTo(y.eesnimi));
            //Console.WriteLine(isikud.Count);
            //foreach (ClassIsik isik in isikud)
            //{

            //    isik.Prindi_admed();

            //}

            //Console.WriteLine($"Kolmandal kohal on {isikud[2].eesnimi} {isikud[2].perenimi}");


            //Esimine ül
            //ArvuTootlus arvutaja = new ArvuTootlus();

            //Random rnd1 = new Random();

            //int start = rnd1.Next(-100, 101);
            //int end = rnd1.Next(-100, 101);

            //int length = end - start + 1;
            //int[] ruudud = new int[length];

            //for (int i = 0; i < length; i++)
            //{
            //    int number = start + i;
            //    ruudud[i] = number * number;
            //    Console.WriteLine($"{number} → {ruudud[i]}");

            ////}
            //Console.OutputEncoding = Encoding.UTF8;

            //Random random = new Random();
            //int N = random.Next(-100, 101);
            //int M = random.Next(-100, 101);
            //int[] arvud;

            //if (N > M)
            //{
            //    arvud = ArvuTootlus.Arvude_massiv(N, M);
            //}
            //else
            //{
            //    arvud = ArvuTootlus.Arvude_massiv(N, M);
            //}
            //foreach (int item in arvud)
            //{
            //    Console.WriteLine(item * item);
            }
        ////            //teine ül Viie arvu analüüs
        ////            Анализ пяти чисел

        ////    Задача:


        int[] numbers = new int[5];
        double[] arvud = ArvuTootlus.Tekstist_arvud();
        var tulemus = ArvuTootlus.AnalüüsiArve(arvud);
        Console.WriteLine($"Summ: {tulemus.Item1}, Kesk: {tulemus.Item2}, Korrus: {tulemus.Item3}");

            //3. Имена и возрасты

////Задача:
////Создайте класс Человек { string Имя; int Возраст;
////    }.
////Создайте метод Статистика(List<Человек> люди), который:

////    вычисляет сумму всех возрастов и средний возраст,

////    находит самого старшего и самого молодого человека,

////    возвращает эти значения Tuple<int, double, Человек, Человек>.

////Пользователь вводит 5 человек (имя и возраст отдельно).
///




            ////            12 – Поиск наибольшего числа

            ////            Дано:

            ////int[] числа = { 12, 56, 78, 2, 90, 43, 88, 67 };

            ////            Напишите программу, которая:

            ////    Находит наибольшее число в массиве(без использования Max()).

            ////    Выводит индекс этого числа, а не только его значение.

            ////    Использует цикл for.

            //int[] nums = { 12, 56, 78, 2, 90, 43, 88, 67 };

            //int maxValue = nums[0];
            //int maxIndex = 0;

            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (nums[i] > maxValue)
            //    {
            //        maxValue = nums[i];
            //        maxIndex = i;
            //    }
            //}

            //Console.WriteLine($" : {maxValue}");
            //Console.WriteLine($"  : {maxIndex}");

            //13 
//            13 – Четные и нечетные числа

//Сгенерируйте List<int> из 20 случайных целых чисел.
//Используйте циклы, чтобы:

//    Вычислить:

//            Сумму парных чисел

//            Среднее значение непарных чисел

//        Подсчитать, сколько чисел больше 50

//    Используйте поочередно for, foreach и while

        }
    }
}