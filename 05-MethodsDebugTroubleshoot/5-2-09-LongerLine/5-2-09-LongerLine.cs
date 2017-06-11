using System;

namespace _5_2_09_LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double length1 = FindLengthLOfLine(x1, y1, x2, y2);
            double length2 = FindLengthLOfLine(x3, y3, x4, y4);

            if (length1 >= length2)
            {
                bool isCloserToZero = FindClosedPointToZero(x1, y1, x2, y2);
                Console.WriteLine(isCloserToZero ? $"({x1}, {y1})({x2}, {y2})" : $"({x2}, {y2})({x1}, {y1})");
            }
            else if (length1 < length2)
            {
                bool isCloserToZero = FindClosedPointToZero(x3, y3, x4, y4);
                Console.WriteLine(isCloserToZero ? $"({x3}, {y3})({x4}, {y4})" : $"({x4}, {y4})({x3}, {y3})");
            }
        }

        private static double FindLengthLOfLine(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            //can be used to find length of all lines!!!
        }

        private static bool FindClosedPointToZero(double x1, double y1, double x2, double y2)
        {
            //can be used to find length form any point to zeroPoint (0;0)!!!

            double z1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double z2 = Math.Sqrt(x2 * x2 + y2 * y2);
            bool isCloserToZero = true;

            if (z1 < z2)
            {
                isCloserToZero = true;
            }
            else if (z1 > z2)
            {
                isCloserToZero = false;
            }

            return isCloserToZero;
        }
    }
}
