//using System;

//namespace Modul4
//{
//    class Program
//    {   //UTAN METODER
//        static void Main(string[] args)
//        {
//            Console.Write("Enter names seperated by comma: ");
//            string namesTogether = Console.ReadLine();

//            string[] names = namesTogether.Split(new[] { ',' });

//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine();

//            foreach (var name in names)
//            {
//                Console.WriteLine("***SUPER-" + name.ToUpper() + "***");
//            }
//            Console.WriteLine();
//            Console.ForegroundColor = ConsoleColor.White;
//        }
//    }
//}

using System;

namespace Modul4
{
    class Program
    {   //MED METODER
        static void Main(string[] args)
        {
            string namesTogether = AskUserForNames();
            string[] names = CreateArrayOfPeople(namesTogether);
            RespondToUser(names);
            RemoveBlankSpaces(names);
        }


        private static string AskUserForNames()
        {
            Console.Write("Enter names seperated by comma: ");
            string namesTogether = Console.ReadLine();

            return namesTogether;
        }

        private static string[] CreateArrayOfPeople(string namesTogether)
        {
            string[] names = namesTogether.Split(new[] { ',' }).;

            return names;
        }

        private static void RemoveBlankSpaces(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
            names[i] = names[i].Trim();
            }
        }
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
