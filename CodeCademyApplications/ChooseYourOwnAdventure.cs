using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingIntoCAgain.CodeCademyApplications
{
    public class ChooseYourOwnAdventure
    {
        public static void callMe()
        {
            //TODO Refactor logic to ternary operators

            var gameStatus = true;

            while (gameStatus)
            {
                Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
                Console.WriteLine("Type YES or NO");
                var noiseChoice = Console.ReadLine().ToUpper();
                if (noiseChoice == "NO")
                {
                    Console.WriteLine("Not much of an adventure if we don't leave our room!\nTHE END.");
                    gameStatus = false;
                } else if (noiseChoice == "YES")
                {
                    Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\n"+ 
                        "You walk towards it.Do you open it or knock ? ");
                }

                Console.WriteLine("Type OPEN or KNOCK");
                noiseChoice = Console.ReadLine().ToUpper();
                if (noiseChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says,\"Answer this riddle: \"\n" +
                        "Poor people have it. Rich people need it. If you eat it you die. What is it?");
                    Console.Write("Type your answer:");
                    var riddleAnswer = Console.ReadLine();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.\nYou turn off the light and run back to your room and lock the door.\nTHE END.");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\nTHE END.");
                    }
                } else if(noiseChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.Write("Enter a number (1-3)");
                    var keyChoice = Console.ReadLine();

                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there.Strange...\nTHE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END.");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
