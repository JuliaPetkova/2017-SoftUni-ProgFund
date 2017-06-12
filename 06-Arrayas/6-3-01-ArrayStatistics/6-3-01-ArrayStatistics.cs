using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_01_ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

                if (minNum > arr[i])
                {
                    minNum = arr[i];
                }
                else
                {
                    minNum = minNum;
                }

                if (maxNum < arr[i])
                {
                    maxNum = arr[i];
                }
                else
                {
                    maxNum = maxNum;
                }

            }
            double average = (double)sum / arr.Length;
            Console.WriteLine($"Min = {minNum}");
            Console.WriteLine($"Max = {maxNum}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average:F1}");
        }
    }
}
