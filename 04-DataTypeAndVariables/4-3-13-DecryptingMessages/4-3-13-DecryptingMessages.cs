﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_13_DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            int numChars = int.Parse(Console.ReadLine());

            string message = string.Empty;
            
            for (int i = 1; i <= numChars; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int letterTemp = Convert.ToInt32(letter);

                int letterPlusKey = letterTemp + key;

                letter = Convert.ToChar(letterPlusKey);
                message += letter;
            }
            Console.WriteLine(message);
        }
    }
}
