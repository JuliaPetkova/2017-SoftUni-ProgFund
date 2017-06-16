using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int min = MinValue(arr);
            Console.WriteLine($"Min = {min}");
 
        }

        static int MinValue(int[] arr)
        {
            foreach (var item in arr)
            {
                min
            }
        }
    }

}


