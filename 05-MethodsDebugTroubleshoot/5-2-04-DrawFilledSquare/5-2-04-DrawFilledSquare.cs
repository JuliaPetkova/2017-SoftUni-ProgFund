using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_04_DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFirstLastLine(n);
            PrintBodyLine(n);
            PrintFirstLastLine(n);

        }

        static void PrintBodyLine(int n)
        {
            Console.WriteLine("-"+new string('-', n-2));

        }

        static void PrintFirstLastLine(int n)
        {
            Console.WriteLine(new string('-', n));
        }

    }
}
