using System;
namespace SelfTrainingProject.BankAccount
{
    public class ExampleProfile
    {
        public static string errorMessage = "Invalid input";

        public static void RunExampleProfile()
        {
            int l = 0;

            ExampleProfile.GetAccountDetails();

            while (l < 1)
            {
                Console.WriteLine("Enter 1 to transfer funds, 2 to deposit funds, 3 to logout or type \"quit\" to exit");
                string inProgramEntry = Console.ReadLine().ToLower();
                if (string.Equals(inProgramEntry, "quit"))
                {
                    System.Environment.Exit(1);
                }
                else if (string.Equals(inProgramEntry, ""))
                {
                    Console.WriteLine(errorMessage);
                }
                try
                {
                    int InProgramEntry = int.Parse(inProgramEntry);
                    if (InProgramEntry == 1)
                    {
                        ExampleProfile.TransferFunds();
                        ExampleProfile.GetAccountDetails();
                    }
                    else if (InProgramEntry == 2)
                    {
                        ExampleProfile.AddFunds();
                        ExampleProfile.GetAccountDetails();
                    }
                    else if (InProgramEntry == 3)
                    {
                        break;
                    }
					else if (InProgramEntry == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMessage + " Exception handled!");
                }
            }
        }
        public static readonly string AccountNumber = "162534";
        public static readonly string SortCode = "10-24-27";
        public static readonly string FirstName = "John";
        public static readonly string LastName = "Doe";
        public static readonly string DateOfBirth = "10/11/1990";
        public static readonly string UserName = "JD1990";
        public static readonly string Password = "123";
        public static readonly string Address = "70 tharp road";
        public static readonly string PhoneNumber = "07713153222";
        public static readonly string EMailAddress = "jd@gmail.com";
        private static int Balance = 23549;
        public static void GetAccountDetails()
        {
            Console.WriteLine("Account number : " + AccountNumber);
            Console.WriteLine("Sort code      : " + SortCode);
            Console.WriteLine("");
            Console.WriteLine("First name     : " + FirstName);
            Console.WriteLine("Last name      : " + LastName);
            Console.WriteLine("DOB            : " + DateOfBirth);
            Console.WriteLine("User name      : " + UserName);
            Console.WriteLine("Address        : " + Address);
            Console.WriteLine("Phone number   : " + PhoneNumber);
            Console.WriteLine("E-Mail address : " + EMailAddress);
            Console.WriteLine("");
            Console.WriteLine("Balance        : £" + Balance);
            Console.WriteLine("");

        }
        public static void TransferFunds()
        {
            Console.WriteLine("Please enter the ammount you would like to tranfer : ");
            string entry2 = Console.ReadLine().Trim();
            try
            {
                int userEntry2 = int.Parse(entry2);
                Balance -= userEntry2;
                Console.WriteLine("new balance : " + Balance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AddFunds()
        {
            Console.WriteLine("Please enter the ammount you would like to deposit : ");
            string entry3 = Console.ReadLine().Trim();
            try
            {
                int userEntry3 = int.Parse(entry3);
                Balance += userEntry3;
                Console.WriteLine("new balance : " + Balance);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}