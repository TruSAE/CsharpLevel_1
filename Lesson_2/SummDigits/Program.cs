using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int s = 0;
            int count = 0;

            //Console.WriteLine(SumDigits(a));
            for (int i = 1; i <= 1_000_000; i++)
            {
                SumDigits(a);
                if (a % s == 0)
            {
                    count++;
            }

            }
            Console.WriteLine(count);
            Console.ReadKey();
            
        }
        static long SumDigits(long a)
        {
            long s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;
            }
            return s;
        }
    }
}
