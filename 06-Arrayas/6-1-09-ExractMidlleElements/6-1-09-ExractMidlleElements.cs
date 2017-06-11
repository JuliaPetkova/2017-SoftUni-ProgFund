using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_09_ExractMidlleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int midPointArr = arr.Length / 2;

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }
            else if (arr.Length % 2 == 0)
            {
                Console.WriteLine($"{arr[midPointArr - 1]} {arr[midPointArr]}");
            }
            else
            {
                Console.WriteLine($"{arr[midPointArr - 1]} {arr[midPointArr]} {arr[midPointArr + 1]}");
            }
        }
    }
}
