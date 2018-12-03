using System;

namespace Uppgift2_2
{   //Nu är uppgiften att svara med antal dagar tills pension och you like numbers om
    //siffra och you dont like numbers om bokstav
    class Program
    {
        //STEG 1 definiera variabler du ska använda
        //static string name = "";
        //static int age;
        //static char letter;
        //static int retire = (65 - age);

        //STEG 2 definiera metoder som behövs
        static void Main(string[] args)
        {
            AskForUsersName();
        }

        //STEG 3 
        public static void AskForUsersName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your favorite letter? ");
            char letter = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Your name is: " + name);
            int retire = 65 - age;
            Console.WriteLine("You have " + retire + " years until retirement");
            if (char.IsLetter(letter))
            {
                Console.WriteLine("You don't like numbers ");
            }
            else
            {
                Console.WriteLine("You like numbers");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
