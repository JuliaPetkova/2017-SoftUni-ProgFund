using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_02_MaxMethod
{
    class Program
    {
        static void GetMax()
        {          
            int maxNum = int.MinValue;

            for (int i = 1; i <= 3; i++)
            {
                int num  = int.Parse(Console.ReadLine());
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine(maxNum);

        }

        static void Main(string[] args)
        {
            GetMax();
        }
    }
}
