using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_08_RefactorVolumePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, widht, height;

            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            widht = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double volume = (lenght * widht * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
