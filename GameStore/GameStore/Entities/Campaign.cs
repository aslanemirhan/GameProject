﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
