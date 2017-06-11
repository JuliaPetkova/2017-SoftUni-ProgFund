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
            string str = Console.ReadLine();

            char[] arr = new char[26]; // 26 are the Engl alphabet

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (char)(97 + i);
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i] + " -> " + Array.IndexOf(arr, str[i]));
            }

        }
    }
}
