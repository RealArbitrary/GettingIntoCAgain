using System;
using GettingIntoCAgain.CodeCademyApplications;
using GettingIntoCAgain.MyApplications;
using GettingIntoCAgain.MainMenu;

namespace GettingIntoCAgain
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                WelcomeMessage();
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        endApp = true;
                        break;
                    case "1":
                        PasswordChecker.CallMe();
                        break;
                    case "2":
                        CaesarCipher.CallMe();
                        break;
                    case "3":
                        TrueOrFalse.CallMe();
                        break;
                    default:
                        Console.WriteLine("Something went wrong, try one of the menu options or typing \"GIC\"");
                        break;
                }
            }
        }
        private static void WelcomeMessage()
        {
            Console.WriteLine("Hi and welcome!\n" +
                "This application is intended for educational purposes and, also to have fun.\n" +
                "Functional menu items are:\n" +
                "At any point you can type \"GIC\" for help. This input is case sensitive and validated.\n" +
                "Typing \"GIC\" will print the current menu items information, to describe what you are looking at!");
            MenuItems();
        }
        private static void MenuItems()
        {
            Console.WriteLine("1. Password Checker\n" +
                "2. Caesar Cipher\n" +
                "3. TrueOrFalse\n" +
                "0. Quit to Desktop\n");
        }
        
        #region
        //Using an Array method, find the position for the first 3-star rated song and save it to a variable.Print a message to the console, like “Song number X is rated three stars”.
        private static void MethodArray()
        {
            string[] summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            int myIndex = Array.IndexOf(ratings, 4) + 1;

            Console.WriteLine($"Song Number {myIndex} is rated {myIndex} stars");

            //Demonstrating usage of a predicate
            var myVar = Array.Find(summerStrut, strut => strut.Length > 10);

            //Organize the playlist alphabetically. To check that it worked, print the first and last song titles to the console.

            Array.Sort(summerStrut);

            foreach (var strut in summerStrut)
            {
                Console.WriteLine(strut);

            }

            Console.WriteLine($"First: {summerStrut[0]}, last: {summerStrut[summerStrut.Length - 1]}");

            //find the method that allows you to copy your playlist to a new playlist called summerStrutCopy. Print the first value of summerStrutCopy to the playlist to see if is the same as summerStrut.

            string[] summerStrutCopy = new string[8];            

            Array.Copy(summerStrut, summerStrutCopy, 8);

            Console.WriteLine(summerStrutCopy[0]);
            Array.Clear(summerStrut, 0, 8);
        }
        #endregion

    }
}