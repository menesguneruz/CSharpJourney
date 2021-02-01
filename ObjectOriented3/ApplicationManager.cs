using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented3
{
    class ApplicationManager
    {
        public void MakeApplication(ICreditBaseManager creditBaseManager, ILoggerService loggerService) // Method injection
        {
               creditBaseManager.Calculate();
               loggerService.Log();
        }

        // The user may be wants to see more than one credit information, than we sent List structure as parameter.
        public void GiveCreditInformation(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {  
                credit.Calculate(); 
            }
        }
    }
}
