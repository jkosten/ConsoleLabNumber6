using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!" + Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Enter a sentence to convert to PigLatin:");
            string sentence = Console.ReadLine();
            string pigLatin = ToPigLatin(sentence);
            Console.WriteLine(pigLatin);
        }

        static string ToPigLatin(string sentence)
        {
            string firstLetter,
                   restOfWord,
                   vowels = "AEIOUaeiou";
            int currentLetter;

            foreach (string word in sentence.Split())
            {
                firstLetter = sentence.Substring(0, 1);
                restOfWord = sentence.Substring(1, sentence.Length - 1);
                currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    sentence = restOfWord + firstLetter + "ay";
                }
                else
                {
                    sentence = word + "way";
                }
            }
            return sentence;


        }
    }
}

