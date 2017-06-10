using System;


namespace _5_2_01_Hello
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HelloName(name);
        }

        static void HelloName(string name)
        {

            Console.WriteLine($"Hello, {name}!");
        }
    }
}
