using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int priceJewels = prices[0];
            int priceGold = prices[1];

            long earnings = 0;
            long expensеs = 0;

            string str = Console.ReadLine();

            while (str != "Jail Time")
            {
                string[] currentStr = str.Split(' ');

                string priceEarns = currentStr[0];
                long priceExps = long.Parse(currentStr[1]);

                expensеs += priceExps;

                foreach (char item in priceEarns)
                {
                    if (item == '%')
                    {
                        earnings += priceJewels;
                    }
                    if (item == '$')
                    {
                        earnings += priceGold;
                    }
                }
                str = Console.ReadLine();
            }


            long total = Math.Abs(earnings - expensеs);
            if (earnings >= expensеs)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {total}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {total}.");
            }

        }
    }

}


