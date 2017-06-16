using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, double>();
            students.Add("pesho", 5.33);
            students.Add("vercheto", 2.55);
            students.Add("Neda", 6.00);

            foreach (var item in students)
            {
                Console.WriteLine(item.Key + "-->" + item.Value);
            }

        }
    }
}
