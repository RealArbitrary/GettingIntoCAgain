using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingIntoCAgain.MyApplications
{
    public class BurgerMaker
    {
        public static void CallMe()
        {
            var theBool = false;
            var theInt = 1;
            Console.WriteLine($"Before:\ntheBool: {theBool}, theInt: {theInt}");
            AddIngredients("", out theBool, out theInt);
            Console.WriteLine($"After:\ntheBool: {theBool}, theInt: {theInt}");
        }


        static void AddIngredients(string param, out bool myBool, out int myInt)
        {
            param = "Checking the logic";
            if (5 > 1)
            {
                myBool = true;
            }
            myInt = 5;
        }

        static void AddIngredients()
        {
            Console.WriteLine("Added Buns!");
        }
    }
}
