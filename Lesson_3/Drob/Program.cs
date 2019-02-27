using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drob
{

    class Program
    {
        class Drob
        {
            private int numer; //числитель
            private int denom; //знаменатель

            public Drob(int numer, int denom) // конструтор с проверкой на 0 в знаменателе
            {
                if (denom == 0)
                {
                    throw new ArgumentException("В знаменателе не может быть нуля");
                }
                this.numer = Math.Abs(numer);
                this.denom = Math.Abs(denom);
                }

            public override string ToString() // строковое представление для вывода на экран
            {
                return numer.ToString() + "/" + denom.ToString(); 
            }

            public static Drob SetFormat(Drob a) // сокращение дроби и получение знака дроби
            {
                int max = 0;
                if (a.numer > a.denom)
                {
                    max = Math.Abs(a.denom);
                }
                else
                {
                    max = Math.Abs(a.numer);
                }
                for (int i = max; i < 2; i--)
                {
                    if ((a.numer % i == 0) && (a.denom % i == 0))
                    {
                        a.numer = a.numer / i;
                        a.denom = a.denom / i;
                    }
                }
                if (a.denom < 0)
                {
                    a.numer = -1 * (a.numer);
                    a.denom = Math.Abs(a.denom);
                }
                return a;
            }

            public static Drob operator +(Drob a, Drob b)// сложение дробей
            {
                Drob t = new Drob(1, 1);
                t.numer = a.numer * b.denom + a.denom * b.numer;
                t.denom = a.denom * b.denom;
                SetFormat(t);
                return t;
            }

            public static Drob operator -(Drob a, Drob b)// вычитание дробей
            {
                Drob t = new Drob(1, 1);
                t.numer = a.numer * b.denom - a.denom * b.numer;
                t.denom = a.denom * b.denom;
                SetFormat(t);
                return t;
            }

            public static Drob operator *(Drob a, Drob b)// умножение дробей
            {
                Drob t = new Drob(1, 1);
                t.numer = a.numer * b.denom;
                t.denom = a.denom * b.numer;
                SetFormat(t);
                return t;
            }

            public static Drob operator /(Drob a, Drob b)// деление дробей
            {
                Drob t = new Drob(1, 1);
                t.numer = a.numer * b.denom;
                t.denom = a.denom * b.numer;
                SetFormat(t);
                return t;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель первой дроби");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель первой дроби");
            int z1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите знак действия с дробями");
            //char mod = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите числитель второй дроби");
            int c2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель второй дроби");
            int z2 = Convert.ToInt32(Console.ReadLine());

            Drob dr1 = new Drob(c1, z1);
            Drob dr2 = new Drob(c2, z2);

            Drob res = dr1 / dr2;
            Drob res1 = dr1 * dr2;
            Drob res2 = dr1 - dr2;
            Drob res3 = dr1 + dr2;

            Console.WriteLine($"Результат сложения дробей:\n" + dr1.ToString() + " + " + dr2.ToString() + " = " + res3.ToString());
            Console.WriteLine($"Результат деления дробей:\n" + dr1.ToString() + " / " + dr2.ToString() + " = " + res.ToString());
            Console.WriteLine($"Результат умножения дробей:\n" + dr1.ToString() + " * " + dr2.ToString() + " = " + res1.ToString());
            Console.WriteLine($"Результат вычитания дробей:\n" + dr1.ToString() + " - " + dr2.ToString() + " = " + res2.ToString());

            Console.ReadKey();
        }
    }
}
