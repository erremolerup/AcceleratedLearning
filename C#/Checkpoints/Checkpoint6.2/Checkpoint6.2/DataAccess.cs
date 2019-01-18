using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Checkpoint6._2
{
    public class DataAccess
    {
        SpaceContext context = new SpaceContext();

        public void ClearDatabase()
        {
            foreach (var item in GetAllSpaceships())
            {
                context.Remove(item);
            }

            context.SaveChanges();
        }

        internal void RecreateDatabase()
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        internal void AddRavioliForSpaceship(string spaceShipName, int numberOfRaviolis, string packDate)
        {
            for (int i = 1; i <= numberOfRaviolis; i++)
            {
                DateTime start = DateTime.Parse(packDate);
                DateTime expire = start.AddDays(197);

                bool exist = SeeIfShipExist(spaceShipName);

                if (exist)
                {
                    Spaceship newShip = context.Spaceships.SingleOrDefault(x => x.Name == spaceShipName);

                    var Ravioli = new RavioliOnboard
                    {
                        Name = "Ravioli",
                        Spaceship = newShip,
                        PackDate = start,
                        ExpireDate = expire
                    };
                    context.RavioliOnBoard.Add(Ravioli);
                }
            }
            context.SaveChanges();
        }

        private bool SeeIfShipExist(string spaceShip)
        {
            return context.Spaceships.Any(x => x.Name == spaceShip);
        }

        public void AddSpaceship(string v)
        {
            var spaceship = new Spaceship { Name = v };

            context.Spaceships.Add(spaceship);
            context.SaveChanges();
        }

        public void DisplaySpaceships(IEnumerable<Spaceship> list)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SPACESHIPS:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public IEnumerable<Spaceship> GetAllSpaceships()
        {
            return context.Spaceships;
        }
    }
}
