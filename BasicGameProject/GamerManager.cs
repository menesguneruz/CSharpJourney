using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class GamerManager : IGamerService
    {
        private IValidateGamerService _validateGamerService;

        public GamerManager(IValidateGamerService validateGamerService)
        {
            _validateGamerService = validateGamerService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("The gamer has added!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("The gamer has updated!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("The gamer has deleted!");
        }
    }
}
