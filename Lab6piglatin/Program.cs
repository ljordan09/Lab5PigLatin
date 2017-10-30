using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6piglatin
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to the Pig Latin Translator!\n");
            bool run = true;
            while (run == true)
            {
                //ask for input
                Console.Write("Enter a line to be translate:");
                string inputRequested = Console.ReadLine();
                inputRequested.ToLower();
                //check to see if user entered a string
                if (inputRequested.Length == 0)
                {
                    Console.WriteLine("You did not enter a word.");
                }
                string indexZero = inputRequested.Substring(0, 1);
                string translate = " ";
                int x = 1;
                int z = inputRequested.Length;
                z = z - 1;
                char vowel;                
                bool lookingForVowels = false;                
                //if it starts with a vowel concat with way
                if (indexZero == "a" || indexZero == "e" || indexZero == "i" || indexZero == "o" || indexZero == "u")
                {
                    translate = inputRequested + "way";
                    Console.WriteLine(translate);
                    indexZero = "y";
                    lookingForVowels = true;
                }
                //if it starts with a const move to the back and concat with ay
                while (lookingForVowels == false)
                {
                    vowel = inputRequested[x];
                    x++;

                    if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                    {
                        string consonant = inputRequested.Remove(0, (x - 1));
                        string chopped = inputRequested.Substring(0, (x - 1));
                        string pigLatinConsonant = string.Concat(consonant, chopped, "ay");
                        Console.WriteLine(pigLatinConsonant);
                        lookingForVowels = true;                        
                    }
                }
                run = Continue();
            }
            
        //ask if user wants to do it again, if so loop back up
        public static bool Continue()
        {
            Console.WriteLine("\nTranslate another line? (y/n):");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
                Console.WriteLine(" ");
            }
            else if (input == "n")
            {
                goOn = false;
                Console.WriteLine("\nOk, I hope you found what you needed.");
            }
            else
            {
                Console.WriteLine("I only accept y or n. Please try again.");
                goOn = Continue();
            }
            return goOn;
        }
    }
}
