using System;

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

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(personalFinanceCreditManager);
        }
    }
}
