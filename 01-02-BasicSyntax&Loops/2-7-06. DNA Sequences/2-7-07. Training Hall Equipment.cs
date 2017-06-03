using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int itemNum = int.Parse(Console.ReadLine());

            string itemName = string.Empty;
            double itemPrice = 0;
            int itemCount = 0;

            double sum = 0;

            for (int num = 1; num <= itemNum; num++)
            {

                itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                itemCount = int.Parse(Console.ReadLine());

                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                sum = sum + itemPrice;
            }
            Console.WriteLine();
        }
    }
}
