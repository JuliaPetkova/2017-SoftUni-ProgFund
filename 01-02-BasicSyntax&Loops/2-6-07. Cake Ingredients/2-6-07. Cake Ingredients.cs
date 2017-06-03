using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string integrate = Console.ReadLine();

            while (integrate != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {integrate}.");
                count++;
                integrate = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");

        }
    }
}
