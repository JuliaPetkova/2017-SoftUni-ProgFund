using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_02_ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                string[] nameOfCoomands = Console.ReadLine().Split();
                string command = nameOfCoomands[0];

                switch (command)
                {
                    case "Reverse":
                        Array.Reverse(arr);
                        break;

                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;

                    case "Replace":
                        int index = int.Parse(nameOfCoomands[1]);
                        string wordToReplace = nameOfCoomands[2];
                        arr[index] = wordToReplace;
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", arr));

        }
    }
}
