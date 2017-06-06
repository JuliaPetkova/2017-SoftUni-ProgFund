using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_01_Hello
{
    class Program
    {
        static void HelloName()
        {

            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        static void Main(string[] args)
        {
           HelloName();
        }

    }
}
