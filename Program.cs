using System;
using GettingIntoCAgain.CodeCademyApplications;
using GettingIntoCAgain.MyApplications;

namespace GettingIntoCAgain
{
    public class Program
    {
        static void Main(string[] args)
        {
            var isProgramRunning = false;
            var userDecision = "";
            //TODO add all classes to main menu
            //TODO make the menu interactive, allow it to go in and out of classes
            while (isProgramRunning)
            {
                Console.WriteLine("Options:\n" +
                    "1.PasswordChecker\n " +
                    "2.MadLibs\n " +
                    "3.ChooseYourOwnAdventure\n" +
                    "0.Exit");
                userDecision = Console.ReadLine();

                switch (userDecision)
                {
                    case "1":
                        PasswordChecker.CallMe();
                        break;
                    case "2":
                        MadLibs.CallMe();
                        break;
                    case "3":
                        ChooseYourOwnAdventure.CallMe();
                        break;
                    default:
                        isProgramRunning = false;
                        break;
                }
            }
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