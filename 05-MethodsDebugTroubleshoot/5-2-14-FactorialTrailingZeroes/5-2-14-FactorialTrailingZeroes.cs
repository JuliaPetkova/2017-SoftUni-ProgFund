using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _5_2_14_FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(number);
            int countZeroes = GetTailingZeroes(factorial);
            Console.WriteLine(countZeroes);
        }

        private static int GetTailingZeroes(BigInteger factorial)
        {
            int countZeros = 0;

            while (factorial % 10 == 0)
            {
                countZeros += 1;
                factorial = factorial / 10;
            }
            return countZeros;
        }

        private static BigInteger GetFactorial(int number)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
