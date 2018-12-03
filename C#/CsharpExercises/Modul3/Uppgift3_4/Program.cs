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

//using System;

//namespace Uppgift3_2
//{
//    class Program
//    {
//        //programmet ska kunna ta in ett namn och antal gånger att repetera

//        static void Main(string[] args)
//        {
//            AskUserForInput();
//        }

//        private static void AskUserForInput()
//        {
//            Console.Write("Enter your name: ");
//            string name = Console.ReadLine();

//            Console.Write("Times to repeat: ");
//            int times = int.Parse(Console.ReadLine());

//            int n = 0;

//antingen
//while (n < times)
//{
//    Console.WriteLine("Your name is " + name);
//    n++;
//}

//eller
//while (true)
//{
//    Console.WriteLine("Your name is " + name);
//    n++;

//    if ((n + 1) > times)
//    {
//        break;
//    }
//}

//            for (int i = 0; i < times; i++)
//            {
//                Console.WriteLine("Your name is " + name);
//            }
//        }
//    }
//}

