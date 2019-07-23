using System;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userInput;
            
                Console.WriteLine("Hi, welcome to the Pig Latin translator!");

            while(true)
            {
                Console.WriteLine("Please enter word to be translated.");

                userInput = Console.ReadLine().ToLower();

                PigLatinTranslator(userInput);

                Console.ReadLine();

                Console.WriteLine("Would you like to translate another word? y/n");
                string answer = Console.ReadLine();
                if (answer != "y")
                {
                    Console.WriteLine("Alright, thanks for playing!");
                    return;
                }
                
            }

        }







        public static void PigLatinTranslator(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int indexVowel = word.IndexOfAny(vowels);

            string firstLetter = word.Substring(indexVowel);
            string restOfWord = word.Substring(0, indexVowel);

            if (indexVowel == 0)
            {
                Console.WriteLine(word + "way");
                
            }
            else if (indexVowel != 0)
            {
                Console.WriteLine(firstLetter + restOfWord + "ay");

            }
         
        }



            
    }


}

