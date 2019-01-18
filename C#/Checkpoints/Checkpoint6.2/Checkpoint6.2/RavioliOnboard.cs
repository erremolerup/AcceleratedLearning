using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint6._2
{
    public class RavioliOnboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PackDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public Spaceship Spaceship { get; set; }
    }
}
