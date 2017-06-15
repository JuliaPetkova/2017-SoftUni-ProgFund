using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_05_PizzaIngredients_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allProducts = Console.ReadLine().Split();
            int letters = int.Parse(Console.ReadLine());

            int count = 0;
            string products = string.Empty;

            for (int i = 0; i < allProducts.Length; i++)
            {
                if (allProducts[i].Length == letters)
                {
                    count++;
                    products = products + allProducts[i];
                    products = products + ", ";

                    Console.WriteLine($"Adding {allProducts[i]}.");

                    if (count == 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {products.Remove(products.Length - 2, 2)}.");
        }
    }
}
