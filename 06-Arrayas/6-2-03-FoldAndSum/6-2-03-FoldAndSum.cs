using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_03_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = arr.Length / 4;
           
            // split arr[] on 3 parts

            var firstArray = new int[k];
            var middleArray = new int[2 * k];
            var lastArray = new int[k];

            var sum = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                firstArray[i] = arr[i];
                lastArray[i] = arr[3 * k + i];
            }

            Array.Reverse(firstArray);
            Array.Reverse(lastArray);

            for (int i = 0; i < 2 * k; i++)
            {
                middleArray[i] = arr[k + i];
            }

            for (int i = 0; i < k; i++)
            {
                sum[i] += firstArray[i] + middleArray[i];
                sum[i + k] += lastArray[i] + middleArray[i + k];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
