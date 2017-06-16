using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_01_RenoveNegativesReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();

            foreach (var item in numbers)
            {
                if (item > 0)
                {
                    newList.Add(item);
                }
            }
            newList.Reverse();
            if (newList.Count > 0)
            {
                Console.WriteLine(string.Join(", ", newList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
