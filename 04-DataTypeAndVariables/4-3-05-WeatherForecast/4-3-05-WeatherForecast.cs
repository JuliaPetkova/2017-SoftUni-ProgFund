using System;


namespace _4_3_05_WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string num2 = Console.ReadLine();
            long num;

            try
            {
                num = long.Parse(num2);
            }
            catch
            {
                Console.WriteLine("Rainy");
                return;

            }

            if (num >= byte.MinValue && num <= byte.MaxValue)
            {
                Console.WriteLine("Sunny");
                return;
            }
            else if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
                return;
            }

            else if (num >= int.MinValue && num <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
                return;
            }
            else if (num >= long.MinValue && num <= long.MaxValue)
            {
                Console.WriteLine("Windy");
                return;
            }

        }
    }
}
