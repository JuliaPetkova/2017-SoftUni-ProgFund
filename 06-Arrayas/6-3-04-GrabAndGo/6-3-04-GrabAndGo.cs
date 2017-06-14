using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_04_GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int findNum = int.Parse(Console.ReadLine());
            
            long sum = 0;
            int index;

            bool isNumberFaund = false;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == findNum)
                {
                    index = i;
                    isNumberFaund = true;
                    for (int j = 0; j < index; j++)
                    {
                        sum += arr[j];
                    }
                    break;
                }                 
            }
            if (isNumberFaund == false)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
