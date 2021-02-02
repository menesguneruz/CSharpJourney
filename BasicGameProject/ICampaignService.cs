using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    interface ICampaignService
    {
        void AddCampaign(Gamer gamer);
        void UpdateCampaing(Gamer gamer);
        void DeleteCampaign(Gamer gamer);

    }
}
