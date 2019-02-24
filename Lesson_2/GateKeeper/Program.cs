using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Трус Алексей
//    Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. На
//выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password:
//GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
//вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
//цикла do while ограничить ввод пароля тремя попытками.



namespace GateKeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            var login = "root";
            string password = "GeekBrains";
            string log, pass;

            int i = 3;

            do
            {
                AskLodPass(out log, out pass);
                i--;
                if (log != login && pass != password)
                {
                    Console.WriteLine("Пара логин и пароль введена неверно.");
                    Console.WriteLine($"У вас осталось {i} попыток");
                }
                else
                {
                    Console.WriteLine("Доступ разрешен");
                    break;
                }

            } while (i > 0);

            Console.ReadKey();
        }
        private static void AskLodPass(out string log, out string pass)
        {
            

            Console.WriteLine("Введите логин");
            log = Console.ReadLine();

            Console.WriteLine("Введите пароль");
            pass = Console.ReadLine();
        }
    }
}
