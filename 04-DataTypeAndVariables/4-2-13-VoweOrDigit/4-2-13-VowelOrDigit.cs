using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_13_VoweOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {

       
                string symbol = Console.ReadLine();

                bool isDig = ((symbol == "0") || (symbol == "1") || (symbol == "2") || (symbol == "3") || (symbol == "4") || (symbol == "5") || (symbol == "6") || (symbol == "7") || (symbol == "8") || (symbol == "9"));
                bool isVowel = (symbol == "а") || (symbol == "e") || (symbol == "i") || (symbol == "o") || (symbol == "u");
                if (isVowel == true)
                {
                    Console.WriteLine("vowel");
                }
                else if (isDig == true)
                {
                    Console.WriteLine("digit");
                }
                else
                {
                    Console.WriteLine("other");
                }
        }
    }
}
