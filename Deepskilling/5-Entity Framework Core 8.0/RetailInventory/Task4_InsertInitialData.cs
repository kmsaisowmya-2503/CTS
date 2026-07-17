namespace RetailInventory;

public static class Task4_InsertInitialData
{
    public static void Run(InventoryContext context)
    {
        Console.WriteLine("Task 4: Inserting Initial Data into the Database");
        DbInitializer.Initialize(context);
        Console.WriteLine($"Seeded {context.Categories.Count()} categories, {context.Stores.Count()} stores, and {context.Products.Count()} products.\n");
    }
}
