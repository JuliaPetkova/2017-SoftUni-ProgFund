using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_14_BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());

            int movesCount = int.Parse(Console.ReadLine());

            int scoreBoat1 = 0;
            int scoreBoat2 = 0;

            for (int moveIndex = 1; moveIndex <= movesCount; moveIndex++)
            {
                string inputStr = Console.ReadLine();

                if (inputStr == "UPGRADE")
                {
                    boat1 += (char)3;
                    boat2 += (char)3;
                    continue;
                }
                if (moveIndex % 2 == 1)
                {
                    scoreBoat1 += inputStr.Length;
                }
                else
                {
                    scoreBoat2 += inputStr.Length;
                }

                if (scoreBoat1 >= 50)
                {
                    Console.WriteLine(boat1);
                    return;
                }
                if (scoreBoat2 >= 50)
                {
                    Console.WriteLine(boat2);
                    return;
                }

            }

            Console.WriteLine((scoreBoat1 > scoreBoat2) ? boat1 : boat2);

        }
    }
}
