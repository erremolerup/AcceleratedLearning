using System;

namespace Modul3
{
    class Program
    {
        static int goToSleep;
        static int wakeUp;
        static int timeSlept;

        static void Main(string[] args)
        {
            AskForBedTime();
        }

        static void AskForBedTime()
        {
            Console.Write("When did you go to bed yesterday? ");
            int goToSleep = int.Parse(Console.ReadLine());

            Console.Write("When did you wake up? ");
            int wakeUp = int.Parse(Console.ReadLine());

            if (goToSleep > wakeUp)
            {
                timeSlept = (24 - goToSleep) + wakeUp;
            }
            else
            {
                timeSlept = wakeUp - goToSleep;
            }
            Console.WriteLine(timeSlept);
        }
    }
}
