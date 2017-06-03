using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_01_CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            int years = century * 100;
            int days = (int)(years * 365.2422); // !!!
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{century} - {years} years - {days} days - {hours} hours - {minutes} minutes");
        }
    }
}
