﻿namespace Facade.DAL;

public class OrderDetail
{
    public int Id { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice { get; set; }
    public int? ProductId { get; set; }
    public Product Product { get; set; }
    public int? CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int? OrderId { get; set; }
    public Order Order { get; set; }
}
