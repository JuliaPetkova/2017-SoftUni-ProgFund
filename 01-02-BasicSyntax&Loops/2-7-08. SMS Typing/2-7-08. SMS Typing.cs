using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string num = string.Empty;
            string sms = string.Empty;

            for (int letter = 1; letter <= n; letter++)
            {
                num = Console.ReadLine();

                switch (num)
                {
                    case "2": num = "a"; break;
                    case "22": num = "b"; break;
                    case "222": num = "c"; break;

                    case "3": num = "d"; break;
                    case "33": num = "e"; break;
                    case "333": num = "f"; break;

                    case "4": num = "g"; break;
                    case "44": num = "h"; break;
                    case "444": num = "i"; break;

                    case "5": num = "j"; break;
                    case "55": num = "k"; break;
                    case "555": num = "l"; break;

                    case "6": num = "m"; break;
                    case "66": num = "n"; break;
                    case "666": num = "o"; break;

                    case "7": num = "p"; break;
                    case "77": num = "q"; break;
                    case "777": num = "r"; break;
                    case "7777": num = "s"; break;

                    case "8": num = "t"; break;
                    case "88": num = "u"; break;
                    case "888": num = "v"; break;

                    case "9": num = "w"; break;
                    case "99": num = "x"; break;
                    case "999": num = "y"; break;
                    case "9999": num = "z"; break;

                    case "0": num = " "; break;


                    default:
                        break;
                }


                sms = sms + num;
            }
            Console.WriteLine(sms);
        }
    }
}
