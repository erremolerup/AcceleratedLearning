using System;
using System.Collections.Generic;
//using System.Linq;

namespace Checkpoint6._2
{
    class Program
    {
        //static SpaceContext context = new SpaceContext();
        //static readonly DataAccess dataAccess = new DataAccess();

        static void Main()
        {
            DataAccess dataAccess = new DataAccess();
            //dataAccess.RecreateDatabase();

            dataAccess.ClearDatabase();

            dataAccess.AddSpaceship("USS Enterprise");
            dataAccess.AddSpaceship("Millennium Falcon");
            dataAccess.AddSpaceship("Cylon Raider");

            dataAccess.AddRavioliForSpaceship("Cylon Raider", 1, "2018-04-19");
            dataAccess.AddRavioliForSpaceship("Millennium Falcon", 1, "2017-01-01");
            dataAccess.AddRavioliForSpaceship("Millennium Falcon", 2, "2018-01-01");
            dataAccess.AddRavioliForSpaceship("Nalle Puh", 99, "1950-01-01");

            IEnumerable<Spaceship> list = dataAccess.GetAllSpaceships();
            dataAccess.DisplaySpaceships(list);
        }

        //private static void ClearDatabase()
        //{
        //    //var context = new SpaceContext();

        //    //IEnumerable<Spaceship> spaceships = GetAllSpaceships();

        //    foreach (var item in GetAllSpaceships())
        //    {
        //        context.Remove(item);
        //    }

        //    context.SaveChanges();
        //}

        //private static void RecreateDatabase()
        //{
        //    //var context = new SpaceContext();

        //    context.Database.EnsureDeleted();
        //    context.Database.EnsureCreated();

        //    //using (var context = new SpaceContext())
        //    //{
        //    //    context.Database.EnsureDeleted();
        //    //    context.Database.EnsureCreated();
        //    //}
        //}

        //private static void DisplaySpaceships(IEnumerable<Spaceship> list)
        //{
        //    Console.WriteLine("Spaceships:");

        //    foreach (var item in list)
        //    {
        //        Console.WriteLine(item.Name);
        //    }
        //}

        //private static IEnumerable<Spaceship> GetAllSpaceships()
        //{
        //    //var context = new SpaceContext();

        //    return context.Spaceships;
        //}

        //private static void AddSpaceship(string v)
        //{
        //    //var context = new SpaceContext();

        //    var spaceship = new Spaceship { Name = v };

        //    //context.Add(spaceship);
        //    //context.Add("sdfdg");

        //    context.Spaceships.Add(spaceship);
        //    //context.Spaceships.Add("sdfsdf");
        //    context.SaveChanges();
        //}

    }
}
