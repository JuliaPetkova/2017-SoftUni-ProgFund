using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_0_Hints_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = SmallestNumSumDigits(23);
            Console.WriteLine(num);
        }

        static int SmallestNumSumDigits(int num)
        {
            num = 0;
            while (true)
            {
                if (SumOfDigits(num) == num)
                {

                }
            }
        }
    }
}
