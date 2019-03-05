using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char b = 'B', c = '\x64', d = '\uffff';
                Console.WriteLine($"{b}, {c}, {d}");//, b, c, d);
                Console.WriteLine($"{char.ToLower(b)}, {char.ToUpper(c)}, {char.GetNumericValue(d)}");//, char.ToLower(b), char.ToUpper(c), char.GetNumericValue(d));
                char a;
                do // цикл выполняется, пока не ввели символ e
                {
                    Console.WriteLine("Введите символ: ");
                    a = char.Parse(Console.ReadLine());
                    Console.WriteLine($"Введен символ {a}, его код {(int)a}, его категория {char.GetUnicodeCategory(a)}");//, a, (int)a , char.GetUnicodeCategory (a));
                if (char.IsLetter(a)) Console.WriteLine("Буква");
                    if (char.IsUpper(a)) Console.WriteLine("Верхний регистр");
                    if (char.IsLower(a)) Console.WriteLine("Нижний регистр");
                    if (char.IsControl(a)) Console.WriteLine("Управляющий символ");
                    if (char.IsNumber(a)) Console.WriteLine("Число");
                    if (char.IsPunctuation(a)) Console.WriteLine("Разделитель");
                } while (a != 'e');
            }
            catch
            {
                Console.WriteLine("Возникло исключение");
            }
            Console.ReadKey();
        }
    }
}
