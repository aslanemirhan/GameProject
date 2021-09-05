using GameStore.Concretes;
using GameStore.Entities;
using System;
using System.Collections.Generic;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());

            Gamer gamer1 = new Gamer()
            {
                Id=1,
                FirstName="Emirhan",
                LastName="Aslan",
                DateOfBirth= new DateTime(1998,8,15),
                NationalityId="41650607492"
            };
            Gamer gamer2 = new Gamer()
            {
                Id = 1,
                FirstName = "Hazar",
                LastName = "Kürşat",
                DateOfBirth = new DateTime(1999, 8, 26),
                NationalityId = "78945612332"
            };

            List<Gamer> gamers = new List<Gamer>() { gamer1,gamer2};
            foreach (Gamer gamer in gamers)
            {
                gamerManager.Add(gamer);
            }

            Console.WriteLine("------------------------------------------------------------");

            CampaignManager campaignManager = new CampaignManager();

            Campaign campaign1 = new Campaign() {Id=1, CampaignName = " %40 Discount ",DiscountRate = 0.60M };
            Campaign campaign2 = new Campaign() { Id = 2, CampaignName = " %30 Discount ", DiscountRate = 0.80M };

            List<Campaign> campaigns = new List<Campaign>() { campaign1,campaign2};
            foreach (Campaign campaign in campaigns)
            {
                campaignManager.Add(campaign);
            }

            Console.WriteLine("------------------------------------------------------------");

            GameManager gameManager = new GameManager();

            Game game1 = new Game() {Id=1, GameName="Game1", GamePrice=110 };
            Game game2 = new Game() { Id = 1, GameName = "Game2", GamePrice = 120 };

            gameManager.Add(game1);
            gameManager.Add(game2);

            Console.WriteLine("------------------------------------------------------------");

            OrderManager orderManager = new OrderManager();
            orderManager.CampaignOrder(gamer1,game1,campaign1);
            orderManager.Order(gamer1,game1);
            







        }
    }
}
