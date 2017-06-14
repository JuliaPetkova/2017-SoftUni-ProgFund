using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            int numComands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numComands; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command.Length == 1)
                {
                    if (command[0] == "Reverse")
                    {
                        str = str.Reverse().ToArray();
                    }
                    else (command[0] == "Distinct")
                    {
                        str = str.Distinct().ToArray();
                    }

                    else
                    {
                        if (command[0] == "Replace")
                        {
                            int indexToReplace = int.Parse(command[1]);
                            string wordForReplacing = command[2];

                            str[indexToReplace] = wordForReplacing;
                        }
                    }
                }

                Console.WriteLine(string.Join(", ", str));
            }
        }
    }

}


