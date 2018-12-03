using System;

namespace Modul3
{
    class Program
    {
        //variabler som behövs
        static int sleepTime;
        static int wakeTime;
        static int hoursSlept = (24 - sleepTime) + wakeTime;

        static void Main(string[] args)
        {
            AskUserForSleeptime();
            //AskUserForWaketime();
            AnswerUser();
        }

        private static void AskUserForSleeptime()
        {
            Console.Write("When did you go to bed yesterday? ");
            int sleepTime = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wakeTime = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (sleepTime > wakeTime)
            {
                hoursSlept = (24 - sleepTime) + wakeTime;
            }
            else if (sleepTime < wakeTime)
            {
                hoursSlept = wakeTime - sleepTime;
            }
        }

        private static void AnswerUser()
        {
            if (hoursSlept < 5)
            {
                Console.WriteLine("You've only slept " + hoursSlept + " hours. Go back to bed!");
            }
            else if (hoursSlept > 11)
            {
                Console.WriteLine("You've slept " + hoursSlept + " hours, thats too much. Are you sick?");
            }
            else
            {
                Console.WriteLine("You've slept well. " + hoursSlept + " hours");
            }
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
