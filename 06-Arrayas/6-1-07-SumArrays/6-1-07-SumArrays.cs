using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_07_SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sum = new int[Math.Max(array1.Length, array2.Length)];

            if (array1.Length == array2.Length)
            {
                for (int i = 0; i <= array1.Length; i++)
                {
                    sum[i] = array1[i] + array2[i];
                    Console.Write(sum[i] + ' ');
                }
                Console.WriteLine();
            }

        }
    }
}
