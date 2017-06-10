using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_05_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideTriangle = double.Parse(Console.ReadLine());
            double heighTriangle = double.Parse(Console.ReadLine());

            var newValue = Area(sideTriangle, heighTriangle);
            Console.WriteLine(newValue);
        }

        private static object Area(double sideTriangle, double heighTriangle)
        {
            return sideTriangle * heighTriangle / 2;
        }
    }
}
