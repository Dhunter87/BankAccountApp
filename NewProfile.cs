using System;
namespace SelfTrainingProject.BankAccount
{
    public class NewProfile
    {
        public static int UserCount;

        public static void addNewProfile()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter users first name: ");
            UserProfile.FirstName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users last name: ");
            UserProfile.LastName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users date of birth: ");
            UserProfile.DateOfBirth = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users user name: ");
            UserProfile.UserName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter users password: ");
            UserProfile.Password = Console.ReadLine().Trim();
            Console.WriteLine("Please enter address: ");
            UserProfile.Address = Console.ReadLine().Trim();
            Console.WriteLine("Please enter phone number: ");
            UserProfile.PhoneNumber = Console.ReadLine().Trim();
            Console.WriteLine("Please enter E-Mail: ");
            UserProfile.EMailAddress = Console.ReadLine().Trim();

            Console.WriteLine("Please enter new account number: ");
            UserProfile.AccountNumber = Console.ReadLine().Trim();
            Console.WriteLine("Please enter new sort code: ");
            UserProfile.SortCode = Console.ReadLine().Trim();

            Console.WriteLine("Please enter starting balance ");
            UserProfile.InitialBalance = Console.ReadLine().Trim();
            UserProfile.InitialiseBalance();
            UserCount++;
            Console.WriteLine("User count : " + UserCount);
            Console.WriteLine("");
        }
    }
}
