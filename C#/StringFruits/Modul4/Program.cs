using System;

namespace Modul4
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter names separated by comma (e.g. Maria,Peter,Lisa): ");
        //    string namesTogether = Console.ReadLine();


        //    string[] names = namesTogether.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine();
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine("***SUPER-" + name.ToUpper() + "***");
        //    }
        //    Console.WriteLine();
        //    Console.ForegroundColor = ConsoleColor.White;
        //}

        //**************************************************************************************************
        //static void Main(string[] args)
        //{
        //    string namesTogether = AskUserForNames();
        //    string[] names = CreateArrayOfPeople(namesTogether);
        //    RespondToUser(names);

        //}

        ////Get list names from user
        //private static string AskUserForNames()
        //{
        //    Console.Write("Enter names separated by comma (e.g. Maria,Peter,Lisa): ");
        //    string namesTogether = Console.ReadLine();

        //    return namesTogether;
        //}

        ////Create list
        //private static string[] CreateArrayOfPeople(string namesTogether)
        //{
        //    string[] names = namesTogether.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        //    return names;
        //}
        ////Report to user
        //private static void RespondToUser(string[] names)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine();
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine("***SUPER-" + name.ToUpper() + "***");
        //    }
        //    Console.WriteLine();
        //    Console.ForegroundColor = ConsoleColor.White;
        //}

        //*******************************************************************************************************

        static void Main(string[] args)
        {

            string[] names;

            //char separator = AskUserForSeparator();
            //bool wantError = AskUserForErrorMessage();

            while (true)
            {
                string namesTogether = AskUserForNames();
                names = CreateArrayOfPeople(namesTogether);
                //bool isValid = PeopleArrayIsValid(names);
                RemoveBlankSpaces(names);
                if (namesIsValid(names))
                {
                    break;
                } 
            }
            RespondToUser(names);
        }

        //Get list names from user
        private static string AskUserForNames()
        {
            Console.Write("Enter names separated by comma (e.g. Maria,Peter,Lisa): ");
            string namesTogether = Console.ReadLine();

            return namesTogether;
        }
        //Create list
        private static string[] CreateArrayOfPeople(string namesTogether)
        {
            string[] names = namesTogether.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            return names;
        }
        //Validate user input
        private static bool namesIsValid(string[] names)
        {
            if (names.Length == 0)
            {
                Console.WriteLine("The list does not contain any names");
                return false;
            }
            foreach (var name in names)
            {
                if (name.Length < 2 || name.Length > 9)
                {
                    Console.WriteLine("A person can only have 2 to 9 letters ");
                    return false;
                }
            }
            return true;
        }
        //Remove blankspaces from input
        //Returnerar inget, gör en manipulation på det som redan finns 
        private static void RemoveBlankSpaces(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Trim();
            }

        }
        //Report to user
        private static void RespondToUser(string[] names)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            foreach (var name in names)
            {
                Console.WriteLine("***SUPER-" + name.ToUpper() + "***");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}


