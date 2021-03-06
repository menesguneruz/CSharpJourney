﻿using System;

namespace ObjectOriented1
{
    class Program
    {
        static void Main(string[] args)
        {
            //First creating object way
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            
            //Second creating object way
            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Pencil",
                UnitPrice = 3
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
