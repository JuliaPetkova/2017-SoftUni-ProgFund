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
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int litters = int.Parse(Console.ReadLine());

                if (sum + litters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum = sum + litters;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
