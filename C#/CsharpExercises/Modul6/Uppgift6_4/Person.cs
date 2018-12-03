using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift6_4
{
    enum Sport
    {
        tennis, rugby, soccer, hurling, squash
    }
    enum DifferentGenders
    {
        female, male, other
    }

    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Sport FavoriteSport { get; set; }
        public DifferentGenders Gender { get; set; }

    }
}
