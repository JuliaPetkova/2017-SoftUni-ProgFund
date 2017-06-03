using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_15_RefactorFastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 2; num <= n; num++)
            {
                bool isPrime = true; // Prime- дели се само на себе си и на 1
                for (int divider = 2; divider <= num / 2; divider++)
                {
                    if (num % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {isPrime}");

            }
        }
    }
}
