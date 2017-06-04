using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_12_BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double volume = 1;
            double tempVolume = 1;

            string nameBiggestKeg = string.Empty;
            string nameKeg = string.Empty;


            for (int i = 0; i < n; i++)
            {
                nameKeg = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int heigh = int.Parse(Console.ReadLine());

                tempVolume = Math.PI * r * r * heigh;

                if (tempVolume > volume)
                {
                    volume = tempVolume;
                    nameBiggestKeg = nameKeg;
                }
            }
            Console.WriteLine(nameBiggestKeg);
        }
    }
}
