namespace Facade.DAL;

public class Customer
{
    public Customer()
    {
        Orders = new HashSet<Order>();
        OrderDetails= new HashSet<OrderDetail>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }

}
