using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product
            {
                ProductId = 101,
                ProductName = "Laptop",
                Category = "Electronics"
            },

            new Product
            {
                ProductId = 102,
                ProductName = "Mobile Phone",
                Category = "Electronics"
            },

            new Product
            {
                ProductId = 103,
                ProductName = "Running Shoes",
                Category = "Fashion"
            }
        };


        Console.Write("Enter product name to search: ");
        string search = Console.ReadLine();


        Product result = ProductSearch.LinearSearch(products, search);


        if (result != null)
        {
            Console.WriteLine("Product Found:");
            Console.WriteLine($"{result.ProductId}, {result.ProductName}, {result.Category}");
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }
}