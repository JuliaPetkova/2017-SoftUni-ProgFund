﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_03_LastK_numbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] array = new long[n];

            array[0] = 1;

            for (int i = 1; i <= n - 1; i++)
            {
                int start = Math.Max(0, i - k);
                long sum = 0;

                for (int j = start; j <= i - 1; j++)
                {
                    sum += array[j];
                }
                array[i] = sum;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}