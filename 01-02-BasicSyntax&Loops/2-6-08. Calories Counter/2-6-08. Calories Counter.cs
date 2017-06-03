using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string integrate = string.Empty;

            int totalCalories = 0;

            for (int i = 1; i <= n; i++)
            {
                integrate = (Console.ReadLine()).ToLower();
                switch (integrate)
                {
                    case "cheese": totalCalories += 500; break;
                    case "tomato sauce": totalCalories += 150; break;
                    case "salami": totalCalories += 600; break;
                    case "pepper": totalCalories += 50; break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
