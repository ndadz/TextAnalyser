using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyser
{
    public class Functions
    {
        public int Vcount(string input)
        {
            input.ToLower();
            List<char> repeatedChars = new List<char>(); 

            int vowelCount = 0;
            foreach (char c in input)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    if (!repeatedChars.Contains(c)) 
                    {
                        repeatedChars.Add(c);
                        vowelCount++;
                    }
                        
                }
            }

            // Display the number of vowels
            Console.WriteLine("\nNumber of vowels: " + vowelCount);
            return vowelCount;
        }


        public void CountVowelsAndNonVowels(string input)
        {

            int vowelCount = 0;
            int nonVowelCount = 0;

            // Loop through each character and count the number of vowels and non-vowels
            foreach (char c in input.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
                else if (char.IsLetter(c))
                {
                    nonVowelCount++;
                }
            }

            // Compare the number of vowels and non-vowels and display the result
            if (vowelCount > nonVowelCount)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nNumber of vowels is greater than the number of non-vowels");
            }
            else if (vowelCount < nonVowelCount)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nNumber of non-vowels is greater than the number of vowels");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThe number of vowels is equal to the number of non-vowels");
            }
        }

        public void FindDuplicateLetters(string input)
        {

            // Split the input string into an array of individual characters
            char[] letters = input.ToCharArray();

            ArrayList duplicates = new ArrayList();

            // Loop through each letter and check for duplicates
            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = i + 1; j < letters.Length; j++)
                {
                    if (letters[i].ToString().ToLower() == letters[j].ToString().ToLower())
                    {
                        // Add the duplicate letter to the ArrayList
                        if (!duplicates.Contains(letters[i]) && letters[i] != ' ')
                        {
                            duplicates.Add(letters[i]);

                        }
                    }
                }
            }

            // Display the duplicates
            if (duplicates.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThe following letters were duplicates:  ");
                foreach (char letter in duplicates)
                {
                    Console.Write($"{letter}\t");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo duplicates were found.");
            }
        }





    }
}




