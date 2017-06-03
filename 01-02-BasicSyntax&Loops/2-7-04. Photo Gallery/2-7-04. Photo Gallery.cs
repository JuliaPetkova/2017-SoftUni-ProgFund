using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int date = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{number:D4}.jpg");
            Console.WriteLine($"Date Taken: {date:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");

            if (size < 1000)
            {
                Console.WriteLine($"Size: {size}B"); 
            }
            else if (size > 1000000)
            {
                size = size / 1000000;
                Console.WriteLine($"Size: {size:F1}MB"); 
            }
            else
            {
                Console.WriteLine($"Size: {size / 1000}KB"); 
            }
            

            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (height > width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}
