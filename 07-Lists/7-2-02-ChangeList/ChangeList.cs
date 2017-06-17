using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_02_ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] action = Console.ReadLine().Split().ToArray();

            while ((action[0] != "Odd") || (action[0] != "Even"))
            {
                switch (action[0])
                {
                    case "Delete":
                        input.RemoveAll(item => item == int.Parse(action[1]));
                        break;

                    case "Insert":
                        input.Insert(int.Parse(action[2]), int.Parse(action[1]));
                        break;

                    default:                        
                        break;
                }

                action = Console.ReadLine().Split().ToArray();
            }

            List<int> outputList = new List<int>();

            if (action[0].Equals("Odd"))
            {
                CheckOddNums(input, outputList);
            }

            if (action[0].Equals("Even"))
            {
                CheckEvenNums(input, outputList);
            }
        }

        static void CheckEvenNums(List<int> input, List<int> outputList)
        {
            foreach (var element in input)
            {
                if (element % 2 == 0)
                {
                    outputList.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", outputList));
        }

        static void CheckOddNums(List<int> input, List<int> outputList)
        {
            foreach (var element in input)
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
