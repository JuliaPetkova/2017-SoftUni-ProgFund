using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_02_AppenedLists
{
    class AppenedList
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split('|').ToList();

            Console.WriteLine(string.Join(" ",list));           
            List<string> number = new List<string>();

            foreach (var item in list)
            {
                if (item != "|")
                {
                    number.Add(item);

                }
            }
            Console.WriteLine(number);
        }
    }
}
