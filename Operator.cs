using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TextAnalyser

{
    public class Operator
    {

        public static void optionSelector(string choice, string input)
        {
            Functions handler = new Functions();

            // Split the choice string into individual characters
            foreach (char c in choice)
            {
                switch (c)
                {
                    case '1':
                        handler.FindDuplicateLetters(input);
                        break;

                    case '2':
                        handler.Vcount(input);
                        break;

                    case '3':
                        handler.CountVowelsAndNonVowels(input);
                        break;

                    default:
                        Console.WriteLine("Invalid option: " + c);
                        break;
                }
            }
        }

    }
}





