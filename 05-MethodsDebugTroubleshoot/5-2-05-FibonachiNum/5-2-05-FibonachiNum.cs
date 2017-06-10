using System;


namespace _5_2_05_FibonachiNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumber(number));
        }

        private static int FibonacciNumber(int number)
        {

            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciNumber(number - 2) + FibonacciNumber(number - 1);
            }
        }
    }
}
