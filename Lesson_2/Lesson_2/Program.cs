using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Трус Алексей
//    Написать метод подсчета количества цифр числа.

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольное целое число");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine(NumberDigits(ref num));

            Console.ReadKey();

        }

        private static int NumberDigits(ref int num)
        {
            int count = 0;

            while (num > 0)
            {
                count++;
                num = num / 10;

            }
            return count;
        }
    }
}
