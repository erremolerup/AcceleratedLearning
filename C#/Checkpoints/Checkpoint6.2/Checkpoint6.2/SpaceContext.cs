using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint6._2
{
    public class SpaceContext : DbContext
    {
        public DbSet<Spaceship> Spaceships { get; set; }
        public DbSet<RavioliOnboard> RavioliOnBoard { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EFSpaceships;");
            }
        }
    }
}
