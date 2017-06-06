using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_04_NumOfReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(ReversedNum(num));
        }

        static double ReversedNum(double num) //static string ReversedNum(double num)
        {
            string numString = num.ToString();
            string reversedString = string.Empty;

            for (int i = (numString.Length-1); i >= 0; i--)
            {
                reversedString += numString[i];
            }
            var reversedNum = double.Parse(reversedString); // without
            return reversedNum;                          // return reversedString;
        }
    }
}
