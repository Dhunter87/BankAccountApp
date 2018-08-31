using System;
namespace SelfTrainingProject.BankAccount
{
    public class AdminProfile
    {
        public static string errorMessage = "Invalid input";
        public static readonly string adminUserName = "Admin123";
        public static readonly string adminPassword = "Admin321";

        public static void RunAdminProfile()
        {
            Console.WriteLine("Please enter 1 add new profile or type \"quit\" to exit : ");
            string entry3 = Console.ReadLine().ToLower();
            if (string.Equals(entry3, "quit"))
            {
                System.Environment.Exit(1);
            }
            else if (string.Equals(entry3, ""))
            {
				Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage);
                Console.ResetColor();           
            }
            try
            {
                int userEntry = int.Parse(entry3);
                if (userEntry == 1)
                {
                    NewProfile.addNewProfile();

                }
                else
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ResetColor();           
                }
            }
            catch (Exception)
            {
				Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(errorMessage + " Exception Handled!");
                Console.ResetColor();           
            }
        }
    }
}
