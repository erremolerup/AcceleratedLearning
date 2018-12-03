using System;

namespace Uppgift3_4
{
    class Program
    {
        private static string name;

        static void Main(string[] args)
        {
            AskUserForNames();
        }

        private static void AskUserForNames()
        {
            Console.Write("Enter names in a list separated by comma: ");
            string namesTogether = Console.ReadLine();
            string[] names = namesTogether.Split(new[] { ',' });

            foreach (var name in names)
            {
                if (name == "Zelda")
                {
                    break;
                }
                Console.WriteLine(name + " Andersson");
                
                
            }
        }
    }
}

//FRÅN TIDIGARE

//    using System;

//namespace FamilyName
//{
//    class Program
//    {
//        private static string name;

//        static void Main(string[] args)
//        {
//            AskForUserName();
//        }

//        private static void AskForUserName()
//        {


//            Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
//            string namesTogether = Console.ReadLine();
//            string[] names = namesTogether.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

//            if (namesTogether.Length < 6)
//            {
//                Console.WriteLine("The names you entered are invalid. Please try again:");
//            }
//            else
//            {
//                foreach (var name in names)
//                {

//                    if (name == "Zelda")
//                    {
//                        break;
//                    }

//                    //if (name == "allowZelda")
//                    //{
//                    //    continue;
//                    //}
//                    Console.WriteLine(name + " Andersson");
//                }


//            }

//        }
//    }
//}
