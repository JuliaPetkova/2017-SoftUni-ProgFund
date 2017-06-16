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
            var input = Console.ReadLine().Split('|').ToList(); //  "1 2 3 |4 5 6 |  7  8"
            input.Reverse();
            List<string> newList = new List<string>();

            foreach (var number in input)
            {
                var output = number.Split(' ').ToList(); // outout list with 3 elements --> "1 2 3 ", "4 5 6 ", "  7  8"

                foreach (var item in output)
                {
                    if (item != "")             //escape " "
                    {
                        newList.Add(item);
                    }
                }
            }
            //newList.Reverse();
            if (newList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", newList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
