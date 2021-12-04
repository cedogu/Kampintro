using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game is added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game is deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game is updated");
        }
    }
}
