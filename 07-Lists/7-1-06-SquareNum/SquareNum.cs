using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_06_SquareNum
{
    class SquareNum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list = new List<int>();

            foreach (var number in input)
            {
                double currentSqrt = Math.Sqrt(number);
                               
                if (currentSqrt % 1 == 0)
                {
                    list.Add(number);
                }
            }
                       
            list.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
