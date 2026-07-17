namespace RetailInventory;

public static class DbInitializer
{
    public static void Initialize(InventoryContext context)
    {
        context.Database.EnsureCreated();

        if (context.Products.Any())
        {
            return;
        }

        var categories = new[]
        {
            new Category { Name = "Apparel" },
            new Category { Name = "Electronics" },
            new Category { Name = "Home Goods" }
        };

        var stores = new[]
        {
            new Store { Name = "Central Warehouse", Location = "Headquarters" },
            new Store { Name = "West Retail", Location = "West City" }
        };

        context.Categories.AddRange(categories);
        context.Stores.AddRange(stores);
        context.SaveChanges();

        var products = new[]
        {
            new Product { Name = "T-shirt", Price = 19.99m, QuantityInStock = 120, CategoryId = categories[0].CategoryId, StoreId = stores[0].StoreId },
            new Product { Name = "Jeans", Price = 49.99m, QuantityInStock = 60, CategoryId = categories[0].CategoryId, StoreId = stores[1].StoreId },
            new Product { Name = "Laptop", Price = 1199.99m, QuantityInStock = 18, CategoryId = categories[1].CategoryId, StoreId = stores[0].StoreId },
            new Product { Name = "Noise-Cancelling Headphones", Price = 199.99m, QuantityInStock = 32, CategoryId = categories[1].CategoryId, StoreId = stores[1].StoreId },
            new Product { Name = "Coffee Maker", Price = 89.99m, QuantityInStock = 25, CategoryId = categories[2].CategoryId, StoreId = stores[0].StoreId },
            new Product { Name = "Blender", Price = 59.99m, QuantityInStock = 40, CategoryId = categories[2].CategoryId, StoreId = stores[1].StoreId }
        };

        context.Products.AddRange(products);
        context.SaveChanges();
    }
}
