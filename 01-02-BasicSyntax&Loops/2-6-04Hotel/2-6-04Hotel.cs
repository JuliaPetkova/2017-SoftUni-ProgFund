using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;


            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    studioPrice = 50 * nights;
                    doublePrice = 65 * nights;
                    suitePrice = 75 * nights;

                }
                else
                {
                    studioPrice = (50 * nights) * 0.95;
                    doublePrice = 65 * nights;
                    suitePrice = 75 * nights;


                }

            }
            else if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    studioPrice = 60 * nights;
                    doublePrice = 72 * nights;
                    suitePrice = 82 * nights;

                }
                else
                {
                    studioPrice = 60 * nights;
                    doublePrice = (72 * nights) * 0.9;
                    suitePrice = 82 * nights;


                }

            }
            else if (month == "July" || month == "August" || month == "December")
            {
                if (nights <= 14)
                {
                    studioPrice = 68 * nights;
                    doublePrice = 77 * nights;
                    suitePrice = 89 * nights;

                }
                else
                {
                    studioPrice = 68 * nights;
                    doublePrice = 77 * nights;
                    suitePrice = (89 * nights) * 0.85;


                }

            }
            if (month == "September" && nights > 7)
            {
                studioPrice -= 60;

            }
            else if (month == "October" && nights > 7)
            {
                studioPrice -= 50 * 0.95;
            }

            Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
            Console.WriteLine("Double: {0:F2} lv.", doublePrice);
            Console.WriteLine("Suite: {0:F2} lv.", suitePrice);
        }
    }
}