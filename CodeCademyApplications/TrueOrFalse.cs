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
            bool[] answers = new bool[] { true, false, true };
            bool[] responses = new bool[3];
            if (questions.Length != responses.Length)
            {
                Console.WriteLine("The two arrays are not same length");
            }
            int askingIndex = 0;
            string input;
            bool isBool = false;
            bool inputBool = true;
            foreach (var question in questions)
            {
                while (!isBool)
                {
                    Console.WriteLine(questions[askingIndex]);
                    Console.WriteLine("True or False?");
                    input = Console.ReadLine();
                    if (input != "true" || input != "True")
                    {
                        Console.WriteLine("Please type \"true\", \"True\", \"false\" or \"False\"");
                    }
                    else if (input != "false" || input != "False")
                    {
                        Console.WriteLine("Please type \"true\", \"True\", \"false\" or \"False\"");
                    }
                    isBool = Boolean.TryParse(input, out bool result);
                }
                askingIndex++;
            }
        }
    }
}
