using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
//I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

namespace WeightIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Каков Ваш рост (формат ввода: м,см)");
            var h = Double.Parse(Console.ReadLine());

            Console.WriteLine("Сколько Вы весите (формат ввода: кг,гр)");
            var m = Convert.ToDouble(Console.ReadLine());

            var I = m / (Math.Pow(h, 2));

            Console.WriteLine($"Индекс массы тела для Вас: {I:f2}");
            Console.ReadKey();

        }
    }
}
