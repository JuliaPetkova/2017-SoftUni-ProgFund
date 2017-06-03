using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int num1 = 0;
            int num2 = 0;
            int sum = 0;
            int combinations = 0;
            int magicCount = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    num1 = i;
                    num2 = j;
                    sum = num1 + num2;
                    combinations++;

                    if (sum == magicNumber)
                    {
                        magicCount++;
                        Console.WriteLine($"Number found! {num2} + {num1} = {sum}");
                        return;
                    }
                }

            }
            if (magicCount == 0)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");

            }
        }
    }
}
