using System;
using System.Collections.Generic;
//using System.Linq;

namespace Checkpoint6._2
{
    class Program
    {
        static SpaceContext context = new SpaceContext();

        static void Main()
        {
            //RecreateDatabase();

            ClearDatabase();

            AddSpaceship("USS Enterprise");
            AddSpaceship("Millennium Falcon");
            AddSpaceship("Cylon Raider");

            IEnumerable<Spaceship> list = GetAllSpaceships();

            DisplaySpaceships(list);
        }

        private static void ClearDatabase()
        {
            //var context = new SpaceContext();

            //IEnumerable<Spaceship> spaceships = GetAllSpaceships();

            foreach (var item in GetAllSpaceships())
            {
                context.Remove(item);
            }

            context.SaveChanges();
        }

        private static void RecreateDatabase()
        {
            //var context = new SpaceContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //using (var context = new SpaceContext())
            //{
            //    context.Database.EnsureDeleted();
            //    context.Database.EnsureCreated();
            //}
        }

        private static void DisplaySpaceships(IEnumerable<Spaceship> list)
        {
            Console.WriteLine("Spaceships:");

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static IEnumerable<Spaceship> GetAllSpaceships()
        {
            //var context = new SpaceContext();

            return context.Spaceships;
        }

        private static void AddSpaceship(string v)
        {
            //var context = new SpaceContext();

            var spaceship = new Spaceship { Name = v };

            //context.Add(spaceship);
            //context.Add("sdfdg");

            context.Spaceships.Add(spaceship);
            //context.Spaceships.Add("sdfsdf");
            context.SaveChanges();
        }

    }
}
