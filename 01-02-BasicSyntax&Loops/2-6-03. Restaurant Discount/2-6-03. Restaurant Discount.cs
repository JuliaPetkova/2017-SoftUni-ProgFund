using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string service = Console.ReadLine();

            double PriceSmallHall = 2500;
            double PriceTerrace = 5000;
            double PriceGreatHall = 7500;

            string hallName;
            double tottalPriceWithDiscpont;
            double tottalPriceWithDiscpontPerPerson;


            double normalService = 500;
            double goldService = 750;
            double platinumService = 1000;

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                Console.WriteLine($"We can offer you the {hallName}");
                switch (service)
                {
                    case "Normal":
                        tottalPriceWithDiscpont = (PriceSmallHall + normalService) * 0.95;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    case "Gold":
                        tottalPriceWithDiscpont = (PriceSmallHall + goldService) * 0.9;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    case "Platinum":
                        tottalPriceWithDiscpont = (PriceSmallHall + platinumService) * 0.85;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    default:
                        break;
                }


            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                Console.WriteLine($"We can offer you the {hallName}");
                switch (service)
                {
                    case "Normal":
                        tottalPriceWithDiscpont = (PriceTerrace + normalService) * 0.95;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    case "Gold":
                        tottalPriceWithDiscpont = (PriceTerrace + goldService) * 0.9;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    case "Platinum":
                        tottalPriceWithDiscpont = (PriceTerrace + platinumService) * 0.85;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    default:
                        break;
                }

            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                Console.WriteLine($"We can offer you the {hallName}");
                switch (service)
                {
                    case "Normal":
                        tottalPriceWithDiscpont = (PriceGreatHall + normalService) * 0.95;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    case "Gold":
                        tottalPriceWithDiscpont = (PriceGreatHall + goldService) * 0.9;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    case "Platinum":
                        tottalPriceWithDiscpont = (PriceGreatHall + platinumService) * 0.85;
                        tottalPriceWithDiscpontPerPerson = tottalPriceWithDiscpont / groupSize;
                        Console.WriteLine($"The price per person is {tottalPriceWithDiscpontPerPerson:F2}$");
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");

            }

        }
    }
}