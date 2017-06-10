using System;


namespace _5_2_04_NumOfReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Math.Abs(double.Parse(Console.ReadLine()));
            Console.WriteLine(ReversedNum(num));
        }

        static double ReversedNum(double num) //static string ReversedNum(double num)
        {
            string numString = num.ToString();
            string result = string.Empty;

            for (int i = (numString.Length - 1); i >= 0; i--)
            {
                result += numString[i];
            }
              
            return double.Parse(result);                                 // without return reversedString;
        }
    }
}
