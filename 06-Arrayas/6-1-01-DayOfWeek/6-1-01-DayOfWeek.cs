using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_01_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(dayWeek[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
