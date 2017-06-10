using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_11_GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            double area;

            switch (figure)
            {
                case "triangle":
                    double b = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());
                    CalculationTriangleArea(b, h);
                    break;

                case "square":
                    double a = double.Parse(Console.ReadLine());
                    CalculationSquareArea(a);
                    break;

                case "rectangle":
                    double w = double.Parse(Console.ReadLine());
                    double h1 = double.Parse(Console.ReadLine());
                    CalculationRectArea(w, h1);
                    break;

                case "circle":
                    double r = double.Parse(Console.ReadLine());
                    CalculationCircArea(r);
                    break;

                default:
                    break;
            }

        }

        private static void CalculationCircArea(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"{area:F2}");
        }

        private static void CalculationRectArea(double w, double h1)
        {
            double area = w * h1;
            Console.WriteLine($"{area:F2}");
        }

        private static void CalculationSquareArea(double a)
        {
            double area = Math.Pow(a, 2);
            Console.WriteLine($"{area:F2}");


        }

        private static void CalculationTriangleArea(double b, double h)
        {
            double area = (b * h) / 2;
            Console.WriteLine($"{area:F2}");
        }
    }
}
