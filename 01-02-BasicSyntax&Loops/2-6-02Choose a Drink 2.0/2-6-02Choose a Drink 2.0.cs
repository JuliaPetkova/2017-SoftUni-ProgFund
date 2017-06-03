using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_02Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double water = 0.70;
            double coffee = 1.00;
            double beer = 1.70;
            double tea = 1.20;

            switch (profession)
            {
                case "Athlete":
                    water = water * quantity;
                    Console.WriteLine($"The {profession} has to pay {water:F2}.");
                    break;

                case "Businessman":
                case "Businesswoman":
                    coffee = coffee * quantity;
                    Console.WriteLine($"The {profession} has to pay {coffee:F2}.");
                    break;

                case "SoftUni Student":
                    beer = beer * quantity;
                    Console.WriteLine($"The {profession} has to pay {beer:F2}.");
                    break;

                default:
                    tea = tea * quantity;
                    Console.WriteLine($"The {profession} has to pay {tea:F2}.");
                    break;
            }

        }
    }
}
