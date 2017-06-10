using System;
using System.Linq;


namespace _program
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
