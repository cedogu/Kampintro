using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingProject
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("added " + gamer.GamerName + gamer.GamerSurname );
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("deleted: " + gamer.GamerName + gamer.GamerSurname);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("deleted: " + gamer.GamerName + gamer.GamerSurname);
        }
    }
}
