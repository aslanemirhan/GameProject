﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int GamePrice { get; set; }
        public string Category { get; set; }
    }
}
