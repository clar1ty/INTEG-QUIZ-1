using System;
using System.Collections.Generic;
using BL;
using System.Linq;


namespace UI
{
    class Program

    {
        static List<string> showoptions = new List<string>()
                    {
                        "(1) Show me courier list.",
                        "(2) Lemme create an account.",
                        "(3) Lemme delete  a nub account.",
                        "(4) NVM, just exit."
                    };
        static void Main(String[] args)
        {
            ProcessActionsForAdmin();
            
        }
        static public void ShowOptions()
        {
            Console.WriteLine("Sup admin, wachu wanna do now?\n");

            foreach (var option in showoptions)
            {
                Console.WriteLine(option);
            }
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
        static void CreateNewAccount()
        {
            CMSLogic.CreateAnAccount();
        }

        static void DeleteAnAccount()
        {
            CMSLogic.DeleteAnAccount();
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
                        CMSLogic.DisplayCourierData();
                        break;
                    case 2:
                        Console.Clear();
                        CreateNewAccount();
                        break;
                    case 3:
                        Console.Clear();
                        DeleteAnAccount();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("What are you doing!? Try again bruh!");
                        break;
                }
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("Application exiting...");
            Console.ReadKey();
        }
    }
}