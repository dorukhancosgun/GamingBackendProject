using System;
using System.Collections.Generic;
using System.Text;

namespace GamingBackendProject
{
     class GameSaleManager
    {
        public void GameSale(Player player, Game game)
        {
            Console.WriteLine(player.PlayerName + " has " + game.GameName + " proceeded the checkout.");
        }
    }
}
