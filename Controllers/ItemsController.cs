using Microsoft.AspNetCore.Mvc;
using mvc_learning.Models;

namespace mvc_learning.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item()
            {
                Name = "Mouse"
            };

            return View(item);
        }

        public IActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
    }
}
