using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_11_StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine().ToLower();
            int stringNumbers = int.Parse(Console.ReadLine());

            string strConcatenation = string.Empty;

            for (int i = 1; i <= stringNumbers; i++)
            {
                string strName = Console.ReadLine();

                switch (evenOdd)
                {
                    case "even":
                        if (i % 2 == 0)
                        {
                            strConcatenation = strConcatenation + strName + delimeter;
                        }
                        break;
                    case "odd":
                        if (i % 2 != 0)
                        {
                            strConcatenation = strConcatenation + strName + delimeter;
                        }
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine($"{strConcatenation.TrimEnd(delimeter)}");
        }
    }
}
