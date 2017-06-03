using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = (n - 1) / 2;

            for (int i = 1; i <= k; i++)
            {
                Console.WriteLine("{0}x{1}x{0}",
                 new string(' ', i - 1),
                 new string(' ', n - 2 * i));
            }
            Console.WriteLine("{0}x", new string(' ', k));

            for (int i = k; i >= 1; i--)
            {
                Console.WriteLine("{0}x{1}x{0}",
                 new string(' ', i - 1),
                 new string(' ', n - 2 * i));
            }
        }
    }
}
