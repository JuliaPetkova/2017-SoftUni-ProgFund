using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_01_MaxSequenseOfEqualNum
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int num = 0;
            int maxCount = 0;
            int count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                count = 0;
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[i] != input[j])
                    {
                        continue;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (maxCount < count)
                {
                    num = input[i];
                    maxCount = count;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
