using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_03_EnglNameLastDigit
{
    class Program
    {


        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            var lastDigit = GetLastDigit(num);
            var lastDigitName = GetLastDigitName(lastDigit);
        }

        static string GetLastDigitName(long lastDigit)
        {
            string lastDigitName = string.Empty;

            switch (lastDigit)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;

                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("three");
                    break;

                case 4:
                    Console.WriteLine("four");
                    break;

                case 5:
                    Console.WriteLine("five");
                    break;

                case 6:
                    Console.WriteLine("six");
                    break;

                case 7:
                    Console.WriteLine("seven");
                    break;

                case 8:
                    Console.WriteLine("eight");
                    break;

                case 9:
                    Console.WriteLine("nine");
                    break;

                default:
                    break;
            }
            return lastDigitName;
        }

        static long GetLastDigit(long num)
        {
            long lastDigit = num % 10;
            return (int)Math.Abs(lastDigit);
        }
    }
}

