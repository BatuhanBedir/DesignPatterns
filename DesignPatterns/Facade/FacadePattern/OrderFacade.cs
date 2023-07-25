using Facade.DAL;

namespace Facade.FacadePattern;

public class OrderFacade
{
    Order order = new Order();
    OrderDetail orderDetail = new OrderDetail();
    ProductStock productStock = new ProductStock();

    AddOrder addOrder = new AddOrder();
    AddOrderDetail addOrderDetail = new AddOrderDetail();

    public void CompletedOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice)
    {
        orderDetail.OrderId = orderId;
        orderDetail.CustomerId = customerId;
        orderDetail.ProductId = productId;
        orderDetail.Count = productCount;
        decimal totalProductPrice = productPrice * productPrice;
        orderDetail.TotalPrice = totalProductPrice;
        addOrderDetail.AddNewOrderDetail(orderDetail);

        productStock.StockDecrease(productId, productCount);
    }
    public void CompleteOrder(int customerId)
    {
        order.CustomerId = customerId;
        addOrder.AddNewOrder(order);
    }

}
