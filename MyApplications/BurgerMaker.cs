using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingIntoCAgain.MyApplications
{
    class BurgerMaker
    {
        public static void CallMe()
        {
            Console.WriteLine("Add base ingredient!\n");
            AddIngredients();
            Console.WriteLine("Now add your favorite!\n");
            AddIngredients("Pickles");

        }

        static void AddIngredients(string ingredient)
        {
            Console.WriteLine($"Added {ingredient}");

        }

        static void AddIngredients()
        {
            Console.WriteLine("Added Buns!");
        }
    }
}
