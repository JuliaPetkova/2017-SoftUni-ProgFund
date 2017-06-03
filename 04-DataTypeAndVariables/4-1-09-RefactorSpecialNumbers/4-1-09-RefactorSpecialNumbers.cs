using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_09_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                bool isSpecial = true;
                num = i;
                int currentNum = i;

                while (num > 0)
                {
                    sum = sum + num % 10;
                    num = num / 10;
                }
                isSpecial = ((sum == 5) || (sum == 7) || (sum == 11));
                Console.WriteLine($"{currentNum} -> {isSpecial}");
            }
        }
    }
}
