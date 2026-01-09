using Microsoft.AspNetCore.Mvc;

namespace mvc_learning.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
