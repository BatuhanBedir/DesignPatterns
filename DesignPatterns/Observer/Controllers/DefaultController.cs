using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Observer.DAL;
using Observer.Models;
using Observer.ObserverPattern;

namespace Observer.Controllers;

public class DefaultController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ObserverObject _observerObject;
    public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
    {
        _userManager = userManager;
        _observerObject = observerObject;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(RegisterVM model)
    {
        var appUser = new AppUser()
        {
            Name = model.Name,
            Surname = model.Surname,
            Email = model.Email,
            UserName = model.Username,
            City = model.City,
            District = model.District
        };
        var result = await _userManager.CreateAsync(appUser,model.Password);
        if(result.Succeeded)
        {
            _observerObject.NotifyObserver(appUser);
        }

        return View();
    }
}
