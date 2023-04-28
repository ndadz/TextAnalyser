using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyser
{
    public class DisplayScreen
    {
        public static void Display()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n================================ -----------------------------------------================================ \n");
            Console.WriteLine("\n================================  WELCOME TO THE TEXT ANALYSER CONSOLE APP  ================================ \n");
            Console.WriteLine("\n================================  ----------------------------------------- ================================ \n");
            Console.WriteLine("\nYou have been given a task to analyse any text? Great, this program will help you achieve the following: \n");
            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////////////////////////////////////////\n");

            Console.WriteLine("\n\t1. Duplicates Check\t\n");
            Console.WriteLine("\n\t2. Count the number of vowels\t\n");
            Console.WriteLine("\n\t3. Output if there are more vowels or non vowels\t\n");
            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////////////////////////////////////////\n");
            Console.WriteLine("\n\n*******************************[ Press any key to go to the next  page .......]********************************\n\n"); 

        }

        public static void closeKey()
        {
            Console.ReadKey();
        }

        public static string endApp()
        {

            return Console.ReadLine();     
      
        }

        public static void optionList()
        {
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n=============================================================================================================\n");
            Console.WriteLine(" Which operation would you like use on the supplied text?");
            Console.WriteLine("\nSelect From the list below.\n");
            Console.WriteLine("\t1-Duplicate Check\t");
            Console.WriteLine("\t2-Number of Unique Vowel Counter\t");
            Console.WriteLine("\t3-Unique Vowel or Non Vowel \t");
            Console.WriteLine("=============================================================================================================");

        }

        public static void userInteraction()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\t\t\t\tPlease Enter a string text you will like to Analyse: \t\t\t\t\n");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            
        }

        public static void CleanMethod()
        {
            Console.Clear();
        }
    }
}





