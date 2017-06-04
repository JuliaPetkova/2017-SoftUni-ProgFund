using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_06_CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataTypeId = Console.ReadLine();

            int countIDs = int.Parse(Console.ReadLine());

            if (dataTypeId == "sbyte")
            {
                sbyte biggerId = sbyte.MinValue;
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
                        else
                        {
                            continue;
                        }
                    }

                    catch (Exception)
                    {
                    }
                }
                Console.WriteLine(biggerId);
            }


            else if (dataTypeId == "int")
            {
                int biggerId = int.MinValue;
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
                Console.WriteLine(biggerId);
            }

            else if (dataTypeId == "long")
            {
                long biggerId = long.MinValue;
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
                Console.WriteLine(biggerId);
            }

        }
    }
}

