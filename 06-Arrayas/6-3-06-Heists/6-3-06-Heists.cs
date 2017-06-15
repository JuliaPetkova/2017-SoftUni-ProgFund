using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_06_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prices = Console.ReadLine().Split(' ');
            int priceJewels = int.Parse(prices[0]);
            int priceGold = int.Parse(prices[1]);

            long totalEarnings = 0;
            long totalExpences = 0;

            string line = Console.ReadLine();

            while (line != "Jail Time")
            {
                string[] currentInput = line.Split(' ');

                string loot = currentInput[0];
                int currentExpences = int.Parse(currentInput[1]);

                foreach (char symbol in loot)
                {
                    if (symbol == '%')
                    {
                        totalEarnings += priceJewels;
                    }
                    else if (symbol == '$')
                    {
                        totalEarnings += priceGold;
                    }
                }

                totalExpences += currentExpences;

                line = Console.ReadLine();
            }

            long diff = Math.Abs(totalEarnings - totalExpences);

            if (totalEarnings >= totalExpences)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {diff}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {diff}.");
            }
        }
    }
}
