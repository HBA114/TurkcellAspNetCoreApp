using Microsoft.AspNetCore.Mvc;
using TurkcellAspNetCoreApp.Web.Models;

namespace TurkcellAspNetCoreApp.Web.Controllers;

public class ProductsController : Controller
{
    private AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
        if (!_context.Products.Any())
        {
            _context.Products.Add(new() { Name = "Pen 1", Price = 100, Stock = 200 });
            _context.Products.Add(new() { Name = "Pen 2", Price = 200, Stock = 200 });
            _context.Products.Add(new() { Name = "Pen 3", Price = 300, Stock = 200 });

            _context.SaveChanges();
        }
    }

    public IActionResult Index()
    {
        var products = _context.Products.ToList();

        return View(products);
    }

    public IActionResult Remove(int id)
    {
        var product = _context.Products.Find(id);
        _context.Products.Remove(product);

        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Add()
    {
        return View();
    }
}
