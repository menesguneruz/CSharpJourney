using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Product object.
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Apple from Amasya Turkey";

            Product product2 = new Product();

            product2.Name = "Watermelon";
            product2.Price = 40;
            product2.Description = "Delicious Watermelons form Diyarbakir";

            Product[] products = new Product[] {product1, product2};

            // foreach method visits and does operations on each products array elements.
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------Methods---------");

            BasketManager basketManager = new BasketManager();
            basketManager.Add();
        }
    }
}
