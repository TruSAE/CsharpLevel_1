using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.


namespace ExchangeValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            var num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите воторе число");
            var num2 = Int32.Parse(Console.ReadLine());

            // var temp = num1;
            //num1 = num2;
            //num2 = temp;
            num1 = num1 + num2;
            num2 = num2-num1;
            num2 = -num2;
            num1 = num1 - num2;


            Console.WriteLine($"После обмена ваши данные таковы: первое {num1} число , второе число {num2}");
               

            Console.ReadKey();

        }
    }
}
