using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_05_SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            input.Sort();

            Console.WriteLine(string.Join(" <= ", input));

        }
    }
}
