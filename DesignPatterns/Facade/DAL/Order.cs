namespace Facade.DAL;

public class Order
{
    public Order()
    {
        OrderDetails = new HashSet<OrderDetail>();
    }
    public int Id { get; set; }
    public int? CustomerId { get; set; }
    public Customer Customer { get; set; }
    public DateTime OrderDate { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}