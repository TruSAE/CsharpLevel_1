using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
//y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
//используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
//метода.


namespace Сoordinate
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordin();

            Console.ReadKey();

        }

        private static void Coordin()
        {
            int x1, x2, y1, y2;

            Console.WriteLine("Введите значение начальной точки по оси Х");
            x1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение начальной точки по оси У");
            y1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение конечной точки по оси Х");
            x2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение конечной точки по оси У");
            y2 = Int32.Parse(Console.ReadLine());

            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Длина отрезка с заданными координатами:  {r:f2}");
        }
    }
}
