using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
//программу, демонстрирующую все разработанные элементы класса.




namespace Lesson_3
{

    class Program
    {
        public class Fraction   //(sealed)
        {
            private int numerator;              // Числитель
            private int denominator;            // Знаменатель
            private int sign;                   // Знак дроби
                                                //}

            public Fraction(int numerator, int denominator) // конструтор с проверкой на 0 в знаменателе
            {  
                if (denominator == 0)
                {
                    throw new ArgumentException("В знаменателе не может быть нуля");
                }
                this.numerator = Math.Abs(numerator);
                this.denominator = Math.Abs(denominator);

                if (numerator * denominator < 0) // Определяем знак дроби
                {
                    this.sign = -1;
                }
                else
                {
                    this.sign = 1;
                }
            }
            public Fraction(int number) : this(number, 1) { }// конструктор со знаменателем равным единице

            //    public Fraction(int a, int b)
            //{

            //}

            //{
            //    numerator = 0;
            //    denominator = 1;
            //}

            private static int NOD(int a, int b) // Возвращает наибольший общий делитель (Алгоритм Эвклида)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            private static int NOK(int a, int b) // Возвращает наименьшее общее кратное
            {
                return a * b / NOD(a, b);
            }



            public Fraction Plus(Fraction a)// сложение дробей

            {
                int u, v;

                u = numerator * a.denominator + denominator * a.numerator; v = denominator * a.denominator;

                return (new Fraction(u, v));

            }//Plus

            public static Fraction operator +(Fraction f1, Fraction f2)

            {

                return (f1.Plus(f2));

            }

            public Fraction Minus(Fraction a)

            {

                int u, v;

                u = numerator * a.denominator - denominator * a.numerator; v = denominator * a.denominator;

                return (new Fraction(u, v));

            }//Minus

            public static Fraction operator -(Fraction f1, Fraction f2)

            {

                return (f1.Minus(f2));

            }

            public Fraction Mult(Fraction a)

            {

                int u, v;

                u = numerator * a.numerator; v = denominator * a.denominator;

                return (new Fraction(u, v));

            }//Mult

            public static Fraction operator *(Fraction f1, Fraction f2)

            {

                return (f1.Mult(f2));

            }

            public Fraction Divide(Fraction a)

            {

                int u, v;

                u = numerator * a.denominator; v = denominator * a.numerator;

                return (new Fraction(u, v));

            }//Divide

            public static Fraction operator /(Fraction f1, Fraction f2)

            {

                return (f1.Divide(f2));

            }


            private static Fraction PerformOperation(Fraction a, Fraction b, Func<int, int, int> operation)
            {

                int leastCommonMultiple = NOK(a.denominator, b.denominator); // Наименьшее общее кратное знаменателей

                int additionalMultiplierFirst = leastCommonMultiple / a.denominator; // Дополнительный множитель к первой дроби

                int additionalMultiplierSecond = leastCommonMultiple / b.denominator; // Дополнительный множитель ко второй дроби

                int operationResult = operation(a.numerator * additionalMultiplierFirst * a.sign, b.numerator * additionalMultiplierSecond * b.sign); // Результат операции

                return new Fraction(operationResult, a.denominator * additionalMultiplierFirst);
            }


            //public static Fraction operator +(Fraction a, Fraction b) // Перегрузка оператора "+" для случая сложения двух дробей
            //{
            //    return PerformOperation(a, b, (int x, int y) => x + y);
            //}

            //public static Fraction operator +(Fraction a, int b) // Перегрузка оператора "+" для случая сложения дроби с числом
            //{
            //    return a + new Fraction(b);
            //}

            //public static Fraction operator +(int a, Fraction b) // Перегрузка оператора "+" для случая сложения числа с дробью
            //{
            //    return b + a;
            //}


            //public static Fraction operator -(Fraction a, Fraction b) // Перегрузка оператора "-" для случая вычитания двух дробей
            //{
            //    return PerformOperation(a, b, (int x, int y) => x - y);
            //}

            //public static Fraction operator -(Fraction a, int b) // Перегрузка оператора "-" для случая вычитания из дроби числа
            //{
            //    return a - new Fraction(b);
            //}

            //public static Fraction operator -(int a, Fraction b) // Перегрузка оператора "-" для случая вычитания из числа дроби
            //{
            //    return b - a;
            //}

            //public static Fraction operator *(Fraction a, Fraction b) // Перегрузка оператора "*" для случая произведения двух дробей
            //{
            //    return new Fraction(a.numerator * a.sign * b.numerator * b.sign, a.denominator * b.denominator);
            //}

            //public static Fraction operator *(Fraction a, int b) // Перегрузка оператора "*" для случая произведения дроби и числа
            //{
            //    return a * new Fraction(b);
            //}

            //public static Fraction operator *(int a, Fraction b) // Перегрузка оператора "*" для случая произведения числа и дроби
            //{
            //    return b * a;
            //}

            //public static Fraction operator /(Fraction a, Fraction b) // Перегрузка оператора "/" для случая деления двух дробей
            //{
            //    return a * b.GetReverse();
            //}

            //public static Fraction operator /(Fraction a, int b) // Перегрузка оператора "/" для случая деления дроби на число
            //{
            //    return a / new Fraction(b);
            //}

            //public static Fraction operator /(int a, Fraction b) // Перегрузка оператора "/" для случая деления числа на дробь
            //{
            //    return new Fraction(a) / b;
            //}

            
            private Fraction GetReverse() // Возвращает дробь, обратную данной
            {
                return new Fraction(this.denominator * this.sign, this.numerator);
            }
            
            private Fraction GetWithChangedSign() // Возвращает дробь с противоположным знаком
            {
                return new Fraction(-this.numerator * this.sign, this.denominator);
            }


            public Fraction Reduce() // Возвращает сокращенную дробь
            {
                Fraction result = this;
                int greatestCommonDivisor = NOD(numerator, denominator);// this.
                result.numerator /= greatestCommonDivisor;
                result.denominator /= greatestCommonDivisor;
                return result;
            }

            public void PrintFraction(string name)

            {


                Console.WriteLine(" {0}/{1}",numerator, denominator);// name, 

            }



            static void Main(string[] args)
            {
                //Fraction test = new Fraction(2, 5);
                //Fraction test1 = new Fraction(3, 7);
                //test.PrintFraction();// + test1);
                Console.ReadKey();
            }
        }
    }
}
