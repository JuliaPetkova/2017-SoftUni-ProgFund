using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_07_InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string currentProduct = Console.ReadLine();

            while (currentProduct != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == currentProduct)
                    {
                        Console.WriteLine($"{products[i]} costs: {price[i]}; Available quantity: {quantity[i]}");
                    }
                }
                currentProduct = Console.ReadLine();
            }
        }
    }
}
