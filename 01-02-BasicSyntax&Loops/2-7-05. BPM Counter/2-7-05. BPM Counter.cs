using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = double.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());

            double bars = Math.Round((beats / 4), 1);

            double bps = bpm / 60; // how many beats per sec

            double sec = beats / bps;

            Console.WriteLine($"{bars} bars - {(int)sec / 60}m {(int)sec % 60}s");
        }
    }
}
