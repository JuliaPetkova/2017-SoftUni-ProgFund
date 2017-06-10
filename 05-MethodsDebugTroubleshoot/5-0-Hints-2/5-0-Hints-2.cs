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
            double num = Math.Abs(double.Parse(Console.ReadLine()));
            var reversedNum = ReverseNumber(num);
            Console.WriteLine(reversedNum);
        }

        static double ReverseNumber(double num)
        {
            string number = num.ToString();
            number = number.Reverse();
        }
    }
}
