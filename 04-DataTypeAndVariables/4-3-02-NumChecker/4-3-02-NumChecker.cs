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
            string str = Console.ReadLine();
            int numInt;
            float numFloat;

            bool isInt = int.TryParse(str, out numInt);
            bool isFloat = float.TryParse(str, out numFloat);


            if (isInt)
            {
                Console.WriteLine("integer");
            }
            else if (isFloat)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
