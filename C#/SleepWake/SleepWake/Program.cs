using System;

namespace Modul3
{
    class Program
    {
        static int sleep;
        static int wake;

        static void Main(string[] args)
        {
            AskForBedTime();
        }

        static void AskForBedTime()
        {
            Console.Write("When did you go to bed yesterday? ");
            string sleep = Console.ReadLine();

            Console.Write("When did you wake up? ");
            string wake = Console.ReadLine();
        }
    }
}
