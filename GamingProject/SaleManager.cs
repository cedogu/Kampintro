using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingProject
{
    class SaleManager : ISaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Gamer :" + gamer.FirstName + gamer.LastName + "Name of game: " + game.Name + "used the campaign and purchased the game"
                 + campaign.Name);
        }
    }
}
