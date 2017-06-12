using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_01_ArrayStatistics_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int min = CalculateMinimalValue(arr);
            int max = CalculateMaximalValue(arr);
            long sum = CalculateSimOfElements(arr);
            double average = (double)sum/arr.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {Math.Round(average,1)}");
        }

        private static long CalculateSimOfElements(int[] arr)
        {
            long sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        private static int CalculateMaximalValue(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        private static int CalculateMinimalValue(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
