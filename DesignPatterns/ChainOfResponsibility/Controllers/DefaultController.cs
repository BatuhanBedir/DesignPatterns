using ChainOfResponsibility.ChainOfResponsibility;
using ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessVM customerProcessVM)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector = new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcesRequest(customerProcessVM);

            return View();
        }
    }
}
