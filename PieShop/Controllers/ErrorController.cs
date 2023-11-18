using Microsoft.AspNetCore.Mvc;

namespace PieShop.Controllers;

public class ErrorController : Controller
{
    [Route("/Home/Error/{statusCode}")]
    public IActionResult Error(int statusCode)
    {

        return View("Error");
    }
}