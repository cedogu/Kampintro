﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingProject
{
    interface ISaleService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
