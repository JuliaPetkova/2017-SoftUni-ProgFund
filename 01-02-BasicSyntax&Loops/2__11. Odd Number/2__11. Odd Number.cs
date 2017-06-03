using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = Math.Abs(short.Parse(Console.ReadLine()));
            bool isEven = number % 2 == 0;

            while (isEven)
            {
                Console.WriteLine("Please write an odd number.");
                number = Math.Abs(short.Parse(Console.ReadLine()));
                isEven = number % 2 == 0;
            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}
