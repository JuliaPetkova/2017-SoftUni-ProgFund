using System;
using System.Linq;


namespace _program
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int count = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = i+1; j <= arr.Length - 1; j++)
                {
                    sum = arr[i] + arr[j];

                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{i} + {j} == {sum}");
                        count += 1;
                    }
                }

            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }          

        }
    }
}
