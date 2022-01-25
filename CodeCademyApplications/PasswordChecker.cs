using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingIntoCAgain.CodeCademyApplications
{
    public class PasswordChecker
    {
        public static void CallMe()
        {
            #region
            string password = "PassWord01";
            bool doesItHaveUpper;

            for (int i = 0; i < password.Length; i++)
            {
                doesItHaveUpper = Char.IsUpper(password, i);
                Console.WriteLine(doesItHaveUpper);
            }
            #endregion

            #region
            //int minLength;
            //string uppercase;
            //string lowercase;
            //string digits;
            //string specialChars;
            //int score = 0;
            //Console.WriteLine("Please enter your password:\n");
            //string password = Console.ReadLine();
            //if (password >= minLength)
            //{
            //    score += 1;
            //}
            #endregion
        }
    }
}
