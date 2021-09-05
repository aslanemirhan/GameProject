using GameStore.Abstracts;
using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concretes
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " : Added To Cart");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " : deleted.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " : updated.");
        }
    }
}
