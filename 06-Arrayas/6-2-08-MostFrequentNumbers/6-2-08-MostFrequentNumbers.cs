using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_08_MostFrequentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCount = 0;
            int number = 0;


            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    number = array[i];
                }
            }
            Console.WriteLine(number);
        }
    }
}
