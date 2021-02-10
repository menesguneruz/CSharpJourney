﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category{CategoryId = 1, CategoryName = "Bilgisayar"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 10000, UnitsInStock = 5},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "16 GB RAM", UnitPrice = 8000, UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 1, ProductName = "HP Laptop", QuantityPerUnit = "8 GB RAM", UnitPrice = 6000, UnitsInStock = 6},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "2 GB RAM", UnitPrice = 5000, UnitsInStock = 14},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Apple Telefon", QuantityPerUnit = "4 GB RAM", UnitPrice = 7000, UnitsInStock = 0}
            };

            //Test(products);


        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik\n-------------------------------------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                    Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("\nLinq\n-------------------------------------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
