using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_04_TouristInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string imUnits = Console.ReadLine();
            double valueImUnits = double.Parse(Console.ReadLine());

            switch (imUnits)
            {
                case "miles":
                    double val = valueImUnits * 1.6;
                    Console.WriteLine($"{valueImUnits} {imUnits} = {val:F2} kilometers");
                    break;

                case "inches":
                    val = valueImUnits * 2.54;
                    Console.WriteLine($"{valueImUnits} {imUnits} = {val:F2} centimeters");
                    break;


                case "feet":
                    val = valueImUnits * 30;
                    Console.WriteLine($"{valueImUnits} {imUnits} = {val:F2} centimeters");
                    break;

                case "yards":
                    val = valueImUnits * 0.91;
                    Console.WriteLine($"{valueImUnits} {imUnits} = {val:F2} meters");
                    break;

                case "gallons":
                    val = valueImUnits * 3.8;
                    Console.WriteLine($"{valueImUnits} {imUnits} = {val:F2} liters");
                    break;
                default:
                    break;
            }
        }
    }
}
