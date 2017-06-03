using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_07_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {name} {lastName}. You are {age} years old.");
            // \r ---> премахва всичко напред, табулация
            // \n ---> нов ред

        }
    }
}
