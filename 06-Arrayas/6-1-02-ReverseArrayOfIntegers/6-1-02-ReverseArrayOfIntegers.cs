using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_02_ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var arrayIntehgers = new int[n];
            for (int i = 0; i <= n - 1; i++)
            {
                arrayIntehgers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n-1; i >=0; i--)
            {
                Console.Write(arrayIntehgers[i]+" ");
            }
            Console.WriteLine();

        }
    }
}
