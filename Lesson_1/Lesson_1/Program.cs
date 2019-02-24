using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст,
//рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию");
            var surname = Console.ReadLine();

            Console.WriteLine("Сколько Вам лет");
            var age = Console.ReadLine();

            Console.WriteLine("Каков Ваш рост (формат ввода: м,см)");
            var height = Console.ReadLine();

            Console.WriteLine("Сколько Вы весите (формат ввода: кг,гр)");
            var weight = Console.ReadLine();

            Console.WriteLine("Приветсвуем Вас, " + surname + name + ", Ваш возраст " + age +  ", рост " + height + "м, масса тела " + weight + "кг" );

            Console.ReadKey();




        }
    }
}
