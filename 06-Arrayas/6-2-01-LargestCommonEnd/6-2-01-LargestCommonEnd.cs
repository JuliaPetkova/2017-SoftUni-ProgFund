﻿using System;

namespace _6_2_01_LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split();
            var arr2 = Console.ReadLine().Split();

            int leftCount = 0;
            int rightCount = 0;

            int minLenght = Math.Min(arr1.Length, arr2.Length);
            
            for (int i = 0; i < minLenght; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    leftCount += 1;
                }

                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    rightCount += 1;
                }
            }
            Console.WriteLine(Math.Max(leftCount, rightCount));
        }
    }
}

