using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_07_07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            List<int> primeList = FindPrimesInRange(start, end); //

            for (int i = 0; i < primeList.Count; i++)
            {
                Console.Write(primeList[i]);
                if (i != primeList.Count - 1)
                {
                    Console.Write(", ");
                }
            }
        }

        private static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> result = new List<int>();

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

