using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            switch (day)
            {
                case "weekday":
                    if ((age <= 18 && age >= 0) || (age <= 122 && age > 64))
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine("18$");
                    }
                    break;

                case "weekend":
                    if ((age <= 18 && age >= 0) || (age <= 122 && age > 64))
                    {
                        Console.WriteLine("15$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine("20$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;

                case "holiday":
                    if (age <= 18 && age >= 0)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (age > 18 && age <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (age <= 122 && age > 64)
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }

        }
    }
}
