using System;
using System.Collections.Generic;
using System.Text;

namespace BasicGameProject
{
    class ValidateGamerManager : IValidateGamerService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "MUSTAFA" && gamer.BirthYear == 2001 && gamer.LastName == "GUNERUZ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
