using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    struct Complex
    {
        public double im;
        public double re;
        
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }


        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительную часть первого комплексного числа");
            Complex complex1;
            complex1.re = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть первого комплексного числа");
            complex1.im = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите действительную часть второго комплексного числа");
            Complex complex2;
            complex2.re = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мнимую часть второго комплексного числа");
            complex2.im = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите произольное действие с введенными комплексными числами:\n +, -, *");

            char a = Convert.ToChar(Console.ReadLine());// "-"
            switch (a)
            {
                case '*' :
                    Complex result = complex1.Multi(complex2);
                    Console.WriteLine("Результат произведения комплексных чисел" + "(" + complex1.ToString() + ")" + "и" + "(" + complex2.ToString() + ")" + "=" + result.ToString());
                    break;
                case '-':
                    result = complex1.Minus(complex2);
                    Console.WriteLine("Результат вычитания комплексных чисел" + "(" + complex1.ToString() + ")" + "и" + "(" + complex2.ToString() + ")" + "=" + result.ToString());
                    break;
                case '+':
                     result = complex1.Plus(complex2);
                    Console.WriteLine("Результат сложения комплексных чисел" + "(" + complex1.ToString() + ")" + "и" + "(" + complex2.ToString() + ")" + "=" + result.ToString());
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
