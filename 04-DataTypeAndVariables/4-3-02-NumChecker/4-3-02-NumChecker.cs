using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_02_NumChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            string resultType = string.Empty;

            if (inputNumber.Contains('.'))
            {
                resultType = "floating-point";
            }
            else
            {
                resultType = "integer";
            }

            Console.WriteLine(resultType);
        }
    }
}

