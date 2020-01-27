using System;

namespace Capstone1PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = "y";
            while (userResponse == "y")
            {
                string sentence = "";
                while (sentence == "")
                {
                    sentence = GetUserInput("please enter a phrase");
                }
                string[] sentenceArray = sentence.Split();
               
                foreach (string word in sentenceArray)
                {
                    string newWord = ToPigLatin(word);
                    Console.Write(newWord + " ");
                }
                Console.WriteLine();
               userResponse = IsValidGoAgain("Would you like to enter another phrase?");
             }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string IsValidGoAgain(string message)
        {

            string userResponse = "";
            while (userResponse != "y" && userResponse != "n")
            {


                Console.WriteLine(message);
                userResponse = Console.ReadLine().ToLower();


            }
            return userResponse;
        }

       
        static string ToPigLatin(string word)
        {
            char[] vowels = { 'a','e','i','o','u' };
            string vowel = "aeiou";

            string firstLetter = word.Substring(0, 1);
            string firstLetters = word.Substring(0, word.IndexOfAny(vowels));
            string restOfWord = word.Substring(word.IndexOfAny(vowels), word.Length - word.IndexOfAny(vowels));
            int currentLetter = vowel.IndexOf(firstLetter);
            

            if (currentLetter == -1)
            {
               return word = restOfWord + firstLetters + "ay";
            }
            else
            {
                return word + "way";
            }

        }


    }
}
