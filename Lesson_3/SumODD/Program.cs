using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму
//вывести на экран, используя tryParse.

namespace SumODD
{
    class Program
    {
        private static int NewMethod(string message, out int x)
        {
            string s;
            bool flag; 
            do
            {
                Console.WriteLine(message);
                s = Console.ReadLine(); // Если перевод произошел неправильно, то результатом будет false , т.е. 0;

                flag = int.TryParse(s, out x);
            }
            while (!flag);
            return x;
        }

        static void Main(string[] args)
        {
            string message = "Введите число:";
            
                int x;
                int summ = 0;

            while (NewMethod(message, out x) != 0)
            {
                
                if (x > 0 && x % 2 != 0)
                    {
                    summ = summ + x;
                    Console.WriteLine("Сумма введенных нечётных положительных чисел " + summ);
                    Console.WriteLine("Нечётное положительное число " + x);
                    }
                }
            Console.ReadKey();
        }
    }
}

