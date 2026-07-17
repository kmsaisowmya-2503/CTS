namespace RetailInventory;

public class Store
{
    public int StoreId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
