using System;


namespace _5_2_04_DrawFilledSquare
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintLine(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }

            PrintLine(n);

        }

        private static void PrintBody(int n)
        {
            Console.Write('-');

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');

        }

        static void PrintLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
