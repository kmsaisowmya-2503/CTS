namespace RetailInventory;

public static class Task1_UnderstandingOrm
{
    public static void Run()
    {
        Console.WriteLine("Task 1: Understanding ORM with a Retail Inventory System");
        var category = new Category { Name = "Apparel" };
        var store = new Store { Name = "Central Warehouse", Location = "Headquarters" };
        var product = new Product
        {
            Name = "T-shirt",
            Price = 19.99m,
            QuantityInStock = 120,
            Category = category,
            Store = store
        };

        Console.WriteLine($"Product: {product.Name}");
        Console.WriteLine($"Category: {product.Category?.Name}");
        Console.WriteLine($"Store: {product.Store?.Name}");
        Console.WriteLine("This demonstrates how entity classes model data and relationships in EF Core.\n");
    }
}
