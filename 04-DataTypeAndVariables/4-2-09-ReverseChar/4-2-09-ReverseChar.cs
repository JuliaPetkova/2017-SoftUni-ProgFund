using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_09_ReverseChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            char x = a;
            a = c;
            c = x;
            Console.WriteLine($"{a}{b}{c}");

        }
    }
}
