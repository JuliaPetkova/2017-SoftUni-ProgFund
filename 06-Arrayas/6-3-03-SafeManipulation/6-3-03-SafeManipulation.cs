using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_03_SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            while (true)
            {
                string[] commandString = Console.ReadLine().Split(' ');
                string command = commandString[0];

                if (command == "END")
                {
                    break;
                }

                switch (command)
                {
                    case "Distinct":
                        arr = arr.Distinct().ToArray();
                        break;

                    case "Reverse":
                        Array.Reverse(arr);
                        break;

                    case "Replace":
                        int index = int.Parse(commandString[1]);

                        if (index < 0 || index >= arr.Length)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        string wordToReplace = commandString[2];
                        arr[index] = wordToReplace;
                        break;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }


            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}


