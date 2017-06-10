using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_07_GreaterValues
{
    class Program
    {
        private static bool value;

        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMaxInt(first, second);
                Console.WriteLine(max);
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMaxChar(first, second);
                Console.WriteLine(max);
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetStringMax(first, second);
                Console.WriteLine(max);
            }
        }

        static int GetMaxInt(int first, int second)
        {
            return Math.Max(first, second);
        }

        static char GetMaxChar(char first, char second)
        {
            char max = ' ';
            if (first >= second) max = first; max = second;
            return max;
        }

        static string GetStringMax(string first, string second)
        {
            string max = " ";
            if (first.CompareTo(second) >= 0) max = first;
            else max = second;
            return max;
        }

    }
}
