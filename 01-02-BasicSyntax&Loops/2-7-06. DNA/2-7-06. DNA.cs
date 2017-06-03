using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_06.DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            int count = 0;

            for (int firstDig = 1; firstDig <= 4; firstDig++)
            {
                for (int secondDig = 1; secondDig <= 4; secondDig++)
                {
                    for (int thirdDig = 1; thirdDig <= 4; thirdDig++)
                    {
                        count++;

                        if ((firstDig + secondDig + thirdDig) >= sum)
                        {
                            Console.Write("O" + ("" + firstDig + secondDig + thirdDig)
                                .Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "O ");

                        }
                        else
                        {
                            Console.Write("X" + ("" + firstDig + secondDig + thirdDig)
                                .Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T') + "X ");
                        }

                        if (count % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }

            }
        }
    }
}
