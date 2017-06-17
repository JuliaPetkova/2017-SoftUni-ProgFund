using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            List<int> nums = Console.ReadLine().Split(delimiter).Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split(delimiter).ToArray();

            while (!(command[0].Equals("Odd") || command[0].Equals("Even")))
            {
                switch (command[0])
                {
                    case "Delete":
                        nums.RemoveAll(item => item == int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        Console.WriteLine("No such command!");
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }

            List<int> outputList = new List<int>();

            if (command[0].Equals("Odd"))
            {
                CheckOddNums(nums, outputList);
            }

            if (command[0].Equals("Even"))
            {
                CheckEvenNums(nums, outputList);
            }
        }

        static void CheckEvenNums(List<int> nums, List<int> outputList)
        {
            foreach (var element in nums)
            {
                if (element % 2 == 0)
                {
                    outputList.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", outputList));
        }

        static void CheckOddNums(List<int> nums, List<int> outputList)
        {
            foreach (var element in nums)
            {
                if (element % 2 == 1)
                {
                    outputList.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}