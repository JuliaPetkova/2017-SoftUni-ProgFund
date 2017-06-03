using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_06_TriplesLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < (char)('a' + n); i++)
            {
                for (char j = 'a'; j < (char)('a' + n); j++)
                {
                    for (char k = 'a'; k < (char)('a' + n); k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
