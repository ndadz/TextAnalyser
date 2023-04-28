using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace TextAnalyser
{
    public class Program
    {



        static void Main(string[] args)
        {
            ConsoleApp();
            WhileLoop();

        }

        private static void WhileLoop()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\tWould you like to continue running the app? Press 'y' to continue or 'n' close App.\n\t");
            string close = DisplayScreen.endApp();

            while (close == "y")
            {
                ConsoleApp();

                if (close == "n") ;
                {
                    break;
                }



            }
        }

        private static void ConsoleApp()
        {
            DisplayScreen.Display();
            DisplayScreen.closeKey();

            DisplayScreen.CleanMethod();

            DisplayScreen.userInteraction();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string input = Console.ReadLine();
            input.ToLower();

            DisplayScreen.optionList();
            string choice = Console.ReadLine();
            Operator.optionSelector(choice, input);

            DisplayScreen.closeKey();
            DisplayScreen.CleanMethod();

            
            
        }

    }
}






