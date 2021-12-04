using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingProject
{
    class Gamer
    {
        public string IdNumber { get; set; }
        public string GamerName { get; set; }
        public string GamerSurname { get; set; }
        public string BirthYear { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
    }
}
