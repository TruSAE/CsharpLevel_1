using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).

namespace NumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите меньшее целое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число, большее первого");
            int b = int.Parse(Console.ReadLine());

            NumConsWrite(a, b);

            Console.ReadKey();
        }
            static void NumConsWrite(int a, int b)
            {
                Console.WriteLine(a);
                if (a < b) NumConsWrite(a + 1, b);
            }
                 
    }
}

