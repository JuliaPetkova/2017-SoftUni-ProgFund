using System;

namespace _5_1_06_MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());

            double mathPower = MathPower(num, powerNum);
            Console.WriteLine(mathPower);

        }

        private static double MathPower(double num, double powerNum)
        {
            return Math.Pow(num, powerNum);
        }
    }
}
