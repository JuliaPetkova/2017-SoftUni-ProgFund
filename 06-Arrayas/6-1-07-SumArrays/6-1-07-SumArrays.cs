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

            int[] sumArr = new int[Math.Max(array1.Length, array2.Length)];


            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] = array1[i % array1.Length] + array2[i % array2.Length];
            }
            Console.WriteLine(string.Join(" ", sumArr));
           
        }
    }
}
