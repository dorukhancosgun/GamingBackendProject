using System;
using System.Collections.Generic;
using System.Text;

namespace GamingBackendProject
{
    interface IPlayerServices
    {
        void NewPlayer(Player player);
        void DeletePlayer(Player player);
        void UpdatePlayer(Player player);
    }
}
