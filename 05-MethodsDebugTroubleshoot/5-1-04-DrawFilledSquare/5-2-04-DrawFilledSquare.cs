using System;


namespace _5_2_04_DrawFilledSquare
{
    class Program
    {
        static void Main()
        {
            var p = 10;
            var multuply = MultiPlyBy5(p);
           Console.WriteLine(multuply);
        }

        static int MultiPlyBy5(int p)
        {
            return 5 * p;
        }
    }
}
