﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int num1 = a; num1 <= b; num1++)
            {
                for (int num2 = a; num2 <= b; num2++)
                {
                    for (int num3 = a; num3 <= b; num3++)
                    {
                        for (int num4 = a; num4 <= b; num4++)
                        {
                            for (int num5 = a; num5 <= b; num5++)
                            {
                                bool condition = ((a <= num1) && (num1 < num2) && (num2 < num3) && (num3 < num4) && (num4 < num5) && (num5 <= b));
                                if (condition == true)
                                {
                                    Console.WriteLine($"{num1} {num2} {num3} {num4} {num5}");
                                    counter++;
                                }                              
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
