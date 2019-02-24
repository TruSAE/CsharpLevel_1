using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных
//положительных чисел.

namespace SummODDPositiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число или несколько чисел подряд, разделяя их нажатием на Enter");
            int summ = 0;

            int num = int.Parse(Console.ReadLine());
            
            while (num != 0)
            {
                if (num > 0 && num % 2 != 0)
                {
                    summ = summ + num;
                }
                num = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Сумма введенных нечётных положительных чисел " + summ);

            Console.ReadKey();


        }
    }
}
