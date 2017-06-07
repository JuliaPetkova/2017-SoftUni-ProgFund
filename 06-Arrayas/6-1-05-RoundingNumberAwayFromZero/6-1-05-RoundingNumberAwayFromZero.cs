using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_05_RoundingNumberAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] num = new int[array.Length];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                num[i] = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {num[i]}");
            }
        }
    }
}
