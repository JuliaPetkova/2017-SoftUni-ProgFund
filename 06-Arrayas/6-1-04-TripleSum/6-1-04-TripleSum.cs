using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_04_TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int count = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    sum = array[i] + array[j];

                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                        count += 1;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
