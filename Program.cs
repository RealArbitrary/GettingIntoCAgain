using System;

namespace GettingIntoCAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            string password = "PassWord01";
            bool doesItHaveUpper;

            for (int i = 0; i < password.Length; i++)
            {
                doesItHaveUpper = Char.IsUpper(password, i);
                Console.WriteLine(doesItHaveUpper);
            }
        }
    }
}
