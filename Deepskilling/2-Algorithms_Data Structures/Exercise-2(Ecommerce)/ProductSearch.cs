using System;
using System.Collections.Generic;

public class ProductSearch
{
    public static Product LinearSearch(List<Product> products, string searchItem)
    {
        foreach (Product product in products)
        {
            if (product.ProductName.ToLower().Contains(searchItem.ToLower()))
            {
                return product;
            }
        }

        return null;
    }
}