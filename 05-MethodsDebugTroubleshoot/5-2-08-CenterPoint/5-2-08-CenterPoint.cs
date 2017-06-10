using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_08_CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distance1 = GetDistanceBetweenPoints(x1, y1);
            double distance2 = GetDistanceBetweenPoints(x2, y2);

            if (distance1 < distance2)
            {
                Console.WriteLine($"{x1}, {y1}");
            }
            else
            {
                Console.WriteLine($"{x2}, {y2}");
            }

            // Console.WriteLine(distanceToCenter1 < distanceToCenter2 ? $"({x1}, {y1})" : $"({x2}, {y2})");
        }

        static double GetDistanceBetweenPoints(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
