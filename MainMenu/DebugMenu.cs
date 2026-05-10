using System;

namespace GettingIntoCAgain.MainMenu
{
    public class DebugMenu
    {
        public static bool Default(bool isProgramRunning)
        {
            Console.WriteLine("Entered the debugger, where I test temp code");
            return isProgramRunning = false;
        }
    }
}
