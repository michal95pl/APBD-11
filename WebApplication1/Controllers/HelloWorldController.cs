using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class HelloWorldController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}