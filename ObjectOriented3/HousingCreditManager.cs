using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented3
{
    class HousingCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing credit paying plan has calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
