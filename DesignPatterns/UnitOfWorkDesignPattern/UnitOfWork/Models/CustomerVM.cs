namespace UnitOfWork.Models;

public class CustomerVM
{
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public decimal Amount { get; set; }
}
