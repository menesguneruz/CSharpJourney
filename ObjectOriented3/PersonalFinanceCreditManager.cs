using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented3
{
    class PersonalFinanceCreditManager : ICreditBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal finance credit paying plan has calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
