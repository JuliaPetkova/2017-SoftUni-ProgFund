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
            double[] price = Console.ReadLine().Split().Select(double.Parse).ToArray();

            string currentProduct = Console.ReadLine();


            while (currentProduct != "done")
            {

            }
        }
    }
