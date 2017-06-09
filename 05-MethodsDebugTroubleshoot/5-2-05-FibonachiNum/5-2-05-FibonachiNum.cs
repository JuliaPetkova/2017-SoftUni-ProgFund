using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_05_FibonachiNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int num0 = 1;
            int num1 = 1;

            if (number == num0 || number == num1)
            {
                sum = 1;
                Console.WriteLine(sum);
            }
            else if (number<0)
            {

            }
            else
            {
                FibonachiNumber();
            }

        }

        private static int FibonachiNumber()
        {
            for (int i = 1; i <= num; i++)
            {

            }
        }
    }
}
