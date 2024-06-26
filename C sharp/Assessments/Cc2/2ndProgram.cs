using System;
using System.Collections.Generic;

namespace Cc2
{

    class Products
    {
        public int ProductId;
        public string ProductName;
        public decimal Price;
    }

    class Program
    {
        static void Main()
        {
            List<Products> products = new List<Products>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for product {i + 1}:");
                Products product = new Products();

                Console.Write("Product Name: ");
                product.ProductName = Console.ReadLine();

                Console.Write("Price: ");
                product.Price = Convert.ToInt32(Console.ReadLine());

                product.ProductId = i + 1;
                products.Add(product);
            }
            for (int i = 0; i < products.Count - 1; i++)
            {
                for (int j = i + 1; j < products.Count; j++)
                {
                    if (products[i].Price > products[j].Price)
                    {
                        Products temp = products[i];
                        products[i] = products[j];
                        products[j] =  temp;
                    }
                }
            }
            Console.WriteLine("Sorted Products by Price:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price:C}");
            }

            Console.ReadLine();
        }
    }
}

