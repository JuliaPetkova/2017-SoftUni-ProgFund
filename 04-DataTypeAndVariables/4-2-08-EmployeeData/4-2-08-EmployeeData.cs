using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_08_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalId = long.Parse(Console.ReadLine());
            int uniqueNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: { lastName}\nAge: {age}\nGender: {gender}\nPersonal ID: {personalId}\nUnique Employee number: {uniqueNum}");
        }
    }
}
