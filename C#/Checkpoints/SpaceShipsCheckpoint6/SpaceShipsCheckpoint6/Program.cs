using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShipsCheckpoint6
{
    class Program
    {
        static void Main()
        {
            RecreateDatabase();

            AddSpaceship("USS Enterprise");
            AddSpaceship("Millennium Falcon");
            AddSpaceship("Cylon Raider");

            List<Spaceships> list = GetAllSpaceships();
            DisplaySpaceships(list);
        }

        private static void RecreateDatabase()
        {
            using (var context = new SpaceShipContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }

        private static void AddSpaceship(string v)
        {
            var spaceship = new Spaceships { Name = v };
        }

        private static List<Spaceships> GetAllSpaceships()
        {
            var _context = new SpaceShipContext();

            return _context.Spaceships.Include(x => x.Name).ToList();
        }

        private static void DisplaySpaceships(List<Spaceships> list)
        {
            Console.WriteLine("SPACESHIPS: ");

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }

    }
}
