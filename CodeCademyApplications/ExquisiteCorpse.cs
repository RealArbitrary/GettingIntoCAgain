using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingIntoCAgain.CodeCademyApplications
{
    public class ExquisiteCorpse
    {
        public static void CallMe()
        {
            bool runCreatureCreation = true;
            while (runCreatureCreation)
            {
                Console.WriteLine("1. Create your Own\n" +
                "2. RandomMode\n" +
                "0. Quit to Desktop");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    //TODO logic to alternate between strings and ints. Currently if ints are entered, it will use the default in the TranslateToNumber method
                    case "1":
                        Console.WriteLine("Awesome! A creature consists of three parts. 1. Head, 2. Body, 3. Feet!\n" +
                        "On top of that, we have three creatures to select from. 1. Ghost, 2. Bug, 3. Monster\n" +
                        "What will it be? A bug with monster feet for a head or a ghost with a monster's torso?");
                        int choice1 = TranslateToNumber(Console.ReadLine().ToLower());
                        int choice2 = TranslateToNumber(Console.ReadLine().ToLower());
                        int choice3 = TranslateToNumber(Console.ReadLine().ToLower());
                        SwitchCase(choice1, choice2, choice3);
                        break;
                    case "2":
                        Console.WriteLine(".. pfft, lazy! Here's your monster:\n");
                        RandomMode();
                        break;
                    case "0":
                        runCreatureCreation = false;
                        break;
                    default:
                        Console.WriteLine("Please choose \"1\" to create your own,\"2\" to randomly create or \"0\" to exit!");
                        break;
                }
            }
        }

        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
                default:
                    break;
            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
                default:
                    break;
            }
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
                default:
                    break;
            }
        }

        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }

        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
