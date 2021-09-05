using GameStore.Abstracts;
using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concretes
{
    public class OrderManager : IOrderService
    {
        public void CampaignOrder(Gamer gamer, Game game, Campaign campaign)
        {
            decimal dicountRate = game.GamePrice - (game.GamePrice * campaign.DiscountRate);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + game.GameName + " " + "Bought at a discounted price : " + dicountRate );
        }

        public void Order(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Bought : " + game.GamePrice + " TL ");
        }
    }
}
