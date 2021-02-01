using System;
using System.Collections.Generic;

namespace ObjectOriented3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditBaseManager vehicleCreditManager = new VehicleCreditManager();
            ICreditBaseManager housingCreditManager = new HousingCreditManager();
            // Interfaces can keep the other classes's references too.

            ILoggerService databaLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(personalFinanceCreditManager, databaLoggerService);

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() { vehicleCreditManager, personalFinanceCreditManager };

            //applicationManager.GiveCreditInformation(credits);
        }
    }
}
