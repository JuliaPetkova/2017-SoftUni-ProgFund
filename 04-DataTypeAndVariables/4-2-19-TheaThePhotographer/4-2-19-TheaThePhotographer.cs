﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _4_2_19_TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double allPics = double.Parse(Console.ReadLine());
            double filterTime = double.Parse(Console.ReadLine());
            double goodPics = double.Parse(Console.ReadLine());

            goodPics = Math.Ceiling((allPics * goodPics) / 100.0);
            double uploadTime = double.Parse(Console.ReadLine());

            double totalTime = (allPics * filterTime) + (goodPics * uploadTime);
            TimeSpan newTime = TimeSpan.FromSeconds((long)totalTime);

            Console.WriteLine("{0:d1}:{1:d2}:{2:d2}:{3:d2}", newTime.Days, newTime.Hours, newTime.Minutes, newTime.Seconds);
        }
    }
}