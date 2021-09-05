using GameStore.Abstracts;
using GameStore.Adapter;
using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;




namespace GameStore.Concretes
{
    public class GamerCheckManager : IGamerCheckService
    {
         IGamerCheckService _gamerCheckService;

        
        public bool Check(Gamer gamer)
        {
            _gamerCheckService = new Mernis();
            return _gamerCheckService.Check(gamer);
        }
    }
}
