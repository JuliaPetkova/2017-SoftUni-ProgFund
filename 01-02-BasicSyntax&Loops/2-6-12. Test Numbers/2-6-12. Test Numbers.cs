using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stopLevel = int.Parse(Console.ReadLine());

            int num1 = 0;
            int num2 = 0;

            int sum = 0;
            int combinations = 0;

            for (int i = n; i >= 1; i--)
            {
                num1 = i;

                for (int j = 1; j <= m; j++)
                {
                    num2 = j;
                    combinations++;

                    sum = sum + 3 * num1 * num2;

                    if (sum >= stopLevel)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {stopLevel}");
                        return;
                    }
                    
                }
            }
            if (sum < stopLevel)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
