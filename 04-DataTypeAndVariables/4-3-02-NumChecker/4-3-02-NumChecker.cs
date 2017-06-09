using System;


namespace _4_3_02_NumChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine(); // var ---> not good idea

            try
            {
                long.Parse(number);      // int --->not good idea
                Console.WriteLine("integer");
            }
            catch
            {
                try
                {
                    double.Parse(number);
                    Console.WriteLine("floating-point");

                }
                catch
                {

                }
            }
        }
    }
}

