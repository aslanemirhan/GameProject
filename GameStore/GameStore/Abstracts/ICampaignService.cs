using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstracts
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
