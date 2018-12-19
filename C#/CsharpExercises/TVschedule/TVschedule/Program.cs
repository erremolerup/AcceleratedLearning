using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TVschedule
{
    class Program
    {
        static void Main()
        {
            List<Show1> allShows = GetShowsFromTextFile("TextFile1.txt");
            DisplayAllShows(allShows);
            DisplayShowsLaterThan21(allShows);
            DisplayShowsSVT2InOrder(allShows);
            DisplayInfoAboutShows(allShows);

            Console.ReadKey();
            Header(string text);
        }

        private static List<Show1> GetShowsFromTextFile(string v)
        {
            string[] tvSchedule = File.ReadAllLines("TextFile1.txt");
            List<Show1> AllShows = new List<Show1>();


            foreach (string line in tvSchedule)
            {
                string[] splittedLine = line.Split('*');

                Show1 show = new Show1();
                {
                    show.Channel = tvSchedule[0];
                    show.StartTime = TimeSpan.Parse(tvSchedule[1]);
                    show.Name = tvSchedule[2];

                    AllShows.Add(show);
                };
            }
            return AllShows;
        }

        private static void DisplayAllShows(List<Show1> allShows)
        {
            Console.WriteLine("ALLA TITLAR");
            var allTitles = allShows.Add
        }

        private static void Header()
        {
            throw new NotImplementedException();
        }

        private void DisplayInfoAboutShows(List<Show1> allShows)
        {

        }

        private static void DisplayShowsLaterThan21(List<Show1> allShows)
        {
            throw new NotImplementedException();
        }

        private static void DisplayShowsSVT2InOrder(List<Show1> allShows)
        {
            throw new NotImplementedException();
        }
    }
}
