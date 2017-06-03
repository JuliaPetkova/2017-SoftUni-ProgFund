using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_03_ExactSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <=n; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum = sum + num;
            }

            Console.WriteLine($"{sum}");
        }
    }
}
