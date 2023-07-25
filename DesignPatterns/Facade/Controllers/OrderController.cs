using Facade.DAL;
using Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace Facade.Controllers;

public class OrderController : Controller
{

    [HttpGet]
    public IActionResult OrderStart()
    {
        return View();
    }
    [HttpPost]
    public IActionResult OrderStart(int customerId)
    {
        OrderFacade orderFacade = new OrderFacade();    
        orderFacade.CompleteOrder(customerId);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult OrderDetailStart()
    {
        return View();
    }
    [HttpPost]
    public IActionResult OrderDetailStart(int customerId, int productId, int orderId, decimal price, int count)
    {
        OrderFacade order = new OrderFacade();
        order.CompletedOrderDetail(customerId, productId, orderId,count, price);
        return RedirectToAction("Index");
    }
    public IActionResult Index()
    {
        return View();
    }
}
