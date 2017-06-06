using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_04_NumOfReverseOrder
{
    class Program
    {
        static void PrintNumberInReverseOrder()

        {
            double num = double.Parse(Console.ReadLine());
                        
            //int numDigits =num.L;
            num = double.ToString().ToCharArray();
            

            for (int i = 1; i <= numDigits; i++)
            {
                num = num % 10;               

                Console.Write(num);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //  PrintNumberInReverseOrder();
        }
    }
}
