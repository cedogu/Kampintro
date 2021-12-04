using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingProject
{
    class CampaignManager : ICampaignService
    {
    

        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated");
        }
    }
}
