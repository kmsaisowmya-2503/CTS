namespace RetailInventory;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int QuantityInStock { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public int StoreId { get; set; }
    public Store? Store { get; set; }
}
