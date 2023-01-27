using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers;

public class OrnekController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Index2()
    {
        return RedirectToAction("Index", "Ornek");
    }

    public IActionResult ParameterView(int id)
    {
        return RedirectToAction("JsonResultParameter", "Ornek", new {id=id});
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