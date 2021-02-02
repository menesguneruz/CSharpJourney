using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Gamer gamer)
        {
            Console.WriteLine("The campaing has added to the " + gamer.FirstName + " " + gamer.LastName + "'s account.");
        }

        public void UpdateCampaing(Gamer gamer)
        {
            Console.WriteLine("The campaing has updated.");
        }

        public void DeleteCampaign(Gamer gamer)
        {
            Console.WriteLine("The campaing has deleted from the " + gamer.FirstName + " " + gamer.LastName + "'s account.");
        }
    }
}
