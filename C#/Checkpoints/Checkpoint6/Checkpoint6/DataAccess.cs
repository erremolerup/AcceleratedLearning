//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

//namespace Checkpoint6
//{
//    public class DataAccess
//    {
//        private readonly SpaceShipContext _context;

//        public DataAccess()
//        {
//            _context = new SpaceShipContext();
//        }

//        public void RecreateDatabase()
//        {
//            var ussEnterPrise = new SpaceShips { Name = "USS Enterprise" };
//            var milleniumFalcon = new SpaceShips { Name = "Millennium Falcon" };
//            var cylonRaider = new SpaceShips { Name = "Cylon Raider" };

//            AddSpaceship("USS Enterprise");
//            AddSpaceship("Millennium Falcon");
//            AddSpaceship("Cylon Raider");
//        }

//        public void AddSpaceship(string v)
//        {
//            var ussEnterPrise = new SpaceShips { Name = "USS Enterprise" };
//            var milleniumFalcon = new SpaceShips { Name = "Millennium Falcon" };
//            var cylonRaider = new SpaceShips { Name = "Cylon Raider" };

//            _context.SpaceShips.Add(new SpaceShips { Name = "USS Enterprise" });
//            _context.SpaceShips.Add(new SpaceShips { Name = "Millennium Falcon" });
//            _context.SpaceShips.Add(new SpaceShips { Name = "Cylon Raider" });

//        }

//        public List<SpaceShips> ReturnAllSpaceShips()
//        {
//            List<SpaceShips> spaceShips = new List<SpaceShips>();

//            return _context.SpaceShips.Include(x => x.Name).ToList();
//        }
//    }
//}
