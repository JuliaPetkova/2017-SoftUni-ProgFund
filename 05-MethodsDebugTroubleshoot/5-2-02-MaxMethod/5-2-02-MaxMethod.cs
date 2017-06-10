using System;


namespace _5_2_02_MaxMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNum = GetMax(num1, num2, num3);
            Console.WriteLine(maxNum);
        }

        private static int GetMax(int num1, int num2, int num3)
        {
            int max = Math.Max((Math.Max(num1, num2)), num3);
            return max;
        }
    }
}
