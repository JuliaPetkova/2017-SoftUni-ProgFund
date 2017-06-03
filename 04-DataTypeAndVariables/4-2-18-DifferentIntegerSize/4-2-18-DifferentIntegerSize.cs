using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_18_DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            // sbyte < byte < short < ushort < int < uint < long

            var inputNum = Console.ReadLine();

            bool isInRange = false;
            string dataType = "";

            try
            {
                sbyte sbyteNum = sbyte.Parse(inputNum);
                dataType += "* sbyte\n";
                isInRange = true;
            }
            catch (Exception)
            {
            }

            try
            {
                byte byteNum = byte.Parse(inputNum);
                dataType += "* byte\n";
                isInRange = true;
            }
            catch (Exception)
            {
            }

            try
            {
                short shortNum = short.Parse(inputNum);
                dataType += "* short\n";
                isInRange = true;
            }
            catch (Exception)
            {
            }

            try
            {
                ushort ushortNum = ushort.Parse(inputNum);
                dataType += "* ushort\n";
                isInRange = true;
            }
            catch (Exception)
            {
            }

            try
            {
                int intNum = int.Parse(inputNum);
                dataType += "* int\n";
                isInRange = true;
            }
            catch (Exception)
            {
            }

            try
            {
                uint uintNum = uint.Parse(inputNum);
                dataType += "* uint\n";
                isInRange = true;
            }
            catch (Exception)
            {
            }

            try
            {
                long longNum = long.Parse(inputNum);
                dataType += "* long\n";
                isInRange = true;
            }
            catch (Exception)
            {
            }

            if (isInRange)
            {
                Console.WriteLine("{0} can fit in:", inputNum);
                Console.WriteLine(dataType);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", inputNum);
            }
        }
    }
}