using System;

namespace PigLatinCapstone
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Get ready to translate from English to Pig Latin");

           Start:

            Console.WriteLine("Please enter a word?");

            string input = Console.ReadLine();
            

            //Output
            string piglatin = ToPigLatin(input).ToLower();

            Console.WriteLine(piglatin);


            //Continue?
            Console.WriteLine("Do you want to translate another word");
            string userResponse = Console.ReadLine();
            if (userResponse == "yes")
            {
                Console.WriteLine("Great!");
                goto Start;
            }
            else
            {
                Console.WriteLine("Goodbye");
            }



        }
        
        // Method to Translate
        public static string ToPigLatin(string sentence)
        {
            string vowels = "aeiouAEIOU";
            string returnSentence = "";


            foreach (string word in sentence.Split())
            {
                string firstLetter = word.Substring(0, 1);

                string restOfWord = word[1..]; //Simplified from 1, word.Length -1

                double currentLetter = vowels.IndexOf(firstLetter, StringComparison.Ordinal);

                if (currentLetter == -1)
                {
                    returnSentence += restOfWord + firstLetter + "ay ";
                }
                else
                {
                    returnSentence += word + "way ";
                }
            }
            return returnSentence;
        }
    }
}

