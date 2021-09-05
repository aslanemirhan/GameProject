using GameStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstracts
{
    public interface IGamerCheckService
    {
        bool Check(Gamer gamer);
    }
}
