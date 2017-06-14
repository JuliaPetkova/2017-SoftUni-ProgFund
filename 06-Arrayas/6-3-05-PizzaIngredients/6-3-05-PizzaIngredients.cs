using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_05_PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int ingradientLenght = int.Parse(Console.ReadLine());

            List<string> pizaProducts = new List<string>();
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentString = arr[i];

                if (currentString.Length == ingradientLenght)
                {
                    count++;
                    Console.WriteLine($"Adding {currentString}.");
                    pizaProducts.Add(currentString);

                    if (pizaProducts.Count == 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine("The ingredients are: " + string.Join(", ", pizaProducts) + ".");
        }
    }
}
