using GameStore.Abstracts;
using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concretes
{
    public class GamerManager : IGamerService
    {
         IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " : Added successfully.");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " "+ gamer.LastName +" : ( Not Valid Person !!! ) Information could not verified");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+ " " +gamer.LastName + " deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " updated.");
        }
    }
}
