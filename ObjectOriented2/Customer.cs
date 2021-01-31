using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented2
{
    class Customer
    {
        // If a property is pointless (For example company prop in a customer class), that means you're making a mistake!!! (probably abstraction mistake)
        public int Id { get; set; }
        public string CustomerNo { get; set; }
    }
}
