using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_10_CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine(); //face, space, volume or area
            CalculateProperties(cubeSide, parameter);
        }

        private static void CalculateProperties(double cubeSide, string parameter)
        {
            if (parameter == "face")
            {
                double face = Math.Sqrt(Math.Pow(cubeSide, 2) * 2);
                Console.WriteLine("{0:F2}", face);
            }
            else if (parameter == "space")
            {
                double space = Math.Sqrt(Math.Pow(cubeSide, 2) * 3);
                Console.WriteLine("{0:F2}", space);
            }
            else if (parameter == "volume")
            {
                double volume = Math.Pow(cubeSide, 3);
                Console.WriteLine("{0:F2}", volume);
            }
            else if (parameter == "area")
            {
                double area = Math.Pow(cubeSide, 2) * 6;
                Console.WriteLine("{0:F2}", area);
            }
        }
    }
}
