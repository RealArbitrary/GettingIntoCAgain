using System;
using GettingIntoCAgain.CodeCademyApplications;
using GettingIntoCAgain.MyApplications;

namespace GettingIntoCAgain
{
    public class Program
    {
        static void Main(string[] args)
        {
            BurgerMaker.callMe();
            var isProgramRunning = true;
            var userDecision = "";

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
                        ChooseYourOwnAdventure.callMe();
                        break;
                    default:
                        isProgramRunning = false;
                        break;
                }
            }
        }
    }
}