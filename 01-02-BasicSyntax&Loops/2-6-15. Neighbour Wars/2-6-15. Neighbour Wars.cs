using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());


            int pointsPesho = 100;
            int pointsGosho = 100;

            int strike = 0;
            int strikePesho = 0;
            int strikeGosho = 0;

            while ((pointsGosho > 0) && (pointsPesho > 0))
            {

                if (strike % 3 == 0 && strike != 0)
                {
                    pointsGosho = pointsGosho + 10;
                    pointsPesho = pointsPesho + 10;
                }

                strikePesho++;
                strike++;
                pointsGosho = pointsGosho - damagePesho;

                if ((pointsGosho > 0) && (pointsPesho > 0))
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {pointsGosho} health.");
                }
                else
                {
                    Console.WriteLine($"Pesho won in {strike}th round.");
                    break;
                }

                strikeGosho++;
                strike++;
                pointsPesho = pointsPesho - damageGosho;

                if ((pointsGosho > 0) && (pointsPesho > 0))
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pointsPesho} health.");
                }
                else
                {
                    Console.WriteLine($"Pesho won in {strike}th round.");
                    break;
                }


            }
        }
    }
}