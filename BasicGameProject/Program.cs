using System;

namespace BasicGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidateGamerManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "MUSTAFA",
                LastName = "GUNERUZ",
                BirthYear = 2001,
                IdentityNo = 12345678910
            });
        }
    }
}
