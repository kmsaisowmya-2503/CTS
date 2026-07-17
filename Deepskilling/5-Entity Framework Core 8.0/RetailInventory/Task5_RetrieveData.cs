using Microsoft.EntityFrameworkCore;

namespace RetailInventory;

public static class Task5_RetrieveData
{
    public static void Run(InventoryContext context)
    {
        Console.WriteLine("Task 5: Retrieving Data from the Database");
        var products = context.Products
            .Include(p => p.Category)
            .Include(p => p.Store)
            .ToList();

        foreach (var product in products)
        {
            Console.WriteLine($"{product.ProductId}: {product.Name} ({product.Category?.Name}) - ${product.Price} in {product.Store?.Name}");
        }

        Console.WriteLine();
    }
}
