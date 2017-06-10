using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_08_MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int evens = GetSumOfEvens(n);
            int odds = GetSumOfOdds(n);

            Console.WriteLine(evens * odds);
        }

        private static int GetSumOfEvens(int n)
        {
            int evens = 0;

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    evens += n % 10;
                    n = n / 10;
                }
                else
                {
                    n = n / 10;
                }
            }
            return evens;
        }

        private static int GetSumOfOdds(int n)
        {
            int odds = 0;
            while (n > 0)
            {
                if (n % 2 != 0)
                {
                    odds += n % 10;
                    n = n / 10;
                }
                else
                {
                    n = n / 10;
                }
            }
            return odds;
        }
    }
}
