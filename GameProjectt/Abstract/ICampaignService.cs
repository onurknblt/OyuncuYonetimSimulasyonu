﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt.Abstract
{
    internal interface ICampaignService
    {
        void Add(Campaign campaign);

        void Delete(Campaign campaign);

        void Update(Campaign campaign);
    }
}
