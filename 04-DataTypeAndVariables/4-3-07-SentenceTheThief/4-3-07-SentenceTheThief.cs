using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_07_SentenceTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataTypeId = Console.ReadLine();

            int countIDs = int.Parse(Console.ReadLine());

            long biggerId = 0;

            if (dataTypeId == "sbyte")      // sbyte
            {
                biggerId = sbyte.MinValue;
                sbyte tempId = sbyte.MinValue;

                for (int i = 1; i <= countIDs; i++)
                {
                    try
                    {
                        sbyte numID = sbyte.Parse(Console.ReadLine());
                        tempId = numID;

                        if (tempId > biggerId)
                        {
                            biggerId = tempId;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            else if (dataTypeId == "int")       //int
            {
                biggerId = int.MinValue;
                int tempId = int.MinValue;

                for (int i = 1; i <= countIDs; i++)
                {
                    try
                    {
                        int numID = int.Parse(Console.ReadLine());
                        tempId = numID;

                        if (tempId > biggerId)
                        {
                            biggerId = tempId;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            else if (dataTypeId == "long")      // lon
            {
                biggerId = long.MinValue;
                long tempId = long.MinValue;

                for (int i = 1; i <= countIDs; i++)
                {
                    try
                    {
                        long numID = long.Parse(Console.ReadLine());
                        tempId = numID;

                        if (tempId > biggerId)
                        {
                            biggerId = tempId;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }


            if (biggerId > 0)
            {
              
                long sentence = (long)Math.Ceiling((decimal)biggerId / sbyte.MaxValue);
                Console.WriteLine($"Prisoner with id {biggerId} is sentenced to {sentence} " + (sentence > 1 ? "years" : $"year"));
            }
            else
            {
                long sentence = (long)Math.Ceiling((decimal)biggerId / sbyte.MinValue);
                Console.WriteLine($"Prisoner with id {biggerId} is sentenced to {sentence} " + (sentence > 1 ? "years" : $"year"));
            }
        }
    }
}
