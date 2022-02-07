using System;
using System.Linq;

namespace GettingIntoCAgain.CodeCademyApplications
{
    public class PasswordChecker
    {
        public static void CallMe()
        {
            var isPasswordCheckerRunning = true;

            while (isPasswordCheckerRunning)
            {
                Console.WriteLine("1. Check Password\n" +
                "2. Main Menu\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Provide the password you want to check: ");
                        Console.WriteLine(CheckPassword(Console.ReadLine()));
                        break;
                    case "2":
                        isPasswordCheckerRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please type \"1\" or \"2\"");
                        break;
                }
            }
        }
        //TODO Return which character was the upper case one and write it to the user
        private static string CheckPassword(string password)
        {
            bool hasUpper = password.Any(char.IsUpper);
            
            if (hasUpper)
            {
                password = $"Upper case character detected!";
            }
            else
            {
                password = "No upper characters detected.";
            }

            return password;
        }
    }
}
