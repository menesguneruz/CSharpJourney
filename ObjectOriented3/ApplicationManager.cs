using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented3
{
    class ApplicationManager
    {
        public void MakeApplication(ICreditBaseManager creditBaseManager)
        {
               creditBaseManager.Calculate();
        }
    }
}
