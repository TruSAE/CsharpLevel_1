using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
//массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


namespace IndexMass
{
    class Program
    {
        static void Main(string[] args)
        {
            int index1 = 19;
            
            int index2 = 25;
            
            Console.WriteLine("Введите свой рост");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ведите массу тела");
            double m = Convert.ToDouble(Console.ReadLine());

            var indexMass = m / (Math.Pow(h, 2));

            if (indexMass < 19)
            {
                var mOpt = index1 * (Math.Pow(h, 2)) - m;
                Console.WriteLine($"Масса тела низкая, Вам необходимо поправиться хотя бы на  {mOpt} кг");
            }
            else if (indexMass > 25)
            {
                var mOpt = m - index2 * (Math.Pow(h, 2));
                Console.WriteLine($"Масса тела высокая, Вам необходимо сбросить хотя бы  {mOpt} кг");
            }
            else
            {
                Console.WriteLine("Масса тела оптимальна");
            }

            Console.ReadKey();
        }
    }
}
