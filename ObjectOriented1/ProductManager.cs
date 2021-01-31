using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            //There have to be operation codes in real life.
            Console.WriteLine(product.ProductName + " Added!");
        }
    }
}
