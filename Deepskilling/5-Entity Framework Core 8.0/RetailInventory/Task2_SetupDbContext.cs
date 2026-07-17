using Microsoft.EntityFrameworkCore;

namespace RetailInventory;

public static class Task2_SetupDbContext
{
    public static void Run(InventoryContext context)
    {
        Console.WriteLine("Task 2: Setting Up the Database Context for a Retail Store");
        context.Database.EnsureCreated();
        Console.WriteLine($"Database provider: {context.Database.ProviderName}");
        Console.WriteLine("DbContext is configured and the database has been created if it did not exist.\n");
    }
}
