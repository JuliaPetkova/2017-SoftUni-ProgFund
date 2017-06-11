using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_09_IndexOfLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] arr = new char[26]; // 26 are the Engl alphabeta

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(97 + i);
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] + " -> " + Array.IndexOf(arr, word[i]));
            }

        }
    }
}
