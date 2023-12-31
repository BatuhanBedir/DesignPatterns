﻿namespace Facade.DAL;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }

}
