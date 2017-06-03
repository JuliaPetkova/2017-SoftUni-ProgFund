using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception) 
                {                          
                    break;
                }
            }
            Console.WriteLine(count);

        }
    }
}
