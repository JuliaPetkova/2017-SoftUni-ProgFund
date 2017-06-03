using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newWord;

            bool wordY = word.EndsWith("y"); // проверка дали завършва на "Y"
            string newStr = word.Remove(word.Length - 1, 1); // премахва последния символ от стринга

            bool wordY = word.EndsWith("y");
            bool wordZ = word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh");
            bool wordZZ = word.EndsWith("ch") || word.EndsWith("sh");


            if (wordY == true)
            {
                newWord = word.Remove(word.Length - 1, 1);
                Console.WriteLine($"{newWord}ies");
            }
            else if (wordZ == true)
            {
                Console.WriteLine($"{word}es");
            }
            else
            {
                Console.WriteLine($"{word}s");

            }
        }
    }
}
