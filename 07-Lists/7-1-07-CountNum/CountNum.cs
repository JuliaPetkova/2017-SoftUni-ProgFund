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

            List<int> list = new List<int>();
            int counter = 0;

            input.Sort();

            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[i] == input[j])
                    {
                        counter++;
                        list.Add(input[i]);
                    }
                }
                Console.WriteLine($"{input[i]} -> {list}");
                i = i + counter - 1;
                list = 1;
            }

        }
    }
}
