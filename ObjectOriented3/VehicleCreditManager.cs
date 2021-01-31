using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented3
{
    class VehicleCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle credit paying plan has calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
