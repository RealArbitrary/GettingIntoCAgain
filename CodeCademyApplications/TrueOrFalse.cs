using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingIntoCAgain.CodeCademyApplications
{
    public class TrueOrFalse
    {
        public static void CallMe()
        {
            bool isTrueOrFalseRunning = true;

            while (isTrueOrFalseRunning)
            {
                Console.WriteLine("1. True or False\n" +
                "2. Main Menu\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        MasterMethod();
                        break;
                    case "2":
                        isTrueOrFalseRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }
        private static void MasterMethod()
        {
            string[] questions = new string[] { "Is the sky blue?", "Are roses red?", "Is C# fun?" };
            //Correct answers to questions
            bool[] answers = { true, false, true };
            //Responses, same length as questions array
            bool[] responses = new bool[questions.Length];
            //To keep track of where we are in the loop
            int askingIndex = 0;
        }
    }
}
