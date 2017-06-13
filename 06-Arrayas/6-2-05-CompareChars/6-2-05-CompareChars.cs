﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_05_CompareChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int minLength = Math.Min(arr1.Length, arr2.Length);

            if (arr1.Length < arr2.Length)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
            else if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < minLength; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                        return;
                    }
                    else if (arr1[i] >= arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                        return;
                    }  
                }
            }
        }
    }
}
