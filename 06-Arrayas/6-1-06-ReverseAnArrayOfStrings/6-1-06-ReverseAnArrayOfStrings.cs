using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_06_ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            Array.Reverse(array);

            foreach (string value in array)
            {
                Console.Write(value+' ');
            }
            Console.WriteLine();
        }
    }
}