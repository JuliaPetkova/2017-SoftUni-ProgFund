using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_04_SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var primes = new bool[num + 1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int i = 0; i <= num; i++)
            {
                if (!primes[i])
                {
                    continue;
                }

                Console.Write(i + " ");

                for (int k = 2*i; k <= num; k+=i)
                {
                    primes[k] = false;
                }

            }
            Console.WriteLine();
        }
    }
}
