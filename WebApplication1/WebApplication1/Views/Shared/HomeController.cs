using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Views.Shared
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
