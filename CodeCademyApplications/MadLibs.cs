using System;

namespace GettingIntoCAgain.CodeCademyApplications
{
    public class MadLibs
    {
        public static void CallMe()
        {
            /*
            This program is a MadLibs Program to demonstrate interacting with strings and text in C#. It is also used to prove the comptentency of what I've learned in my journey on CodeCademy and C# so far.
            Author: De Wet van der Merwe
             */
            // Let the user know that the program is starting:
            Console.WriteLine("Your MadLibs Session is now in progress. Have Fun!\n");
            // Give the Mad Lib a title:
            string title = "Title: Building Applications With C#\n";
            Console.WriteLine(title);
            // Define user input and variables:
            //Protagonist
            Console.WriteLine("Our story needs a protagonist. Please enter the name you would like to use: \n");
            string protagonist = Console.ReadLine();
            Console.WriteLine("Awesome Protagonist name!\n");
            //Adjectives
            Console.WriteLine("To further populate our story, we will need some adjectives. Like the color \"blue\", for example.\n");
            Console.WriteLine("To proceed, please enter three adjectives:\n");
            string adj0 = Console.ReadLine();
            Console.WriteLine($"\"{adj0}\", nice!\n");
            string adj1 = Console.ReadLine();
            Console.WriteLine($"\"{adj1}\", Lol. Not bad.\n");
            string adj2 = Console.ReadLine();
            Console.WriteLine($"\"{adj2}\", What are you trying to pull?\n");
            //Verb
            Console.WriteLine("Great. Now that the initial setup is out of the way, let's proceed. I now need you provide me a verb. Don't think too much, first thing that comes to mind!\n");
            string verb0 = Console.ReadLine();
            Console.WriteLine($"\"{verb0}\", this is getting exciting!\n");
            //Nouns
            Console.WriteLine("I know I am probably sounding like a broken record, but I now need you to feed me two nouns like \"cabin\". Nom nom.\n");
            string noun0 = Console.ReadLine();
            Console.WriteLine($"\"{noun0}\", received. Still hungry though.\n");
            string noun1 = Console.ReadLine();
            Console.WriteLine($"\"{noun1}\", Ok basically satiated. On to the fun part!!\n");
            Console.WriteLine("Getting closer.. To.. The.. EDGE! Things are getting weird. Feed me the list of thingies below:\n");
            Console.WriteLine("An Animal: \n");
            string animal = Console.ReadLine();
            Console.WriteLine($"\"{animal}\", lol okay, next. Any food that comes to mind:\n");
            string food = Console.ReadLine();
            Console.WriteLine($"\"{food}\", let me guess. Something unhealthy? Why not a salad? I wont't judge. Gimme a fruit next:\n");
            string fruit = Console.ReadLine();
            Console.WriteLine($"\"{fruit}\", not my favorite. When will this end? Hint: Not now. haha. Give me a superhero now:\n");
            string superhero = Console.ReadLine();
            Console.WriteLine($"Is it a bird? Is it a plane? No, it's \"{superhero}\". Funny aren't I? Now a country.\n");
            string country = Console.ReadLine();
            Console.WriteLine($"This \"{country}\" tis of thee. A land of true embassy! Now a dessert. Not the Saharah, but like.. Chocolate cake?\n");
            string dessert = Console.ReadLine();
            Console.WriteLine($"\"{dessert}\", another unhealthy choice, eh? It is okay we are almost done. No judgement once again, lol. Gimme a year now {protagonist}\n");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {protagonist} woke up feeling {adj0}. 'It is going to be a {adj1} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb0} to the rhythm of the {noun0}, which made all the {fruit}s very {adj2}. Concerned, {protagonist} texted {superhero}, who flew {protagonist} to {country} and dropped {protagonist} in a puddle of frozen {dessert}. {protagonist} woke up in the year {year}, in a world where {noun1}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
