using System;
namespace SelfTrainingProject.BankAccount
{
    public class UserProfile
    {
        public static string errorMessage = "Invalid input";


        public static string AccountNumber { get; set; }
        public static string SortCode { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string DateOfBirth { get; set; }
        public static string Address { get; set; }
        public static string PhoneNumber { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string InitialBalance { get; set; }
        public static string EMailAddress { get; set; }
        public static int Balance { get; set; }
        public static int RollingBalance;

        public static int InitialiseBalance()
        {
            try
            {               
                return Balance = int.Parse(InitialBalance);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Balance;
            }
        }

        public static void RunUserProfile()
        {
            int l = 0;

            UserProfile.GetAccountDetails();

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
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ResetColor();
                }
                try
                {
                    int InProgramEntry = int.Parse(inProgramEntry);
                    if (InProgramEntry == 1)
                    {
                        UserProfile.TransferFunds();
                        UserProfile.GetAccountDetails();
                    }
                    else if (InProgramEntry == 2)
                    {
                        UserProfile.AddFunds();
                        UserProfile.GetAccountDetails();
                    }
                    else if (InProgramEntry == 3)
                    {
                        break;
                    }
					else if (inProgramEntry == "")
                    {
						continue;
                    }
                    else
                    {
						Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMessage);
						Console.Beep();
                        Console.ResetColor();
					}
                }
                catch (Exception)
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage + " Exception Handled!");
					Console.Beep();
                    Console.ResetColor();                }
            }
        }
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
            catch(Exception ex)
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