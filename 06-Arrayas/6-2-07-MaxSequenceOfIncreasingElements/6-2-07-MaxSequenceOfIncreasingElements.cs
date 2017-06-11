using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_07_MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int maxCount = 0;
            int start = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        start = i - count;
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = start + 1; i <= start + maxCount + 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
