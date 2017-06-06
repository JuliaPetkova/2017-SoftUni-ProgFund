﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_06_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(num);
            Console.WriteLine(isPrime);
        }

        private static bool IsPrime(long num)
        {
            bool isPrime = true;

            if (num == 0 || num == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++) // for (int i = 2; i < num; i++) too long
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
