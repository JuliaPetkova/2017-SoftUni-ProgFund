using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            int sum = 0;
            int num = 1;

            for (int i = 0; i < n; i++)
            {
                sum = sum + num;
                Console.WriteLine(num);
                num += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

