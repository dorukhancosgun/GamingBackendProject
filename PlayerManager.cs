using System;
using System.Collections.Generic;
using System.Text;

namespace GamingBackendProject
{
    class PlayerManager : IPlayerServices
    {
        public void DeletePlayer(Player player)
        {
            Console.WriteLine(player.PlayerName + " has successfully deleted.");
        }

        public void NewPlayer(Player player)
        {
            Console.WriteLine(player.PlayerName + " has successfully added.");
        }

        public void UpdatePlayer(Player player)
        {
            Console.WriteLine(player.PlayerName + " named players informations are updated. ");
        }
    }
}
