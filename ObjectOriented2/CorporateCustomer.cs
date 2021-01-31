using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented2
{
    class CorporateCustomer : Customer  // Inheritance
    {
        public string TaxNo { get; set; }
        public string CompanyName { get; set; }
    }
}
