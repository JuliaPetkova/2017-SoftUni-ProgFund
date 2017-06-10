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


            double length1L2 = GetLength(x1, y1, x2, y2);
            double length3L4 = GetLength(x3, y3, x4, y4);

            double l1 = GetLengthToZeroPoint(x1, y1);
            double l2 = GetLengthToZeroPoint(x2, y2);
            double l3 = GetLengthToZeroPoint(x3, y3);
            double l4 = GetLengthToZeroPoint(x4, y4);


            if (length1L2 >= length3L4)
            {
                string smallestToZero = GetSmallestLengthToZero(l1, l2, l3, l4);
                Console.WriteLine(smallestToZero);
            }
            else
            {
                string smallestToZero = GetSmallestLengthToZero(l1, l2, l3, l4);
                Console.WriteLine(smallestToZero);
            }
        }

        static string GetSmallestLengthToZero(double l1, double l2, double l3, double l4)
        {
 
            string smallestToZero = string.Empty;

            if (l1 < l2)
            {
                smallestToZero = ($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                smallestToZero = ($"({x2}, {y2})({x1}, {y1})");
            }
            return smallestToZero;
        }


        static double GetLengthToZeroPoint(double x, double y)
        {
            return Math.Sqrt(Math.Pow((x), 2) + Math.Pow(y, 2));
        }

        static double GetLength(double xOne, double yOne, double xTwo, double yTwo)
        {
            double x = Math.Abs(xOne - xTwo);
            double y = Math.Abs(yOne - yTwo);
            return Math.Sqrt(Math.Pow((x), 2) + Math.Pow(y, 2));
        }
    }
}
