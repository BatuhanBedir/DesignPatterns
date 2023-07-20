using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Models;

namespace UnitOfWork.Controllers;

public class DefaultController : Controller
{
    private readonly ICustomerService _customerService;

    public DefaultController(ICustomerService customerService)
    {
        _customerService = customerService;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(CustomerVM customerVM)
    {
        var sender = _customerService.TGetById(customerVM.SenderId);
        var receiver = _customerService.TGetById(customerVM.ReceiverId);

        sender.Balance -= customerVM.Amount;
        receiver.Balance += customerVM.Amount;

        List<Customer> modifiedCustomers = new List<Customer>()
        {
            sender,
            receiver
        };

        _customerService.TMultiUpdate(modifiedCustomers);

        return View();
    }
}
