using System;
using System.Collections.Generic;
using DL;

namespace UI
{
    class Program
    {
        static List<string> showoptions = new List<string>()
                    {
                        "(1) Show me courier list.",
                        "(2) Lemme update an account.",
                        "(3) Lemme delete  this nub.",
                        "(4) NVM, just exit."
                    };
        static void Main(string[] args)
        {
           
            ProcessActionsForAdmin();
        }

        static void ProcessActionsForAdmin()
        {
            for (int adminchoice = GetUserChoice();
                adminchoice != 4;
                adminchoice = GetUserChoice())
            {
                switch (adminchoice)
                {
                    case 1:
                        Console.Clear();
                        SqlData.DisplayCourierData();
                        break;
                    case 2:
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("What are you doing!? Try again bruh!");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Application exiting...");
            Console.ReadKey();
        }
        
        static int GetUserChoice()
        {
            try
            {
                ShowOptions();
                Console.Write("Choice: ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error occured. Please try again");
                return GetUserChoice();
            }
        }

        static void ShowOptions()
        {
            Console.WriteLine("Sup admin, wachu wanna do now?\n");

            foreach (var option in showoptions)
            {
                Console.WriteLine(option);
            }
        }
    }
}
