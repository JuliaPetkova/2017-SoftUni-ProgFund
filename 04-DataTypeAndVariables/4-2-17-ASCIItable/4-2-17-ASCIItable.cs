using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_17_ASCIItable
{
    class Program
    {
        static void Main(string[] args)
        {
            int char1 = int.Parse(Console.ReadLine());
            int char2 = int.Parse(Console.ReadLine());

            for (char i = (char)char1; i <= (char)char2; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
