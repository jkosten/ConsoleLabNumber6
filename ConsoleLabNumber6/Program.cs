using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabNumber6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.Write("Please enter a line (in English) to be translated:");
            string input = Console.ReadLine();
            string vowels = "aeiou";

            string[] words = input.Split(' ');

            foreach (string word in words)
            {

                if (IsFirstLetterVowel(word))
                    Console.Write(word + "way" + " ");

                else
                {
                    int vowelPosition = word.IndexOfAny(vowels.ToCharArray());
                    if (vowelPosition == -1)
                    {
                        Console.Write(word + "ay" + " ");
                    }
                    else
                    {
                        string beforeVowel = word.Substring(0, vowelPosition);
                        string afterVowel = word.Substring(vowelPosition);

                        Console.Write(afterVowel + beforeVowel + "ay" + " ");
                    }
                }
            }
        }
        public static bool IsFirstLetterVowel(string word)
        {
            word = word.ToLower();
            if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
            { return true; }

            else
            { return false; }
        }
    }
}
