using Microsoft.AspNetCore.Mvc;
using TemplateMethod.TemplatePattern;

namespace TemplateMethod.Controllers;

public class DefaultController : Controller
{
    public IActionResult BasicPlanIndex()
    {
        NetflixPlans netflixPlans = new BasicPlan();
        SetViewBagValues(netflixPlans, "Temel Plan", 1, 65.99, "Film-Dizi", "480px");
        return View();
    }

    public IActionResult StandardPlanIndex()
    {
        NetflixPlans netflixPlans = new StandardPlan();
        SetViewBagValues(netflixPlans, "Standart Plan", 2, 94.99, "Film-Dizi-Animasyon", "720px");
        return View();
    }

    public IActionResult UltraPlanIndex()
    {
        NetflixPlans netflixPlans = new UltraPlan();
        SetViewBagValues(netflixPlans, "Ultra Plan", 4, 134.99, "Film-Dizi-Animasyon-Belgesel", "1080px");
        return View();
    }

    private void SetViewBagValues(NetflixPlans netflixPlans, string planType, int countPerson, double price, string content, string resolution)
    {
        ViewBag.v1 = netflixPlans.PlanType(planType);
        ViewBag.v2 = netflixPlans.CountPerson(countPerson);
        ViewBag.v3 = netflixPlans.Price(price);
        ViewBag.v4 = netflixPlans.Content(content);
        ViewBag.v5 = netflixPlans.Resolution(resolution);
    }
}
