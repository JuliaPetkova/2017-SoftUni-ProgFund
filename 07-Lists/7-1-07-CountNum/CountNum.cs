using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_07_CountNum
{
    class CountNum
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort();

            int countEquals = 1;

            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[i] == input[j])
                    {
                        countEquals++;
                    }
                }
                Console.WriteLine($"{input[i]} -> {countEquals}");
                i = i + (countEquals - 1);
                countEquals = 1;
            }
        }
    }
}