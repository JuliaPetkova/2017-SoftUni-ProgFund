using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_01_BlankReceipt
{
    class Program
    {
        static void PritReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void PrintPeceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceipt()
        {
            PritReceiptHeader();
            PrintPeceiptBody();
            PrintReceiptFooter();
        }

        static void Main(string[] args)
        {
            PrintReceipt();
        }
    }
}
