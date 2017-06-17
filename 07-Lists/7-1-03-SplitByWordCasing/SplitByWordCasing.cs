using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_03_SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] delimeter = new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' };
            var inputText = Console.ReadLine().Split(delimeter, StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerLetters = new List<string>();
            List<string> mixedLetters = new List<string>();
            List<string> upperLeter = new List<string>();

            int lowerChars = 0;
            int upperChars = 0;
            int mixChars = 0;


            foreach (var item in inputText)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] >= 97 && item[i] <= 122)
                    {
                        lowerChars++;
                    }
                    else if (item[i] >= 65 && item[i] <= 90)
                    {
                        upperChars++;
                    }
                    else
                    {
                        mixChars++;
                    }
                }

                if (lowerChars > 0 && upperChars > 0 || mixChars > 0)
                {
                    mixedLetters.Add(item);
                }
                else if (lowerChars == 0)
                {
                    upperLeter.Add(item);
                }
                else
                {
                    lowerLetters.Add(item);
                }
                lowerChars = 0;
                upperChars = 0;
                mixChars = 0;
            }

            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerLetters));

            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedLetters));

            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upperLeter));
        }
    }
}
