using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_03_SumAdjusentEqualNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLits = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            bool equals = true;
            
            for (int i = 0; i < inputLits.Count - 1; i++)
            {
                equals = inputLits[i] == inputLits[i + 1];
                if (equals)
                {
                    inputLits[i] = inputLits[i] + inputLits[i + 1];
                    //inputLits.RemoveAt(i + 1);
                    inputLits.Remove(inputLits[i + 1]);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", inputLits));
        }
    }
}
