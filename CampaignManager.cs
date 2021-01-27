using GamingBackend;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingBackendProject
{
    class CampaignManager : ICampaignServices
    {
        void ICampaignServices.CampaignEntry(Game game)
        {
            Console.WriteLine(game.GameName + " has %50 saled.");
            Console.WriteLine("New Price :" + game.GamePrice / 2 );
        }
    

        void ICampaignServices.DeleteCampaign(Game game)
        {
            Console.WriteLine(game.GameName + " sale is over.");
        }



        void ICampaignServices.UpdateCampaign(Game game)
        {
            Console.WriteLine(game.GameName + " has a new sale.");
        }
    }
}
