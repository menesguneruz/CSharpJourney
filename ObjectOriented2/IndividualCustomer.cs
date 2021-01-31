using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented2
{
    class IndividualCustomer : Customer // Inheritance
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNo { get; set; }
    }
}
