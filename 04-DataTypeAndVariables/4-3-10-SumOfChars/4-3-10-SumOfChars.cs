﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_10_SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum = sum + letter;                
            }
            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}