using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_13_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            FactorialCalculation(num);

        }

        private static void FactorialCalculation(long num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

        }
    }
}
