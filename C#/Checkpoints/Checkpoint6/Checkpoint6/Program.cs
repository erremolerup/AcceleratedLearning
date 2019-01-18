using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Checkpoint6
{
    class Program
    {
        private readonly SpaceShipContext _context;
        //static readonly DataAccess _dataAccess = new DataAccess();

        internal void Main()
        {
            RecreateDatabase();

            AddSpaceship("USS Enterprise");
            AddSpaceship("Millennium Falcon");
            AddSpaceship("Cylon Raider");

            List<SpaceShips> list = GetAllSpaceships();
            DisplaySpaceships(list);

        }

        internal void DisplaySpaceships(List<SpaceShips> list)
        {
            Console.WriteLine();
            Console.WriteLine("SPACESHIPS");
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }

        internal List<SpaceShips> GetAllSpaceships()
        {
            List<SpaceShips> spaceShips = ReturnAllSpaceShips();

            return spaceShips;
        }
        //-------------------------------------------------
        internal Program()
        {
            _context = new SpaceShipContext();
        }
        internal void RecreateDatabase()
        {
            var ussEnterPrise = new SpaceShips { Name = "USS Enterprise" };
            var milleniumFalcon = new SpaceShips { Name = "Millennium Falcon" };
            var cylonRaider = new SpaceShips { Name = "Cylon Raider" };
        }

        internal void AddSpaceship(string v)
        {
            var ussEnterPrise = new SpaceShips { Name = "USS Enterprise" };
            var milleniumFalcon = new SpaceShips { Name = "Millennium Falcon" };
            var cylonRaider = new SpaceShips { Name = "Cylon Raider" };

            _context.SpaceShips.Add(new SpaceShips { Name = "USS Enterprise" });
            _context.SpaceShips.Add(new SpaceShips { Name = "Millennium Falcon" });
            _context.SpaceShips.Add(new SpaceShips { Name = "Cylon Raider" });

        }

        internal List<SpaceShips> ReturnAllSpaceShips()
        {
            List<SpaceShips> spaceShips = new List<SpaceShips>();

            return _context.SpaceShips.Include(x => x.Name).ToList();
        }

    }
}
