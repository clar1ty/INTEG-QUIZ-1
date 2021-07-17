using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public class CMSLogic
    {
        static public void DisplayCourierData()
        {
            SqlData.DisplayCourierData();
        }
        static public void CreateAnAccount()
        {
            string name, id; int contact;
            Console.WriteLine("Yo, give me the following details:\n");

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("ID: ");
            id = Console.ReadLine();

            Console.Write("Contact Number: ");
            contact = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAccount successfully created dude!");
            Console.ReadKey();
            Console.Clear();

            SqlData.CreateAnAccount(name, id, contact);
        }
        static public void DeleteAnAccount()
        {
            SqlData.DisplayCourierData();

            Console.WriteLine("Yo, gimme the name of this nub u wanna DELETE!\n");
            Console.Write("Name: ");
            string name = Convert.ToString(Console.ReadLine());

            var VerifyIfAccountExist = SqlData.ValidateAccount(name);

            if (VerifyIfAccountExist.Equals("True"))
            {
                Console.WriteLine("Congrats! Nub deleted!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Error nub! Try again!");
                Console.ReadKey();
                Console.Clear();
                DeleteAnAccount();
            }

            SqlData.DeleteAnAccount(name);
        }
        

    }
}
