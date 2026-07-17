using Microsoft.EntityFrameworkCore;
using RetailInventory;

using var context = new InventoryContext();
DbInitializer.Initialize(context);

Console.WriteLine("EF Core Retail Inventory sample initialized.");
Console.WriteLine("Products in database:");

var products = context.Products
    .Include(p => p.Category)
    .Include(p => p.Store)
    .ToList();

foreach (var product in products)
{
    Console.WriteLine($"{product.ProductId}: {product.Name} ({product.Category?.Name}) - ${product.Price} in {product.Store?.Name}");
}
