using System;

namespace BasicGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                FirstName = "MUSTAFA",
                LastName = "GUNERUZ",
                BirthYear = 2001,
                IdentityNo = 12345678910
            };

            GamerManager gamerManager = new GamerManager(new ValidateGamerManager());
            gamerManager.Add(gamer1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(gamer1);


        }
    }
}
