﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_10_10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}");

                for (int j = 0; j < i; j++)
                {
                    Console.Write($" {i + 1}");
                }
                Console.WriteLine();

            }

        }
    }
}
