using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_14_IntegerHexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int decValue = int.Parse(Console.ReadLine());

            //string hexValue = string.Format("{0:x}", decValue); вариант с форматиране
          
            string binary = Convert.ToString(decValue, 2); // 2- binary
            string hexValue = Convert.ToString(decValue, 16).ToUpper(); // 16-hexadecimal
            
            Console.WriteLine(hexValue);
            Console.WriteLine(binary);

        }
    }
}
