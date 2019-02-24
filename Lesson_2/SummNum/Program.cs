using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Трус Алексей
//    * Разработать рекурсивный метод, который считает сумму чисел от a до b.
namespace SummNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите меньшее целое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число, большее первого");
            int b = int.Parse(Console.ReadLine());
            int summN = 0;

            //for (int i = a; i <= b; i++)
            //{
            //    summN = summN + a;
            //    a = a + 1;
            //}

            //Console.WriteLine(summN);
            ////NumSumm(a, b, summN);
            ////Console.WriteLine(summN);
            ///
            Console.WriteLine(RecursMetod(a, b, summN));
            Console.ReadKey();
        }
            public static int RecursMetod(int a, int b, int summN)
            {
                if (a < b)
                {
                    //Console.Write(a + " ");
                    summN = summN + a;
                    RecursMetod(a, b, summN);
                }
                return summN;
            }



        //    if (a<b)
        //    {
        //        summN = summN + a;
        //        NumSumm(a + 1, b, summN);
        //    }
        //    Console.WriteLine(summN);
        //    Console.ReadKey();
        //}
        static int NumSumm(int a, int b, int summN)
        {
            summN = summN + a;
            if (a < b) NumSumm(a + 1, b, summN);
            return summN;
        }
    }
}
