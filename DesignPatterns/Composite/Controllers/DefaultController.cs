using Composite.CompositePattern;
using Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Composite.Controllers;

public class DefaultController : Controller
{
    private readonly Context _context;

    public DefaultController(Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var categories = _context.Categories.Include(x=>x.Products).ToList();
        var values = Recursive(categories, new Category { Name = "FirstCategory", Id = 0 }, new ProductComposite(0, "FirstComposite"));
        ViewBag.v = values;
        return View();
    }
    public ProductComposite Recursive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leaf = null)
    {
        categories.Where(x => x.UpperCategoryId == firstCategory.Id).ToList().ForEach(y =>
        {
            var productComposite = new ProductComposite(y.Id, y.Name);
            y.Products.ToList().ForEach(x =>
            {
                productComposite.Add(new ProductComponent(x.Id, x.Name));
            });
            if( leaf is not null)
            {
                leaf.Add(productComposite);
            }
            else
            {
                firstComposite.Add(productComposite);
            }
            Recursive(categories, y, firstComposite, productComposite);
        });
        return firstComposite;

    }
}
