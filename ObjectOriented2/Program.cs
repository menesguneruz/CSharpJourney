using System;

namespace ObjectOriented2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();
            CorporateCustomer customer3 = new CorporateCustomer();
            /* !! Customer class can keep both individual and corporate classes's references. !! */

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
        }
    }
    /*NOTES: !!! PROPERTY AND OPERATION CASES MUST BE IN SEPERATE CLASSES. !!!*/
}
