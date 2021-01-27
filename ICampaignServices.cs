using GamingBackendProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingBackend
{
    interface ICampaignServices
    {
        void CampaignEntry(Game game);
        
        void DeleteCampaign(Game game);
        
        void UpdateCampaign(Game game);
        
    }
}
