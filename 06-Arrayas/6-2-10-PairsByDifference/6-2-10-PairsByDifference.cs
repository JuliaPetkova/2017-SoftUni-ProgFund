using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_10_PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (array.Length == 1)
            {
                Console.WriteLine("0"); return;
            }

            int leftSum = 0;
            int rightSum = 0;
            bool isFound = false;

            for (int i = 0; i < array.Length; i++) 
            {

                for (int left = 0; left < i; left++)
                {
                    leftSum += array[left];
                }

                for (int right = i + 1; right < array.Length; right++)
                {
                    rightSum += array[right];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
                else
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (isFound == false)
            {
                Console.WriteLine("no");
            }
        }

    }
}

