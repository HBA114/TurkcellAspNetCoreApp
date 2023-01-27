using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers;

public class OrnekController : Controller
{
    public IActionResult Index()
    {
        // ViewBag for basic data
        ViewBag.Name = "AspNetCore";
        ViewBag.NameList = new List<string>() { "Hasan", "Ahmet", "Mustafa" };

        ViewData["Age"] = 23;
        ViewData["Persons"] = new List<string>() { "Hasan", "Ahmet", "Mustafa" };

        ViewBag.Person = new { Id = 1, Name = "Hasan", Age = 23 };
        // ViewModel for bigger data
        return View();
    }

    public IActionResult Index2()
    {
        return RedirectToAction("Index", "Ornek");
    }

    public IActionResult ParameterView(int id)
    {
        return RedirectToAction("JsonResultParameter", "Ornek", new { id = id });
    }

    public IActionResult JsonResultParameter(int id)
    {
        return Json(new { Id = id });
    }

    public IActionResult ContentResult()
    {
        return Content("Content Result");
    }

    public IActionResult JsonResult()
    {
        return Json(new { Id = 1, Name = "Pencil", Price = 100 });
    }

    public IActionResult EmptyResult()
    {
        return new EmptyResult();
    }
}