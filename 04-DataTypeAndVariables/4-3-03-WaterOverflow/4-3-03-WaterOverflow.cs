using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_03_WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            // double litters = 0;

            for (int i = 1; i <= n; i++)
            {
                double litters = double.Parse(Console.ReadLine());

                if (litters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    Console.WriteLine(0);
                    return;
                }
                else
                {
                    sum = sum + litters;

                    if (sum > 255.0)
                    {
                        Console.WriteLine("Insufficient capacity!");
                        sum -= litters;
                    }
                }
            }
            Console.WriteLine(sum);

        }
    }
}
