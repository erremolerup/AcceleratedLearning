using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TVschedule
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<Show1> allShows = GetShowsFromTextFile();

            DisplayInfoAboutShows(allShows);

            Console.ReadKey();
        }

        private List<Show1> GetShowsFromTextFile()
        {
            List <Show1> allShows = new List<Show1>();

            string[] tvSchedule = File.ReadAllLines("TextFile1.txt");
            
            foreach (string line in tvSchedule)
            {
                Show1 show = new Show1();
                show.Channel = tvSchedule[0];
                show.StartTime = int.Parse(tvSchedule[1]);
                show.Name = tvSchedule[2];

                allshows.Add(show);
            }
            return allShows;
        }

        private void DisplayInfoAboutShows(List<Show1> allShows)
        {
            throw new NotImplementedException();
        }
    }
}
